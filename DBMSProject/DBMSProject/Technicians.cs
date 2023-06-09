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
    public partial class Technicians : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adt;
        SqlDataReader dr;
        DataTable dt;
        int n;  //random variable used int int.TryParse
        public Technicians()
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
                    cmd = new SqlCommand("addTechnician", conn);
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
                    MessageBox.Show("Unable to add Technicians\n"+ex.Message);
                    conn.Close();
                }
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

        private void deleteBtn_Click(object sender, EventArgs e)
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

        public void loadTable()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("getTechnician", conn);
                cmd.CommandType = CommandType.StoredProcedure; //added
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
    }
}
