using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        Form1 Form1=new Form1();

        Form2 Form2=new Form2();    
        DataDisplay dataDisplay;
        static string myconnstring = @"Data Source=DESKTOP-GELNTAD\SQLEXPRESS;Initial Catalog=IDIADemo;Integrated Security=True";
        SqlConnection conn = new SqlConnection(myconnstring);
        SqlDataAdapter adapter;
        SqlDataReader dr;
        DataTable dt;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                //SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [User] WHERE Email=@Email AND Password=@Password", conn);

                //string sql = "SELECT * FROM [User] WHERE Email=@Email AND Password=@Password";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                string sql = "SELECT Password, UserRole FROM [User] WHERE Email=@Email";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Email", Username_textbox.Text);
                string storedPassword;

                

                string email=Username_textbox.Text;

                storedPassword = (string)cmd.ExecuteScalar();
                

                
              
                
                //MessageBox.Show(dr["Password"].ToString());

                string textPassword=Password_textbox.Text;




                cmd.Parameters.AddWithValue("@Password", Password_textbox.Text);


                


                //if (dr.Read())
                //{
                //    var UserRole= dr["UserRole"].ToString();
                //    Console.WriteLine(UserRole);
                //}

                bool match=BCrypt.Net.BCrypt.Verify(Password_textbox.Text,storedPassword);
                if (match && email == "joe@abc.com" || email == "s.zeidan@gmail.com")
                {
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    
                    {
                        //MessageBox.Show(dr["UserRole"].ToString());
                        this.Hide();
                        //Form1.Show();
                        Form2.Show();
                    }
                    
                }
                else if(match)
                {
                    
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        //MessageBox.Show("Login sucess Welcome to Homepage");
                        dataDisplay = new DataDisplay(email);

                        this.Hide();
                        //Form1.Show();
                        dataDisplay.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                    //Application.Exit();
                    Username_textbox.Text = "";
                    Password_textbox.Text = "";
                }
                
            
                    


                 

                //DataTable dt = new DataTable();
                //sda.Fill(dt);
                //if(dt.Rows[0][0].ToString = "1")
                //{

                //}



                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
