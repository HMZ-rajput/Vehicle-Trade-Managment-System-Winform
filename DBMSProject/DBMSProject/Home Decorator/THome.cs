﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject
{
    public class THome : IHome
    {
        public THome(int usertype, int ID) : base(usertype, ID)
        {
            vehicleBtn.Hide();
            panelVehicle.Hide();
            vendorBtn.Hide();
            panelVendor.Hide();
            employeeBtn.Hide();
            panelEmployee.Hide();
            technicianBtn.Hide();
            panelTechnician.Hide();
            customerBtn.Hide();
            panelCustomer.Hide();
            reportBtn.Hide();
            panelReport.Hide();
            sellBtn.Hide();
            panelSell.Hide();
            userlbl.Text = "Technician";
            repairBtn.Location = new Point(0, 103);
            panelRepair.Location = new Point(0, 103);
            sparepartBtn.Location = new Point(0, 148);
            panelSpareparts.Location = new Point(0, 148);
            techVehicleBtn.Location = new Point(0, 193);
            PaneltechVehicle.Location = new Point(0, 193);
        }
        public override void InitializeComponent()
        {
            base.InitializeComponent();
        }
    }
}
