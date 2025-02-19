using MyWebAPI.DTOs;
using MyWebAPI.Models;

public interface IUserRepository
{
    public bool Register(RegisterDTO dto);
    public List<User> GetAllUser();
    public List<User> GetUserById();
    public List<User> GetPaging(int skip,int take);
    public UserDTO GetCount();
    public bool Login(LoginDTO dto);
}