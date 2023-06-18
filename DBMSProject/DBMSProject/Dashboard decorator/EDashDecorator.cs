using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject
{
    public class EDashDecorator : IDashboard
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        string name;
        public EDashDecorator(string name)
        {
            this.name = name;
        }
        public void setgreetinglbl()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Name from Employee where SessionStatus = 'ACTIVE'",conn);
            string username = (string)cmd.ExecuteScalar();
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
            usertypelbl.Text = "Employee";
            setgreetinglbl();
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
        }
    }
}
