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
    public partial class IHome : Form
    {
        private Form activeForm;
        int usertype;
        string name;
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        public IHome(int usertype, string name)
        {
            this.usertype = usertype;
            this.name = name;
            InitializeComponent();
            hidepanels();
            panelLeft.BackColor = Color.Black;
            //Check connection to database
            conn.Open();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelVehicle.Show();
            vehicleBtn.BackColor = Color.FromArgb(44, 44, 37);
            Vehicles vehicles = new Vehicles();
            OpenChildForm(vehicles, sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelVendor.Show();
            vendorBtn.BackColor = Color.FromArgb(44, 44, 37);
            Vendors vendor = new Vendors();
            OpenChildForm(vendor, sender);

        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelCustomer.Show();
            customerBtn.BackColor = Color.FromArgb(44, 44, 37);
            Customers customer = new Customers();
            OpenChildForm(customer, sender);
        }
            private void technicianBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelTechnician.Show();
            technicianBtn.BackColor = Color.FromArgb(44, 44, 37);
            Technicians technician = new Technicians();
            OpenChildForm(technician, sender);
        }

        private void repairBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelRepair.Show();
            repairBtn.BackColor = Color.FromArgb(44, 44, 37);
            RepairCar repair = new RepairCar();
            OpenChildForm(repair, sender);
        }

        private void sparepartBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelSpareparts.Show();
            sparepartBtn.BackColor = Color.FromArgb(44, 44, 37);
            SpareParts spareParts = new SpareParts(); 
            OpenChildForm(spareParts, sender);
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelReport.Show();
            reportBtn.BackColor = Color.FromArgb(44, 44, 37);
            Report report = new Report();
            OpenChildForm(report, sender);
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelSell.Show();
            sellBtn.BackColor = Color.FromArgb(44, 44, 37);
            Sell sell = new Sell();
            OpenChildForm(sell, sender);
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelEmployee.Show();
            employeeBtn.BackColor = Color.FromArgb(44, 44, 37);
            Employee employee = new Employee();
            OpenChildForm( employee, sender);
        }

        private void techVehicleBtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            PaneltechVehicle.Show();
            techVehicleBtn.BackColor = Color.FromArgb(44, 44, 37);
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
            if (usertype == 1)
            {
                ADashDecorator dashboard = new ADashDecorator(name);
                OpenChildForm(dashboard, sender);
            }
            else if(usertype == 2)
            {
                EDashDecorator dashboard = new EDashDecorator(name);
                OpenChildForm(dashboard, sender);
            }
            else if (usertype == 3)
            {
                TDashDecorator dashboard = new TDashDecorator(name);
                OpenChildForm(dashboard, sender);
            }
        }
        protected void hidepanels()
        {
            
            panelCustomer.Hide();
            customerBtn.BackColor = Color.Black;
            panelEmployee.Hide();
            employeeBtn.BackColor = Color.Black;
            panelRepair.Hide();
            repairBtn.BackColor = Color.Black;
            panelReport.Hide();
            reportBtn.BackColor = Color.Black;
            panelSell.Hide();
            sellBtn.BackColor = Color.Black;
            panelSpareparts.Hide();
            sparepartBtn.BackColor = Color.Black;
            panelTechnician.Hide();
            technicianBtn.BackColor = Color.Black;
            panelVehicle.Hide();
            vehicleBtn.BackColor = Color.Black;
            panelVendor.Hide();
            vendorBtn.BackColor = Color.Black;
            techVehicleBtn.BackColor = Color.Black;
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
            if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.WindowsShutDown || e.CloseReason == CloseReason.TaskManagerClosing || e.CloseReason == CloseReason.None)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "BlazeWheel", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    if (usertype == 1)
                    {
                        SqlCommand cmd = new SqlCommand("update Admin set SessionStatus = 'INACTIVE' where SessionStatus = 'ACTIVE'", conn);
                        cmd.ExecuteNonQuery();
                    }
                    else if (usertype == 2)
                    {
                        SqlCommand cmd = new SqlCommand("update Employee set SessionStatus = 'INACTIVE' where SessionStatus = 'ACTIVE'", conn);
                        cmd.ExecuteNonQuery();
                    }
                    else if (usertype == 3)
                    {
                        SqlCommand cmd = new SqlCommand("update Technicians set SessionStatus = 'INACTIVE' where SessionStatus = 'ACTIVE'", conn);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
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
            hidepanels();
            if (usertype == 1)
            {
                ADashDecorator dashboard = new ADashDecorator(name);
                OpenChildForm(dashboard, sender);
            }
            else if (usertype == 2)
            {
                EDashDecorator dashboard = new EDashDecorator(name);
                OpenChildForm(dashboard, sender);
            }
            else if (usertype == 3)
            {
                TDashDecorator dashboard = new TDashDecorator(name);
                OpenChildForm(dashboard, sender);
            }
        }

        private void Signoutbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (usertype == 1)
            {
                SqlCommand cmd = new SqlCommand("update Admin set SessionStatus = 'INACTIVE' where SessionStatus = 'ACTIVE'",conn);
                cmd.ExecuteNonQuery();
                signout();
            }
            else if (usertype == 2)
            {
                SqlCommand cmd = new SqlCommand("update Employee set SessionStatus = 'INACTIVE' where SessionStatus = 'ACTIVE'",conn);
                cmd.ExecuteNonQuery();
                signout();
            }
            else if (usertype == 3)
            {
                SqlCommand cmd = new SqlCommand("update Technicians set SessionStatus = 'INACTIVE' where SessionStatus = 'ACTIVE'",conn);
                cmd.ExecuteNonQuery();
                signout();
            }
            
        }
        private void signout()
        {

            LoginSingleton.DestroyInstance();
            conn.Close();
            this.Hide();
            new Login().Show();
        }

        private void userlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
