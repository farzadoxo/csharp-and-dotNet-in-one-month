using System.Net;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;

public class SecurityFilter : ActionFilterAttribute
{   
    private readonly string _Role;
    public SecurityFilter(string role)
    {
        _Role = role;
    }

    public override void OnActionExecuting(ActionExecutingContext context)
    {
        context.HttpContext.Request.Headers.TryGetValue("Authorization",out 
        StringValues authorizationHeader);

        // Check Token Exists
        if(string.IsNullOrEmpty(authorizationHeader))
        {
            ReturnError(Errors.NoToken,context);
        }
        else
        {
            // Chek Token Type
            if(authorizationHeader.ToString().Contains("Bearer"))
            {
                // Check Token Validation
                string token = authorizationHeader.ToString().Replace("Bearer ", "");
                var principal = TokenSystem.Validate(token);

                if(principal != null)
                {
                    string userid = principal.Claims.Where(x=> x.Type == "UserId").FirstOrDefault().Value;
                    string rolename = principal.Claims.Where(x=> x.Type == "Role").FirstOrDefault().Value;

                    // Check User Exist
                    if(!string.IsNullOrEmpty(userid))
                    {
                        var _userManager = (UserManager<IdentityUser>) context.HttpContext.RequestServices.GetService(typeof(UserManager<IdentityUser>));
                        var user = _userManager.FindByIdAsync(userid).Result;

                        var _roleManager = (RoleManager<IdentityRole>) context.HttpContext.RequestServices.GetService(typeof(RoleManager<IdentityRole>));
                        var role = _roleManager.FindByNameAsync(_Role).Result;

                        bool isinrole = _userManager.IsInRoleAsync(user,rolename).Result;
                        
                        if(isinrole)
                        {
                            if(rolename == _Role)
                            {
                                return;
                                
                            }
                            else
                            {
                                ReturnError(Errors.RoleUnauthorized,context);
                            }
                        }
                        else
                        {
                             ReturnError(Errors.NoUserRole,context);
                        }

                        
                    }
                    else
                    {
                        ReturnError(Errors.UserDoNotExists,context);
                    }
                }
                else
                {
                    ReturnError(Errors.InvalidToken,context);
                }
            }
            else
            {
                ReturnError(Errors.InvalidTokenType,context);
            }
        }

    }

    public override void OnActionExecuted(ActionExecutedContext context)
    {
        base.OnActionExecuted(context);
    }


    public static void ReturnError(Errors error,ActionExecutingContext context)
    {
        switch(error)
        {
            case Errors.NoToken:
                context.Result = new JsonResult(new {HttpStatusCode = HttpStatusCode.Unauthorized , Message="Client dont have any token !"});
                break;
            case Errors.InvalidTokenType:
                context.Result = new JsonResult(new {HttpStatusCode = HttpStatusCode.Unauthorized , Message="Clients Token is not a Bearer type !"});
                break;
            case Errors.InvalidToken:
                context.Result = new JsonResult(new {HttpStatusCode = HttpStatusCode.Unauthorized , Message="Invalid Token !"});
                break;
            case Errors.UserDoNotExists:
                context.Result = new JsonResult(new {HttpStatusCode = HttpStatusCode.Unauthorized , Message="User is does not exists !"});
                break;
            case Errors.NoUserRole:
                context.Result = new JsonResult(new {HttpStatusCode = HttpStatusCode.Unauthorized , Message="You dont have User Role"});
                break;
            case Errors.RoleUnauthorized:
                context.Result = new JsonResult(new {HttpStatusCode = HttpStatusCode.Unauthorized , Message="Your role is not authorized !"});
                break;
            default:
                context.Result = new JsonResult(new {HttpStatusCode = HttpStatusCode.InternalServerError , Message="Somthing wrong happend !"});
                break;
        }
    }
}