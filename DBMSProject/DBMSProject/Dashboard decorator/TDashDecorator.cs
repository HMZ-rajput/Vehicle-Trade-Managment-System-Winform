using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject
{
    public class TDashDecorator : IDashboard
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        string name;
        public TDashDecorator(string name)
        {
            this.name = name;
        }
        public void setgreetinglbl()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Name from Technicians where SessionStatus = 'ACTIVE'", conn);
            string username = (string)cmd.ExecuteScalar();
            if (DateTime.Now.Hour < 12)
            {
                greetinglbl.Text = "Good morning, " + username;
            }
            else if (DateTime.Now.Hour < 18)
            {
                greetinglbl.Text = "Good afternoon, " + username;
            }
            else
            {
                greetinglbl.Text = "Good evening, " + username;
            }
            conn.Close();
        }
        public override void InitializeComponent()
        {
            base.InitializeComponent();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDashboard));
            setgreetinglbl();
            vendorlbl.Text = "Unrepaired";
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            Losslbl.Text = "Your Profit Today";
            losspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            profitlbl.Text = "Your Profit This Month";
            profitpanel.BackColor = System.Drawing.Color.Black;
            profitlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            profitamt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            soldlbl.Text = "Vehicles Assigned";
            techlbl.Text = "Customers";
            custlbl.Text = "Sold";
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            custlbl.ForeColor = System.Drawing.Color.Black;
            custcountlbl.ForeColor = System.Drawing.Color.Black;
            custpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            techpanel.BackColor = System.Drawing.Color.Black;
            techlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            techcountlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            emplbl.ForeColor = System.Drawing.Color.Black;
            emplbl.Text = "Spare Parts";
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            emppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            emplbl.ForeColor = System.Drawing.Color.Black;
            empcountlbl.ForeColor = System.Drawing.Color.Black;
            topselllbl.Text = "Most Repaired Vehicle";
        }
    }
}
