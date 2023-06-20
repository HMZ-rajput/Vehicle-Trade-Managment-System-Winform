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
        int ID;
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeft,
           int nTop,
           int nRight,
           int nBottom,
           int nWidthEllipse,
           int nHeightEllipse);
        public IDashboard(int ID)
        {
            this.ID = ID;
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
            carpaneltimer.Start();
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
        int seconds=0;
        protected virtual void carpaneltimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            if(seconds == 1)
            {
                conn.Open();
                topselllbl.Text = "Top Selling Vehicle";
                SqlCommand cmd = new SqlCommand("select max(Make+' '+Model) from Vehicles where Status = 'SOLD'",conn);
                label21.Text = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                carpaneltimer_Tick(sender,e);
            }
            if (seconds == 6)
            {
                topsellpanel.BackColor = Color.Black;
                topselllbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
                label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
                conn.Open();
                topselllbl.Text = "Most Repaired Vehicle";
                SqlCommand cmd = new SqlCommand("select max(Make+' '+Model) from Vehicles where Status = 'REPAIRED'",conn);
                label21.Text = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                carpaneltimer_Tick(sender, e);
            }
            if(seconds == 11)
            {
                topsellpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
                topselllbl.ForeColor = Color.Black;
                label21.ForeColor = Color.Black;
                conn.Open();
                topselllbl.Text = "Most Unrepaired Vehicle";
                SqlCommand cmd = new SqlCommand("select max(Make+' '+Model) from Vehicles where Status = 'NOT REPAIR'",conn);
                label21.Text = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                carpaneltimer_Tick(sender, e);    
            }
            if(seconds == 16)
            {
                seconds = 0;
                carpaneltimer_Tick(sender, e);
            }
        }
    }
}
