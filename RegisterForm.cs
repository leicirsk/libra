using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LIBRA
{
    public partial class Register_Form : Form
    {

        SqlConnection connect
            = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\adminaccounts.mdf;Integrated Security=True;Connect Timeout=30");

        public Register_Form()
        {
            InitializeComponent();
        }

        private void signin_loginBtn_Click(object sender, EventArgs e)
        {
           LoginForm lform = new LoginForm();
            lform.ShowDialog();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showPassword.Checked ? '\0' : '*';
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (signup_username.Text == "" || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        //TO CHECK IF THE USER IS EXISTING ALREADY
                        string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";

                        using (SqlCommand checkCMD = new SqlCommand(selectUsername, connect))
                        {
                            checkCMD.Parameters.AddWithValue("@user", signup_username.Text.Trim());

                            int count = (int)checkCMD.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(signup_username.Text.Trim() + "Username already exists"
                   , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            { //To get the date today
                                DateTime day = DateTime.Today;
                                //For inserting new users
                                string insertData = "INSERT INTO users" +
                                    "(username, password)" +
                                    "VALUES(@username, @password, @date)";

                                using (SqlCommand insertCMD = new SqlCommand(insertData, connect)) //Pass the connection
                                {
                                    insertCMD.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@date", day.ToString());

                                    insertCMD.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully!",
                                        "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //Navigate to log in form
                                    LoginForm loginForm = new LoginForm();
                                    loginForm.Show();
                                    this.Hide();
                                }

                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex
                  , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}
