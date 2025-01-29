using System.Data;
using System.Data.SqlClient;

namespace Repositories.IUserRepository
{
    public interface IUR
    {
        public DataTable GetAllData();

        public void AddRecord(string name , string email);

        public User GetById(int id);
    }
}