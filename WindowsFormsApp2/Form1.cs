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
    public partial class Form1 : Form
    {
        static string myconnstring = @"Data Source=DESKTOP-GELNTAD\SQLEXPRESS;Initial Catalog=IDIADemo;Integrated Security=True";
        SqlConnection conn = new SqlConnection(myconnstring);
        SqlDataAdapter adapter;
        DataTable dt;
        int ID;
        public Form1()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(myconnstring);
            UpdateButton.Enabled = false;
            DeleteButton.Enabled = false;

            display();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iDIADemoDataSet.User' table. You can move, or remove it, as needed.
            

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {

            //SqlConnection conn = new SqlConnection(myconnstring);
        
            if (FullName_textbox.Text==""|| Email_textbox.Text == ""|| Phone_textbox.Text == ""|| Age_textbox.Text == ""|| Gender_comboBox1.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO [User] (FullName, Email, UserRole, Password, Phone, Age, Gender) VALUES (@FullName, @Email, @UserRole, @Password, @Phone, @Age, @Gender)";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    string passwordHash=BCrypt.Net.BCrypt.HashPassword(Password_textbox.Text);

                    cmd.Parameters.AddWithValue("@FullName", FullName_textbox.Text);
                    cmd.Parameters.AddWithValue("@Email", Email_textbox.Text);
                    cmd.Parameters.AddWithValue("@Password", passwordHash);
                    cmd.Parameters.AddWithValue("@Phone", Phone_textbox.Text);
                    cmd.Parameters.AddWithValue("@Age", Age_textbox.Text);
                    cmd.Parameters.AddWithValue("@Gender", Gender_comboBox1.Text);
                    cmd.Parameters.AddWithValue("@UserRole", UserRole_textbox.Text);

                    




                   int rowsAffected= cmd.ExecuteNonQuery();
                   if (rowsAffected > 0)
                    {
                        MessageBox.Show("User registered successfully");
                    }
                   else
                    {
                        MessageBox.Show("Failed");

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    display();
                    clear();

                }
            }
        }
        public void clear()
        {
            FullName_textbox.Text = "";
            Email_textbox.Text = "";
            Phone_textbox.Text = "";
            Age_textbox.Text = "";
            Gender_comboBox1.Text = "";
            Password_textbox.Text = ""; 
        }

        public void display()
        {
            try
            {
                dt = new DataTable();
                conn.Open();
                adapter = new SqlDataAdapter("select * from [User]", conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID= int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            FullName_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
            Email_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            Phone_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            Age_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells["Age"].Value.ToString();
            Password_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            Gender_comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
            UserRole_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells["UserRole"].Value.ToString();
            UpdateButton.Enabled = true;
            DeleteButton.Enabled = true;    

            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {   
                conn.Open();
                string sql = "UPDATE [User] SET FullName=@FullName, Email=@Email, UserRole=@UserRole, Password=@Password, Phone=@Phone, Age=@Age, Gender=@Gender WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@FullName", FullName_textbox.Text);
                cmd.Parameters.AddWithValue("@Email", Email_textbox.Text);
                cmd.Parameters.AddWithValue("@Password", Password_textbox.Text);
                cmd.Parameters.AddWithValue("@Phone", Phone_textbox.Text);
                cmd.Parameters.AddWithValue("@Age", Age_textbox.Text);
                cmd.Parameters.AddWithValue("@Gender", Gender_comboBox1.Text);
                cmd.Parameters.AddWithValue("@UserRole", UserRole_textbox.Text);
                cmd.Parameters.AddWithValue("@Id", ID);
                

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User updated successfully");
                }
                else
                {
                    MessageBox.Show("Failed");

                }

                




                conn.Close();
                display();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "Delete from [User] WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@Id", ID);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User deleted");
                }
                else
                {
                    MessageBox.Show("Failed");

                }


                conn.Close();

                display();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
