using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse);
        public Login()
        {

            InitializeComponent();
            loginpanel.BackColor = Color.FromArgb(200, loginpanel.BackColor);
            loginpanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, loginpanel.Width, loginpanel.Height, 5, 5));
            loginBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, loginBtn.Width, loginBtn.Height, 5, 5));
            clearBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, clearBtn.Width, clearBtn.Height, 5, 5));
            optionCB.SelectedIndex = 0;
            
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        
        private void showpassCB_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassCB.Checked)
            {
                passwordTB.PasswordChar = '\0';
            }
            else
            {
                passwordTB.PasswordChar = '•';
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            IdTB.Text = "";
            passwordTB.Text = "";
            optionCB.Text = "";
            IdTB.Focus();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (IdTB.Text == "" | passwordTB.Text == "" | optionCB.Text == "")
            {
                MessageBox.Show("All Fields must be filles", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string password = passwordTB.Text;
                EncryptPass(ref password);

                // Login process
                //SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Documents\\University\\BSE 3B\\DSA Data Structure and Algorithme\\Project\\DSA_Project v.0.7\\DSA_Project\\DSA_Project_DB.mdf\";Integrated Security=True");
                conn.Open();

                if (optionCB.Text == "Administrator")
                {
                    SqlCommand cmd = new SqlCommand("Select Count(*) From Admin Where Name = @Name and Password = @Password", conn);
                    cmd.Parameters.AddWithValue("@Name", IdTB.Text);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int UserExist = (int)cmd.ExecuteScalar();
                    string name = IdTB.Text;
                    if (UserExist > 0)
                    {
                        // Note!
                        //Also send Id to next form to get correct records
                        LoginSingleton form1 = LoginSingleton.GetInstance();
                        form1.Username = IdTB.Text;
                        form1.Category = optionCB.Text;
                        conn.Close();
                        new IHome(1, name).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                    }
                }
                if (optionCB.Text == "Employee")
                {
                    SqlCommand cmd = new SqlCommand("Select Count(*) From Customers Where Name = @Name and Password = @Password", conn);
                    cmd.Parameters.AddWithValue("@Name", IdTB.Text);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int UserExist = (int)cmd.ExecuteScalar();
                    string name = IdTB.Text;
                    if (UserExist > 0)
                    {
                        LoginSingleton form1 = LoginSingleton.GetInstance();
                        form1.Username = IdTB.Text;
                        form1.Category = optionCB.Text;
                        // Note!
                        //Also send Id to next form to get correct records
                        conn.Close();
                        new IHome(2, name).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                    }
                }
                else if (optionCB.Text == "Technician")
                {
                    SqlCommand cmd = new SqlCommand("Select Count(*) From Technicians Where Name = @Name and Password = @Password", conn);
                    cmd.Parameters.AddWithValue("@Name", IdTB.Text);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int UserExist = (int)cmd.ExecuteScalar();
                    string name = IdTB.Text;
                    if (UserExist > 0)
                    {
                        // Note!
                        //Also send Id to next form to get correct records
                        LoginSingleton form1 = LoginSingleton.GetInstance();
                        form1.Username = IdTB.Text;
                        form1.Category = optionCB.Text;
                        conn.Close();
                        new IHome(3, name).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                    }
                }
            }
        }
        public void EncryptPass(ref string password)
        {
            var sha = SHA256.Create();
            var ByteArr = Encoding.Default.GetBytes(password);
            var encryptPass = sha.ComputeHash(ByteArr);

            password = Convert.ToBase64String(encryptPass);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "BlazeWheel", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
