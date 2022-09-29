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
    public partial class DataDisplay : Form
    {

        static string myconnstring = @"Data Source=DESKTOP-GELNTAD\SQLEXPRESS;Initial Catalog=IDIADemo;Integrated Security=True";
        SqlConnection conn = new SqlConnection(myconnstring);
        string emaill;
        SqlDataReader dr;




        public DataDisplay(string email)
        {
            InitializeComponent();
            emaill = email;
            
        }

        private void DataDisplay_Load(object sender, EventArgs e)
        {

            try
            {
                conn.Open();

                string sql = "SELECT * FROM [User] WHERE Email=@Email";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Email", emaill);

                var results = cmd.ExecuteReader();








                if (results.FieldCount>0)
                {
                    results.Read();
                    MessageBox.Show(results.GetString(1).ToString()); 
                    IDLabel.Text = results.GetInt32(0).ToString();
                    FullNameLabel.Text = results.GetString(2).ToString();
                    AgeLabel.Text = results.GetString(4).ToString();
                    PhoneLabel.Text = results.GetString(5).ToString();
                    GenderLabel.Text = results.GetString(6).ToString();
                    //EmailLabel.Text = results.GetString(2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                conn.Close();   
            }
        }
    }
}
