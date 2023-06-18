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
    public partial class Technicians : Form
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
        public Technicians()
        {
            InitializeComponent();

            loadTable();
        }

        public void loadTable()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("getTechnician", conn);
                cmd.CommandType = CommandType.StoredProcedure; //added
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    adt = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adt.Fill(dt);
                    technicianDGV.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No data found in Technician\nInsert some data");
                    dt = new DataTable();
                    technicianDGV.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load Technician\n" + ex.Message);
                conn.Close();
            }
        }

        private void Technicians_Load(object sender, EventArgs e)
        {
            addBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addBtn.Width, addBtn.Height, 5, 5));
            deleteBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, deleteBtn.Width, deleteBtn.Height, 5, 5));
            updateBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, updateBtn.Width, updateBtn.Height, 5, 5));
            idTB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, idTB.Width, idTB.Height, 5, 5));
            nameTB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, nameTB.Width, nameTB.Height, 5, 5));
            addressTB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addressTB.Width, addressTB.Height, 5, 5));
            phoneTB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, phoneTB.Width, phoneTB.Height, 5, 5));
        }
        public void EncryptPass(ref string password)
        {
            var sha = SHA256.Create();
            var ByteArr = Encoding.Default.GetBytes(password);
            var encryptPass = sha.ComputeHash(ByteArr);

            password = Convert.ToBase64String(encryptPass);
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            if (idTB.Text != "" && int.TryParse(idTB.Text, out n))
            {
                try
                {
                    conn.Open();
                    if (nameTB.Text != "")
                    {
                        cmd = new SqlCommand("updateTechnicianName", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TechnicianID", int.Parse(idTB.Text));
                        cmd.Parameters.AddWithValue("@Name", nameTB.Text);
                        cmd.ExecuteNonQuery();
                    }
                    if (addressTB.Text != "")
                    {
                        cmd = new SqlCommand("updateTechnicianAddress", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TechnicianID", int.Parse(idTB.Text));
                        cmd.Parameters.AddWithValue("@Address", addressTB.Text);
                        cmd.ExecuteNonQuery();
                    }
                    if (phoneTB.Text != "")
                    {
                        cmd = new SqlCommand("updateTechnicianPhone", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TechnicianID", int.Parse(idTB.Text));
                        cmd.Parameters.AddWithValue("@Phone", phoneTB.Text);
                        cmd.ExecuteNonQuery();
                    }
                    if (passTB.Text != "")
                    {
                        cmd = new SqlCommand("updateTechnicianPassword", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TechnicianID", int.Parse(idTB.Text));
                        cmd.Parameters.AddWithValue("@Password", passTB.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update Technicians\n" + ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Unable to update Technician\nId must be numberic and valid");
            }
            conn.Close();
            loadTable();
        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (idTB.Text != "" && int.TryParse(idTB.Text, out n))
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("delTechnician", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("TechnicianID", idTB.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    loadTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete Technician\n" + ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Technician id must be numeric");
            }
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            if (nameTB.Text != "" && addressTB.Text != "" && phoneTB.Text != "")
            {
                try
                {
                    string password = passTB.Text;
                    EncryptPass(ref password);

                    conn.Open();
                    cmd = new SqlCommand("addTechnician", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", nameTB.Text);
                    cmd.Parameters.AddWithValue("@Phone", phoneTB.Text);
                    cmd.Parameters.AddWithValue("@Address", addressTB.Text);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    loadTable();//refresh table after succesfully adding data
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to add Technicians\n" + ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter all details except ID");
            }
        }
    }
}
