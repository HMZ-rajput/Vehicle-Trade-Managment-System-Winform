using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject
{
    public class EDashDecorator : IDashboard
    {
        string name;
        public EDashDecorator(string name)
        {
            this.name = name;
        }
        public void setgreetinglbl()
        {
            if (DateTime.Now.Hour < 12)
            {
                greetinglbl.Text = "Good morning";
            }
            else if (DateTime.Now.Hour < 18)
            {
                greetinglbl.Text = "Good afternoon";
            }
            else
            {
                greetinglbl.Text = "Good evening";
            }
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
