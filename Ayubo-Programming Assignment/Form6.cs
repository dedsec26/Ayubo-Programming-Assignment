using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ayubo_Programming_Assignment
{
    public partial class Form6 : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=Aflal-PC;Initial Catalog=ayubodrive;Integrated Security=True");
        //SqlConnection sqlConnection1 = new SqlConnection("Data Source=Aflal-PC;Initial Catalog=ayubodrive;Integrated Security=True");
        public Form6()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string user;
                int check;

                if (string.IsNullOrEmpty(txtPass.Text) | string.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Please enter valid username and password");
                }
                else 
                {
                    string sql_login = "select count(*) as num from users where username = '" + txtUsername.Text + "'  and pass = '" + txtPass.Text + "' ";
                    //string sql_pass = "select username from users where pass = '" + txtPass.Text + "'";
                    SqlCommand command = new SqlCommand(sql_login,sqlConnection);
                   // SqlCommand command1 = new SqlCommand(sql_pass,sqlConnection1);
                    sqlConnection.Open();
                    //sqlConnection1.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    dataReader.Read();
                    // SqlDataReader dataReader1 = command1.ExecuteReader();
                    user = dataReader["num"].ToString();
                    check = Int32.Parse(user);
                    //pass = dataReader1["pass"].ToString();
                    if (check == 1)
                    {
                        MessageBox.Show("Login Successful");
                        sqlConnection.Close();
                        //sqlConnection1.Close();
                        

                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                        sqlConnection.Close();
                        //sqlConnection1.Close();
                    }
                    

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                sqlConnection.Close();
                //sqlConnection1.Close();
            }
        }
    }
}
