using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;

public class SecurityFilter : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        context.HttpContext.Request.Headers.TryGetValue("Authorization",out 
        StringValues authorizationHeader);

        // Check Token Exists
        if(string.IsNullOrEmpty(authorizationHeader))
        {
            context.Result = new JsonResult(new {HttpStatusCode = HttpStatusCode.Unauthorized , Message="اطلاعات وارد شده نادرست است!"});
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
                }
                else
                {
                    context.Result = new JsonResult(new {HttpStatusCode = HttpStatusCode.Unauthorized , Message="اطلاعات وارد شده نادرست است!"});
                }
            }
            else
            {
                context.Result = new JsonResult(new {HttpStatusCode = HttpStatusCode.Unauthorized , Message="اطلاعات وارد شده نادرست است!"});
            }
        }

    }

    public override void OnActionExecuted(ActionExecutedContext context)
    {
        base.OnActionExecuted(context);
    }
}