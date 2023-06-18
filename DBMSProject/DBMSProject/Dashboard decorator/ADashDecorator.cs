using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject
{
    public class ADashDecorator : IDashboard
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        string username;
        public ADashDecorator(string name)
        {
            username = name;
        }
        public void setGreetinglbl()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Name from Admin where SessionStatus = 'ACTIVE'", conn);
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
            setGreetinglbl();
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
            conn.Close();
        }
       
    }
}
