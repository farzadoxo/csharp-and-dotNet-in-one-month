using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using MyWebAPI.Contexs;
using MyWebAPI.DTOs;
using MyWebAPI.Models;

public class UserRepository : IUserRepository
{
    private readonly UserContex _db;
    public UserRepository(UserContex db)
    {
        _db = db;
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
}