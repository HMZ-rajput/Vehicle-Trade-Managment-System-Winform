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
            hidepanels();
            //Check connection to database
            conn.Open();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelVehicle.Show();
            vehicleBtn.BackColor = Color.FromArgb(20, 201, 177, 40);
            Vehicles vehicles = new Vehicles();
            vehicles.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelVendor.Show();
            vendorBtn.BackColor = Color.FromArgb(20, 201, 177, 40);
            Vendors vendors = new Vendors();
            vendors.Show();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelCustomer.Show();
            customerBtn.BackColor = Color.FromArgb(20, 201, 177, 40);
            Customers customers = new Customers();
            customers.Show();
        }

        private void technicianBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelTechnician.Show();
            technicianBtn.BackColor = Color.FromArgb(20, 201, 177, 40);
            Technicians technicians = new Technicians();
            technicians.Show();
        }

        private void repairBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelRepair.Show();
            repairBtn.BackColor = Color.FromArgb(20, 201, 177, 40);
            RepairCar repairCar = new RepairCar();
            repairCar.Show();
        }

        private void sparepartBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelSpareparts.Show();
            sparepartBtn.BackColor = Color.FromArgb(20, 201, 177, 40);
            SpareParts spareParts = new SpareParts();
            spareParts.Show();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelReport.Show();
            reportBtn.BackColor = Color.FromArgb(20, 201, 177, 40);
            Report report = new Report();
            report.Show();
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelSell.Show();
            sellBtn.BackColor = Color.FromArgb(20, 201, 177, 40);
            Sell sell  = new Sell();
            sell.Show();
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelEmployee.Show();
            employeeBtn.BackColor = Color.FromArgb(20, 201, 177, 40);
            Employee employee = new Employee();
            employee.Show();
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void hidepanels()
        {
            
            panelCustomer.Hide();
           customerBtn.BackColor = Color.FromArgb(64, 64, 64);
            panelEmployee.Hide();
            employeeBtn.BackColor = Color.FromArgb(64, 64, 64);
            panelRepair.Hide();
            repairBtn.BackColor = Color.FromArgb(64, 64, 64);
            panelReport.Hide();
            reportBtn.BackColor = Color.FromArgb(64, 64, 64);
            panelSell.Hide();
            sellBtn.BackColor = Color.FromArgb(64,64,64);
            panelSpareparts.Hide();
            sparepartBtn.BackColor = Color.FromArgb(64, 64, 64);
            panelTechnician.Hide();
            technicianBtn.BackColor = Color.FromArgb(64, 64, 64);
            panelVehicle.Hide();
            vehicleBtn.BackColor = Color.FromArgb(64, 64, 64);
            panelVendor.Hide();
            vendorBtn.BackColor = Color.FromArgb(64, 64, 64);
        }
    }
}
