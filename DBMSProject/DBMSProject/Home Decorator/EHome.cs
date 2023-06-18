using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject.Home_Decorator
{
    internal class EHome : IHome
    {
        public EHome(int usertype, string name) : base(usertype, name)
        {
        }
        public override void InitializeComponent()
        {
            base.InitializeComponent();
            vehicleBtn.Hide();
            panelVehicle.Hide();
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
            
            
            customerBtn.Location = new Point(0, 103);
            panelCustomer.Location = new Point(0, 103);
            sellBtn.Location = new Point(0, 148);
            panelSell.Location = new Point(0, 148);
            
        }
    }
}
