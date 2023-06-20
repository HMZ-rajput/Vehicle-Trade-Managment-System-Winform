using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public class ADashDecorator : IDashboard
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        public ADashDecorator(int ID) : base(ID)
        {
            setGreetinglbl(ID);
            conn.Open();
            SqlCommand soldcmd = new SqlCommand("select count(Status) from Vehicles where Status = 'SOLD'", conn);
            soldcountlbl.Text = Convert.ToString(soldcmd.ExecuteScalar());
            SqlCommand vencmd = new SqlCommand("select count(*) from Vendors", conn);
            SqlCommand custcmd = new SqlCommand("select count(*) from Customers", conn);
            SqlCommand empcmd = new SqlCommand("select count(*) from Employee", conn);
            SqlCommand techcmd = new SqlCommand("select count(*) from Technicians", conn);
            vendorcountlbl.Text = Convert.ToString(vencmd.ExecuteScalar());
            custcountlbl.Text = Convert.ToString(custcmd.ExecuteScalar());
            empcountlbl.Text = Convert.ToString(empcmd.ExecuteScalar());
            techcountlbl.Text = Convert.ToString(techcmd.ExecuteScalar());
            SqlCommand avgcmd = new SqlCommand("select sum(rd.Quantity)/count(rd.RepairID) as 'AvgPartsPerCar' from RepairDetails rd", conn);
            avgcountbl.Text = Convert.ToString(avgcmd.ExecuteScalar());
            SqlCommand profitcmd = new SqlCommand("select coalesce(sum(profit),0) from Sale",conn);
            int profit = Convert.ToInt32(profitcmd.ExecuteScalar());
            profitamt.Text = "$"+Convert.ToString(profit);
            if (profit <= 0)
            {
                profitlbl.Text = "Total Loss";
                profitpanel.BackColor = System.Drawing.Color.Firebrick;
                
            }
            else
            {
                profitlbl.Text = "Total Profit";
                profitpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            }
            carpaneltimer.Start();
            
            conn.Close();
        }
        public void setGreetinglbl(int ID)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Name from Admin where AdminID = @ID and SessionStatus = 'ACTIVE'", conn);
            cmd.Parameters.AddWithValue("@ID", ID);
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
        int seconds=0;
        protected override void carpaneltimer_Tick(object sender, EventArgs e)
        {
            base.carpaneltimer_Tick(sender,e);
            seconds++;
            if (seconds == 1)
            {
                conn.Open();
                Losslbl.Text = "Total Cost Price";
                SqlCommand cmd = new SqlCommand("select sum(Cost) from Vehicles", conn);
                label19.Text = "$"+Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                carpaneltimer_Tick(sender, e);
            }
            if (seconds == 6)
            {
                conn.Open();
                Losslbl.Text = "Total Repair Cost";
                SqlCommand cmd = new SqlCommand("select sum(RepairCost) from Repairs", conn);
                label19.Text = "$"+Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                carpaneltimer_Tick(sender, e);
            }
            if (seconds == 11)
            {
                conn.Open();
                Losslbl.Text = "Total Selling Price";
                SqlCommand cmd = new SqlCommand("select sum(SalePrice) from Sale", conn);
                label19.Text = "$"+Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                carpaneltimer_Tick(sender, e);
            }
            if (seconds == 16)
            {
                seconds = 0;
                carpaneltimer_Tick(sender, e);
            }
        }
    }
}
