using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public partial class Customers : Form
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
        public Customers()
        {
            InitializeComponent();

            loadTable();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameTB.Text != "" && addressTB.Text != "" && phoneTB.Text != "")
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("addCustomers", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", nameTB.Text);
                    cmd.Parameters.AddWithValue("@Phone", phoneTB.Text);
                    cmd.Parameters.AddWithValue("Address", addressTB.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    loadTable();//refresh table after succesfully adding data
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to add Customers\n" + ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter all details except ID");
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
                        cmd = new SqlCommand("updateCustomerName", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CustomerID", int.Parse(idTB.Text));
                        cmd.Parameters.AddWithValue("@Name", nameTB.Text);
                        cmd.ExecuteNonQuery();
                    }
                    if (addressTB.Text != "")
                    {
                        cmd = new SqlCommand("updateCustomerAddress", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CustomerID", int.Parse(idTB.Text));
                        cmd.Parameters.AddWithValue("@Address", addressTB.Text);
                        cmd.ExecuteNonQuery();
                    }
                    if (phoneTB.Text != "")
                    {
                        cmd = new SqlCommand("updateCustomerPhone", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CustomerID", int.Parse(idTB.Text));
                        cmd.Parameters.AddWithValue("@Phone", phoneTB.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update Customers\n" + ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Unable to update Customers\nId must be numberic and valid");
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
                    cmd = new SqlCommand("delCustomer", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("CustomerID", idTB.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    loadTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete Customer\n" + ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Customer id must be numeric");
            }
        }

        public void loadTable()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("getCustomers", conn);
                cmd.CommandType = CommandType.StoredProcedure; //added
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    adt = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adt.Fill(dt);
                    vendorDGV.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No data in Customers\nInsert some data");
                    dt = new DataTable();
                    vendorDGV.DataSource = null; ;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load Customers\n" + ex.Message);
                conn.Close();
            }
        }

        private void vendorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            addBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addBtn.Width, addBtn.Height, 5, 5));
            deleteBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, deleteBtn.Width, deleteBtn.Height, 5, 5));
            updateBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, updateBtn.Width, updateBtn.Height, 5, 5));
            idTB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, idTB.Width, idTB.Height, 5, 5));
            nameTB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, nameTB.Width, nameTB.Height, 5, 5));
            addressTB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addressTB.Width, addressTB.Height, 5, 5));
            phoneTB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, phoneTB.Width, phoneTB.Height, 5, 5));
        }
    }
}
