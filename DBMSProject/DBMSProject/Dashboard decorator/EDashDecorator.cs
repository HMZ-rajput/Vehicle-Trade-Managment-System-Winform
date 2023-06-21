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
    public class EDashDecorator : IDashboard
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        public EDashDecorator(int ID) : base(ID)
        {
            label21.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label21.Location = new System.Drawing.Point(4, 26);
            setgreetinglbl(ID);
            Losslbl.Text = "Your Sales Today";
            losspanel.BackColor = System.Drawing.Color.Black;
            Losslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
            avgpartlbl.Text = "Top Selling Car";
            avgcountbl.Text = "Toyota";
            avgcountbl.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            SqlCommand cmd9 = new SqlCommand("select coalesce(Commission,0) from Sale where EmployeeID = @ID", conn);
            SqlCommand cmd8 = new SqlCommand("select coalesce(Commission,0) from Sale where EmployeeID = @ID", conn);
            SqlCommand cmd7 = new SqlCommand("select coalesce(Commission,0) from Sale where EmployeeID = @ID", conn);
            cmd9.Parameters.AddWithValue("@ID", ID);
            cmd8.Parameters.AddWithValue("@ID", ID);
            cmd7.Parameters.AddWithValue("@ID", ID);
            label19.Text = "$"+Convert.ToString(cmd9.ExecuteScalar());
            label21.Text = "$" + Convert.ToString(cmd8.ExecuteScalar());
            label21.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            profitamt.Text = "$" + Convert.ToString(cmd7.ExecuteScalar());
            avgcountbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            avgcountbl.Location = new System.Drawing.Point(8, 34);
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
        int seconds = 0;
        protected override void carpaneltimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == 1)
            {
                conn.Open();
                avgpartlbl.Text = "Top Selling Vehicle";
                SqlCommand cmd = new SqlCommand("select max(Make+' '+Model) from Vehicles where Status = 'SOLD'", conn);
                avgcountbl.Text = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                carpaneltimer_Tick(sender, e);
            }
            if (seconds == 6)
            {
                partspanel.BackColor = Color.Black;
                avgcountbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
                avgpartlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
                conn.Open();
                avgpartlbl.Text = "Most Repaired Vehicle";
                SqlCommand cmd = new SqlCommand("select max(Make+' '+Model) from Vehicles where Status = 'REPAIRED'", conn);
                avgcountbl.Text = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                carpaneltimer_Tick(sender, e);
            }
            if (seconds == 11)
            {
                partspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(4)))));
                avgpartlbl.ForeColor = Color.Black;
                avgcountbl.ForeColor = Color.Black;
                conn.Open();
                avgpartlbl.Text = "Most Unrepaired Vehicle";
                SqlCommand cmd = new SqlCommand("select max(Make+' '+Model) from Vehicles where Status = 'NOT REPAIR'", conn);
                avgcountbl.Text = Convert.ToString(cmd.ExecuteScalar());
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
