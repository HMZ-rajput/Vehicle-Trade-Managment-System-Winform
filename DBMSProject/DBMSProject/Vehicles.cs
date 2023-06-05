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
        }

        //Add Button Click
        private void button1_Click(object sender, EventArgs e)
        {
            if(makeTB.Text!="" && makeTB.Text!="Enter Make" && modelTB.Text != "" && modelTB.Text != "Enter Model" && mileageTB.Text != "" && mileageTB.Text != "Enter Mileage" && yearTB.Text != "" && yearTB.Text != "Enter Year" && int.TryParse(yearTB.Text,out n) && int.TryParse(mileageTB.Text,out n))
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("",conn);
                    cmd.Parameters.AddWithValue("@",makeTB.Text);
                    cmd.Parameters.AddWithValue("@",modelTB.Text);
                    cmd.Parameters.AddWithValue("@",int.Parse(yearTB.Text));
                    cmd.Parameters.AddWithValue("@",int.Parse(mileageTB.Text));
                    cmd.Parameters.AddWithValue("@","UNREPAIRED");
                    cmd.Parameters.AddWithValue("@",DateTime.Now());
                    conn.Close();
                    MessageBox.Show("Car succesfully added");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Unable to add car\n"+ex.Message);
                    conn.Close();
                    throw;
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

        }
    }
}
