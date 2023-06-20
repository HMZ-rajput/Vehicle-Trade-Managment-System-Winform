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
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace DBMSProject
{
    public partial class Employee : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adt;
        SqlDataReader dr;
        DataTable dt;
        int n;  //random variable used int int.TryParse
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeft,
           int nTop,
           int nRight,
           int nBottom,
           int nWidthEllipse,
           int nHeightEllipse);
        public Employee()
        {
            InitializeComponent();

            loadTable();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameTB.Text != "" && addressTB.Text != "" && phoneTB.Text != "" && commisionTB.Text != "" && int.TryParse(commisionTB.Text, out n) && passTB.Text != "")
            {
                if (int.Parse(commisionTB.Text) > 0 && int.Parse(commisionTB.Text) < 100)
                {
                    try
                    {   
                        conn.Open();
                        string password = passTB.Text;
                        EncryptPass(ref password);
                        cmd = new SqlCommand("addEmployee", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", nameTB.Text);
                        cmd.Parameters.AddWithValue("@Phone", phoneTB.Text);
                        cmd.Parameters.AddWithValue("@Address", addressTB.Text);
                        cmd.Parameters.AddWithValue("@CommisionPercentage", int.Parse(commisionTB.Text));
                        cmd.Parameters.AddWithValue("@Password",password);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        loadTable();//refresh table after succesfully adding data
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to add Employees\n" + ex.Message);
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Commission Percentage must be between 0-100");
                }
            }
            else
            {
                MessageBox.Show("Enter all details except ID\nCommision must be numeric");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (idTB.Text != "" && int.TryParse(idTB.Text, out n))
            {
                try
                {
                    conn.Open();
                    if (nameTB.Text != "")
                    {
                        cmd = new SqlCommand("updateEmployeeName", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmployeeID", int.Parse(idTB.Text));
                        cmd.Parameters.AddWithValue("@Name", nameTB.Text);
                        cmd.ExecuteNonQuery();
                    }
                    if (addressTB.Text != "")
                    {
                        cmd = new SqlCommand("updateEmployeeAddress", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmployeeID", int.Parse(idTB.Text));
                        cmd.Parameters.AddWithValue("@Address", addressTB.Text);
                        cmd.ExecuteNonQuery();
                    }
                    if (phoneTB.Text != "")
                    {
                        cmd = new SqlCommand("updateEmployeePhone", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmployeeID", int.Parse(idTB.Text));
                        cmd.Parameters.AddWithValue("@Phone", phoneTB.Text);
                        cmd.ExecuteNonQuery();
                    }
                    if(commisionTB.Text != "" && int.TryParse(commisionTB.Text,out n))
                    {
                        if(int.Parse(commisionTB.Text) > 0 && int.Parse(commisionTB.Text) < 100)
                        {
                            cmd = new SqlCommand("updateEmployeeCommission", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@EmployeeID", int.Parse(idTB.Text));
                            cmd.Parameters.AddWithValue("CommisionPercentage", int.Parse(commisionTB.Text));
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Commision must be between 0-100");
                        }
                    }
                    if (passTB.Text != "")
                    {
                        cmd = new SqlCommand("updateEmployeePassword", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmployeeID", int.Parse(idTB.Text));
                        cmd.Parameters.AddWithValue("@Password", passTB.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update Employees\n" + ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Unable to update Employees\nId must be numberic and valid");
            }
            conn.Close();
            loadTable();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (idTB.Text != "" && int.TryParse(idTB.Text, out n))
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("delEmployee", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("EmployeeID", idTB.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    loadTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete Employee\n" + ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Employee id must be numeric");
            }
        }

        public void loadTable()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("getEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure; //added
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    adt = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adt.Fill(dt);
                    employeeDGV.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No data in Employees\nInsert some data");
                    dt = new DataTable();
                    employeeDGV.DataSource = null; ;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load Employees\n" + ex.Message);
                conn.Close();
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            addBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addBtn.Width, addBtn.Height, 5, 5));
            deleteBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, deleteBtn.Width, deleteBtn.Height, 5, 5));
            updateBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, updateBtn.Width, updateBtn.Height, 5, 5));
            idTB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, updateBtn.Width, updateBtn.Height, 5, 5));
            addressTB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, updateBtn.Width, updateBtn.Height, 5, 5));
            commisionTB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, updateBtn.Width, updateBtn.Height, 5, 5));
            nameTB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, updateBtn.Width, updateBtn.Height, 5, 5));
            passTB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, updateBtn.Width, updateBtn.Height, 5, 5));
            phoneTB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, updateBtn.Width, updateBtn.Height, 5, 5));
        }
        public void EncryptPass(ref string password)
        {
            var sha = SHA256.Create();
            var ByteArr = Encoding.Default.GetBytes(password);
            var encryptPass = sha.ComputeHash(ByteArr);

            password = Convert.ToBase64String(encryptPass);
        }
    }
}
