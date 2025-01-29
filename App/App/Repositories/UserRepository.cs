using System.Data;
using System.Data.SqlClient;
using Repositories.IUserRepository;
using Repositories.SetConnection;
using Microsoft.Data.SqlClient;
using App;


namespace Repositories.UserRepository
{
    public class UserRepository : IUR
    {
        public DataTable GetAllData()
        {
            // Make a connection
            SetConnectionToDatabase my_connection = new SetConnectionToDatabase();

            // Make a command
            SqlCommand command = new SqlCommand("Usp_Users_GetAllData",my_connection.connection);
            command.CommandType = CommandType.StoredProcedure;

            // set reader and data table
            SqlDataReader reader = null;
            DataTable dt = new DataTable();

            // ACTION
            my_connection.connection.Open();

            reader = command.ExecuteReader(); 
            dt.Load(reader);
            
            // while(reader.Read())
            // {
            //     var resault = reader.GetValue();
            //     MessageBox.Show(resault.ToString());
            // }

            // Close connection
            my_connection.connection.Close();

            return dt;
        }

        public int AddRecord(string name , string email)
        {
            SetConnectionToDatabase my_connection = new SetConnectionToDatabase();
            SqlCommand command = new SqlCommand("Usp_Users_AddUser",my_connection.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Name",name);
            command.Parameters.AddWithValue("@Email",email);

            my_connection.connection.Open();
            int resault = command.ExecuteNonQuery();
            my_connection.connection.Close();
            return resault;
        }


        public User GetById(int id)
        {
            User user = new User();
            SetConnectionToDatabase my_connection = new SetConnectionToDatabase();
            SqlCommand command = new SqlCommand("Usp_Users_GetById",my_connection.connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id",id);

            my_connection.connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                user.Id = (int) reader["Id"];
                user.Name = reader["Name"].ToString();
                user.Email = reader["Email"].ToString();
            }

            my_connection.connection.Close();

            return user;
        }
    }
}