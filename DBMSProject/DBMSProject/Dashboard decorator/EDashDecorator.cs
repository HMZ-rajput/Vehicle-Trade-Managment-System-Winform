using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public class EDashDecorator : IDashboard
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        public EDashDecorator(int ID) : base(ID)
        {
            setgreetinglbl(ID);
            Losslbl.Text = "Your Sales Today";
            losspanel.BackColor = System.Drawing.Color.Black;
            Losslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            avgpartlbl.Text = "Top Selling Car";
            label11.Text = "Toyota";
            label11.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pictureBox5.Hide();
            topselllbl.Text = "Your Sales This Month";
            label21.Text = "$34,000";
            profitlbl.Text = "Total Sales";
            profitpanel.BackColor = System.Drawing.Color.Black;
            profitlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            profitamt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
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
        public void setgreetinglbl(int ID)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Name from Employee where EmployeeID = @ID and SessionStatus = 'ACTIVE'", conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            string username = Convert.ToString(cmd.ExecuteScalar());
            if (DateTime.Now.Hour < 12)
            {
                greetinglbl.Text = "Good morning, "+username;
            }
            else if (DateTime.Now.Hour < 18)
            {
                greetinglbl.Text = "Good afternoon, "+username;
            }
            else
            {
                greetinglbl.Text = "Good evening, "+username;
            }
            conn.Close();
        }
        public override void InitializeComponent()
        {
            base.InitializeComponent();
            
        }
    }
}
