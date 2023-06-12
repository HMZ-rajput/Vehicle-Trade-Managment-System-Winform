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
    public partial class Vehicles : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adt;
        SqlDataReader dr;
        DataTable dt;
        int n;
        public Vehicles()
        {
            InitializeComponent();

            loadTable();
            loadComboBox();
            
        }

        //Add Button Click
        private void button1_Click(object sender, EventArgs e)
        {
            if (makeTB.Text != "" && makeTB.Text != "Enter Make" && modelTB.Text != "" && modelTB.Text != "Enter Model" && mileageTB.Text != "" && mileageTB.Text != "Enter Mileage" && yearTB.Text != "" && yearTB.Text != "Enter Year" && priceTB.Text != "" && priceTB.Text != "Enter Price" && int.TryParse(priceTB.Text, out n) && int.TryParse(yearTB.Text, out n) && int.TryParse(mileageTB.Text, out n))
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("addVehicle", conn);
                    cmd.CommandType = CommandType.StoredProcedure; //added
                    cmd.Parameters.AddWithValue("@Make", makeTB.Text);
                    cmd.Parameters.AddWithValue("@Model", modelTB.Text);
                    cmd.Parameters.AddWithValue("@Year", yearTB.Text);
                    cmd.Parameters.AddWithValue("@Mileage", mileageTB.Text);
                    cmd.Parameters.AddWithValue("@VendorID", vendorCB.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Cost", priceTB.Text);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Car succesfully added");
                    loadTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to add car\n" + ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter all details except 'CarID' to add a Car!\nYear and Mileage must be numeric");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (idTB.Text != "" && int.TryParse(idTB.Text, out n))
            {
                try
                {
                    conn.Open();
                    if(makeTB.Text != "" && makeTB.Text !="Enter Make")
                    {
                        cmd = new SqlCommand("updateVehicleMake", conn);
                        cmd.CommandType=CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@VehicleID", int.Parse(idTB.Text));
                        cmd.Parameters.AddWithValue("@Make", makeTB.Text);
                        cmd.ExecuteNonQuery();
                    }
                    if (modelTB.Text != "" && modelTB.Text != "Enter Model")
                    {
                        cmd = new SqlCommand("updateVehicleModel", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@VehicleID", int.Parse(idTB.Text));
                        cmd.Parameters.AddWithValue("@Model", modelTB.Text);
                        cmd.ExecuteNonQuery();
                    }
                    if (mileageTB.Text != "" && mileageTB.Text != "Enter Mileage")
                    {
                        if(int.TryParse(mileageTB.Text, out n))
                        {
                            cmd = new SqlCommand("updateVehicleMileage", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@VehicleID", int.Parse(idTB.Text));
                            cmd.Parameters.AddWithValue("@Mileage", mileageTB.Text);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Mileage must be numeric");
                        }
                    }
                    if (yearTB.Text != "" && yearTB.Text != "Enter Year")
                    {
                        if(int.TryParse(yearTB.Text, out n))
                        {
                            cmd = new SqlCommand("updateVehicleYear", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@VehicleID", int.Parse(idTB.Text));
                            cmd.Parameters.AddWithValue("@Year", yearTB.Text);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Year must be numeric");
                        }
                    }
                    if (priceTB.Text != "" && priceTB.Text != "Enter Price")
                    {
                        if(int.TryParse(priceTB.Text, out n))
                        {
                            cmd = new SqlCommand("updateVehicleCost", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@VehicleID", int.Parse(idTB.Text));
                            cmd.Parameters.AddWithValue("@Cost", priceTB.Text);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Price must be numberic");
                        }
                    }
                    cmd = new SqlCommand("updateVehicleVendor", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VehicleID", int.Parse(idTB.Text));
                    cmd.Parameters.AddWithValue("@VendorID", vendorCB.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update Vehicle\n"+ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Unable to update Vehicle\nId must be numberic and valid");
            }
            conn.Close();
            loadTable();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (idTB.Text != "" && idTB.Text != "Enter Car ID" && int.TryParse(idTB.Text, out n))
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("delVehicle", conn);
                    cmd.CommandType = CommandType.StoredProcedure; //added
                    cmd.Parameters.AddWithValue("@VehicleID", int.Parse(idTB.Text));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    loadTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete Vehicle\n" + ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter valid numeric vehicle id to delete car");
            }
        }

        public void loadTable()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("getVehicle", conn);
                cmd.CommandType = CommandType.StoredProcedure; //added
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    adt = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adt.Fill(dt);
                    vehicleDGV.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Unable to read data from Vehicles");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to fetch Vehicles data\n" + ex.Message);
                conn.Close();
            }
        }

        public void loadComboBox()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("getVendors", conn);
                cmd.CommandType = CommandType.StoredProcedure; //added
                adt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adt.Fill(ds);
                cmd.ExecuteNonQuery();
                vendorCB.DataSource = ds.Tables[0];
                vendorCB.DisplayMember = "Name";
                vendorCB.ValueMember = "VendorID";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load Vendors\n" + ex.Message);
                conn.Close();
            }
        }

        private void vehicleDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
