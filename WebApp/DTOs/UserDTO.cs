using MyWebAPI.Models;

namespace MyWebAPI.DTOs
{
    public class UserDTO
    {
        public UserDTO(int count,List<User> users)
        {
            Count = count;
            Users = new HashSet<User>();
        }
        public int Count { get; set; }
        public ICollection<User> Users { get; set;}
    }

    
}