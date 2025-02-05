public class User
{
    public User(string FullName , string Email)
    {
        this.FullName = FullName;
        this.Email = Email;
    }
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }

}