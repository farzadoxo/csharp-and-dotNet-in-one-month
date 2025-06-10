using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;
using Repositories.UserRepository;
using Repositories.IUserRepository;
namespace App;


public partial class Form1 : Form
{
    private readonly IUR repository;
    public Form1()
    {
        InitializeComponent();
        Showbtn.Click += new EventHandler(Showbtn_Click);
        Addbtn.Click += Addbtn_Click;
        repository = new UserRepository();
        
    }

    public void Showbtn_Click(object sender , EventArgs e)
    {
        if(Idtxt.Text == "")
        {
            dbdgv.DataSource = repository.GetAllData();
        }
        else
        {
            dbdgv.DataSource = repository.GetById(Convert.ToInt32(Idtxt.Text));
        }
        
    }

    public void Addbtn_Click(object sender , EventArgs e)
    {
        
        int resault = repository.AddRecord(Nametxt.Text,Emailtxt.Text);
        if(resault > 0)
        {
            Nametxt.Clear();    
            Emailtxt.Clear();
            MessageBox.Show("رکورد جدید اضافه شد");
        }
        else
        {
            MessageBox.Show("خطایی رخ داد","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
       
        
    }


    

    

    
}
