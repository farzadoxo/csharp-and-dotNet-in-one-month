using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyWebAPI.Contexs;
using MyWebAPI.DTOs;
using MyWebAPI.Models;

public class UserRepository : IUserRepository
{
    private readonly UserContex _db;
    private readonly UserManager<IdentityUser> _userManager;
    public UserRepository(UserContex db,UserManager<IdentityUser> userManager)
    {
        _db = db;
        _userManager = userManager;
    }
    public List<User> GetAllUser()
    {
        return _db.Userss.ToList();
    }

    public List<User> GetUserById()
    {
        return _db.Userss.ToList();
    }

    public List<User> GetPaging(int skip,int take)
    {
        return _db.Userss.Skip(skip).Take(take).ToList();
    }

    public UserDTO GetCount()
    {
        var count = _db.Userss.Count();
        var data = _db.Userss.ToList();
        UserDTO resault = new UserDTO(count,data);
        return resault;
    }

    public bool Register(RegisterDTO dto)
    {
        IdentityUser user = new IdentityUser
        {
            UserName=dto.UserName,
            PasswordHash= HashGenerator.Generate(dto.Password)
        };
        var i = _userManager.CreateAsync(user).Result;

        if(i!=null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
//     public bool Login(LoginDTO dto)
//     {
        
//         if(user == null)
//         {
//             return false;
//         }
//         else if(user.PasswordHash == HashGenerator.Generate(dto.Password))
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
//     }
// }