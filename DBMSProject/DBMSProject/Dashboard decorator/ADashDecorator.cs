using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
       
    }
}
