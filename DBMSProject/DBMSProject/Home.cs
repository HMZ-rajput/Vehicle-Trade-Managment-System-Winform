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
        private Form activeForm;
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
            OpenChildForm(vehicles, sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelVendor.Show();
            vendorBtn.BackColor = Color.FromArgb(20, 201, 177, 40);
            Vendors vendor = new Vendors();
            OpenChildForm(vendor, sender);

        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelCustomer.Show();
            customerBtn.BackColor = Color.FromArgb(20, 201, 177, 40);
            Customers customer = new Customers();
            OpenChildForm(customer, sender);
        }
            private void technicianBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelTechnician.Show();
            technicianBtn.BackColor = Color.FromArgb(20, 201, 177, 40);
            Technicians technician = new Technicians();
            OpenChildForm(technician, sender);
        }

        private void repairBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelRepair.Show();
            repairBtn.BackColor = Color.FromArgb(20, 201, 177, 40);
            RepairCar repair = new RepairCar();
            OpenChildForm(repair, sender);
        }

        private void sparepartBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelSpareparts.Show();
            sparepartBtn.BackColor = Color.FromArgb(20, 201, 177, 40);
            SpareParts spareParts = new SpareParts(); 
            OpenChildForm(spareParts, sender);
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelReport.Show();
            reportBtn.BackColor = Color.FromArgb(20, 201, 177, 40);
            Report report = new Report();
            OpenChildForm(report, sender);
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelSell.Show();
            sellBtn.BackColor = Color.FromArgb(20, 201, 177, 40);
            Sell sell = new Sell();
            OpenChildForm(sell, sender);
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelEmployee.Show();
            employeeBtn.BackColor = Color.FromArgb(20, 201, 177, 40);
            Employee employee = new Employee();
            OpenChildForm( employee, sender);
        }

        private void techVehicleBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            PaneltechVehicle.Show();
            techVehicleBtn.BackColor = Color.FromArgb(20, 201, 177, 40);
            TechnicianVehicle techVehicle = new TechnicianVehicle();
            OpenChildForm(techVehicle, sender);
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
            hidepanels();
            Dashboard dashboard = new Dashboard();
            OpenChildForm(dashboard, sender);
        }
        private void hidepanels()
        {
            
            panelCustomer.Hide();
           customerBtn.BackColor = Color.FromArgb(32, 33, 37);
            panelEmployee.Hide();
            employeeBtn.BackColor = Color.FromArgb(32, 33, 37);
            panelRepair.Hide();
            repairBtn.BackColor = Color.FromArgb(32, 33, 37);
            panelReport.Hide();
            reportBtn.BackColor = Color.FromArgb(32, 33, 37);
            panelSell.Hide();
            sellBtn.BackColor = Color.FromArgb(32, 33, 37);
            panelSpareparts.Hide();
            sparepartBtn.BackColor = Color.FromArgb(32, 33, 37);
            panelTechnician.Hide();
            technicianBtn.BackColor = Color.FromArgb(32, 33, 37);
            panelVehicle.Hide();
            vehicleBtn.BackColor = Color.FromArgb(32, 33, 37);
            panelVendor.Hide();
            vendorBtn.BackColor = Color.FromArgb(32, 33, 37);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void Home_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            hidepanels();
            Dashboard dashboard = new Dashboard();
            OpenChildForm(dashboard, sender);
        }
    }
}
