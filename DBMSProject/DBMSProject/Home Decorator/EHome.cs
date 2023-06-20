using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject
{
    public class EHome : IHome
    {
        public EHome(int usertype, int ID) : base(usertype, ID)
        {
            vendorBtn.Hide();
            panelVendor.Hide();
            employeeBtn.Hide();
            panelEmployee.Hide();
            technicianBtn.Hide();
            panelTechnician.Hide();
            repairBtn.Hide();
            panelRepair.Hide();
            reportBtn.Hide();
            panelReport.Hide();
            sparepartBtn.Hide();
            panelSpareparts.Hide();
            techVehicleBtn.Hide();
            PaneltechVehicle.Hide();
            systemlogbtn.Hide();
            panelsystemlog.Hide();

            userlbl.Text = "Employee";
            vehicleBtn.Location = new Point(0, 103);
            panelVehicle.Location = new Point(0, 103);
            customerBtn.Location = new Point(0, 148);
            panelCustomer.Location = new Point(0, 148);
            sellBtn.Location = new Point(0, 193);
            panelSell.Location = new Point(0, 193);
        }
        public override void InitializeComponent()
        {
            base.InitializeComponent();
            
        }
    }
}
