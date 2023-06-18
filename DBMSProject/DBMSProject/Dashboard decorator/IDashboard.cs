using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DBMSProject
{
    public partial class IDashboard : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeft,
           int nTop,
           int nRight,
           int nBottom,
           int nWidthEllipse,
           int nHeightEllipse);
        public IDashboard()
        {
            
            InitializeComponent();
            //Application.VisualStyleState = VisualStyleState.NoneEnabled;
            BuyPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BuyPanel.Width, BuyPanel.Height, 5, 5));
            RepairPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, RepairPanel.Width, RepairPanel.Height, 5, 5));
            SoldPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SoldPanel.Width, SoldPanel.Height, 5, 5));
            vendorpanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, vendorpanel.Width, vendorpanel.Height, 5, 5));
            custpanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, custpanel.Width, custpanel.Height, 5, 5));
            emppanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, emppanel.Width, emppanel.Height, 5, 5));
            techpanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, techpanel.Width, techpanel.Height, 5, 5));
            partspanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, partspanel.Width, partspanel.Height, 5, 5));
            losspanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, losspanel.Width, losspanel.Height, 5, 5));
            profitpanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, profitpanel.Width, profitpanel.Height, 5, 5));
            topsellpanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, topsellpanel.Width, topsellpanel.Height, 5, 5));
            label7.Text = DateTime.Now.ToString("dddd, dd MMMM");
            timer1.Start();
            conn.Open();
            SqlCommand veh = new SqlCommand("select count(*) from Vehicles",conn);
            boughtlbl.Text = Convert.ToString(veh.ExecuteScalar());
            SqlCommand ven = new SqlCommand("select count(Status) from Vehicles where Status = 'REPAIRED'", conn);
            repaircountlbl.Text = Convert.ToString(ven.ExecuteScalar());
            conn.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToString("hh:mm tt");
        }
    }
}
