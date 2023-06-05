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
    public partial class Home : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        public Home()
        {
            InitializeComponent();

            //Check connection to database
            conn.Open();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicles vehicles = new Vehicles();
            vehicles.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vendors vendors = new Vendors();
            vendors.Show();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
        }

        private void technicianBtn_Click(object sender, EventArgs e)
        {
            Technicians technicians = new Technicians();
            technicians.Show();
        }

        private void repairBtn_Click(object sender, EventArgs e)
        {
            RepairCar repairCar = new RepairCar();
            repairCar.Show();
        }

        private void sparepartBtn_Click(object sender, EventArgs e)
        {
            SpareParts spareParts = new SpareParts();
            spareParts.Show();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            Sell sell  = new Sell();
            sell.Show();
        }
    }
}
