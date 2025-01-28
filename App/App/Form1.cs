using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;
namespace App;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Showbtn.Click += Showbtn_Click;
    }

    public void Showbtn_Click(object sender , EventArgs e)
    {
        GetAllData();
    }


    public void GetAllData()
    {
        string connectionstring = "data source=DESKTOP-B7H346L; initial catalog=MyDb; integrated security=true; Encrypt=true";
        SqlConnection connection = new SqlConnection(connectionstring);
        SqlCommand command = new SqlCommand("SELECT * FROM Users",connection);
        SqlDataReader reader = null;
        DataTable dt = new DataTable();
        connection.Open();

        reader = command.ExecuteReader(); 
        dt.Load(reader);

        while(reader.Read())
        {
            var resault = reader.GetValue(1);
            MessageBox.Show(resault.ToString());
        }
        connection.Close();
    }
}
