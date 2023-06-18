﻿using System;
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
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("select Name from Admin where Name = 'Admin'",conn);
            ////cmd.Parameters.AddWithValue("@Name",username);
            //string Username = (string)cmd.ExecuteScalar();
            //conn.Close();
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
            usertypelbl.Text = "Administrator";
            setGreetinglbl();
        }
       
    }
}
