using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public class TDashDecorator : IDashboard
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        int ID;
        public TDashDecorator(int ID) : base(ID)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDashboard));
            setgreetinglbl(ID);
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
            conn.Open();
            SqlCommand avgcmd = new SqlCommand("select sum(rd.Quantity)/count(rd.RepairID) as 'AvgPartsPerCar' from RepairDetails rd", conn);
            avgcountbl.Text = Convert.ToString(avgcmd.ExecuteScalar());
            SqlCommand spcmd = new SqlCommand("select count(*) from SpareParts", conn);
            empcountlbl.Text = Convert.ToString(spcmd.ExecuteScalar());
            SqlCommand custcmd = new SqlCommand("select count(*) from Customers", conn);
            techcountlbl.Text = Convert.ToString(custcmd.ExecuteScalar());
            SqlCommand soldcmd = new SqlCommand("select count(Status) from Vehicles where Status = 'SOLD'", conn);
            custcountlbl.Text = Convert.ToString(soldcmd.ExecuteScalar());
            SqlCommand unrepcmd = new SqlCommand("select count(Status) from Vehicles where Status != 'REPAIRED' and Status != 'SOLD'", conn);
            vendorcountlbl.Text = Convert.ToString(unrepcmd.ExecuteScalar());
            SqlCommand asscmd = new SqlCommand("select count(RepairID) from Repairs where TechnicianID = @ID", conn);
            asscmd.Parameters.AddWithValue("@ID",ID);
            soldcountlbl.Text = Convert.ToString(asscmd.ExecuteScalar());
            conn.Close();
        }
        public void setgreetinglbl(int ID)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Name from Technicians where TechnicianID = @ID and SessionStatus = 'ACTIVE'", conn);
            cmd.Parameters.AddWithValue("@ID",ID);
            string username = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
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
            
        }
        public override void InitializeComponent()
        {
            base.InitializeComponent();
        }
    }
}
