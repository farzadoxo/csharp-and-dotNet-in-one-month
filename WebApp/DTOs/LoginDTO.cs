public class LoginDTO
{
    public LoginDTO(string username , string password)
    {
        this.UserName = username;
        this.Password = password;
    }
    public string UserName { get; set; }
    public string Password { get; set; }
}