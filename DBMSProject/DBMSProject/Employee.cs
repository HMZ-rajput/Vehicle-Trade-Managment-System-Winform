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
        public Employee()
        {
            InitializeComponent();

            loadTable();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameTB.Text != "" && addressTB.Text != "" && phoneTB.Text != "" && commisionTB.Text != "" && int.TryParse(commisionTB.Text, out n))
            {
                if (int.Parse(commisionTB.Text) > 0 && int.Parse(commisionTB.Text) < 100)
                {
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand("addEmployee", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", nameTB.Text);
                        cmd.Parameters.AddWithValue("@Phone", phoneTB.Text);
                        cmd.Parameters.AddWithValue("Address", addressTB.Text);
                        cmd.Parameters.AddWithValue("CommisionPercentage", int.Parse(commisionTB.Text));
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
    }
}
