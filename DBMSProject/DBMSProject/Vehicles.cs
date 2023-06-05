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
        }

        //Add Button Click
        private void button1_Click(object sender, EventArgs e)
        {
            if(makeTB.Text!="" && makeTB.Text!="Enter Make" && modelTB.Text != "" && modelTB.Text != "Enter Model" && mileageTB.Text != "" && mileageTB.Text != "Enter Mileage" && yearTB.Text != "" && yearTB.Text != "Enter Year" && int.TryParse(yearTB.Text,out n) && int.TryParse(mileageTB.Text,out n))
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("addVehicle",conn);
                    cmd.CommandType = CommandType.StoredProcedure; //added
                    cmd.Parameters.AddWithValue("@Make",makeTB.Text);
                    cmd.Parameters.AddWithValue("@Model",modelTB.Text);
                    cmd.Parameters.AddWithValue("@Year",yearTB.Text);
                    cmd.Parameters.AddWithValue("@Mileage",mileageTB.Text);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Car succesfully added");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Unable to add car\n"+ex.Message);
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

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(idTB.Text!="" && idTB.Text!= "Enter Car ID" && int.TryParse(idTB.Text,out n))
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("delVehicle",conn);
                    cmd.CommandType = CommandType.StoredProcedure; //added
                    cmd.Parameters.AddWithValue("@VehicleID", int.Parse(idTB.Text));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show("Unable to delete Vehicle");
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
                cmd = new SqlCommand("getVehicle",conn);
                cmd.CommandType = CommandType.StoredProcedure; //added
                dr = cmd.ExecuteReader();
                if(dr.Read())
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
            }catch(Exception ex)
            {
                MessageBox.Show("Unable to fetch Vehicles data");
                conn.Close();
            }
        }
    }
}
