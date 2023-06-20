using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject
{
    public class AHome : IHome
    {
        public AHome(int usertype, int ID) : base(usertype, ID)
        {
        }

        public override void InitializeComponent()
        {
            base.InitializeComponent();
            repairBtn.Hide();
            panelRepair.Hide();
            sellBtn.Hide();
            panelSell.Hide();
            technicianBtn.Hide();
            panelTechnician.Hide();
            PaneltechVehicle.Hide();
            techVehicleBtn.Hide();
            
            //sparepartBtn.Location = new Point(0, 402);
            //panelSpareparts.Location = new Point(0, 402);
            //reportBtn.Location = new Point(0, 371);
            //panelReport.Location = new Point(0, 371);
            //systemlogbtn.Location = new Point(0, 348);
            //panelsystemlog.Location = new Point(0, 348);
        }
    }
}
