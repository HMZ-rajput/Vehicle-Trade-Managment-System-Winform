﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBMSProject
{
    public partial class TechnicianVehicle : Form
    {
        int TechID = 1002;    //Temprary Technician id, it will be replaced by id of technician that login
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adt;
        SqlDataReader dr;
        DataTable dt;
        int n;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse);
        public TechnicianVehicle()
        {
            InitializeComponent();

            loadTable();
            loadComboBox();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (vehicleCB.Text!="")
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("startVehicleRepair", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TechnicianID",TechID);
                    cmd.Parameters.AddWithValue("@VehicleID",vehicleCB.SelectedValue);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    loadTable();
                    loadComboBox();
                }catch(Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Unable to add Vehicle\n"+ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No Vehicle Selected");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if(idTB.Text!="" && int.TryParse(idTB.Text,out n))
            {
                try
                {
                    conn.Open();

                    conn.Close();
                }catch(Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Unable to remove vehicle");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid numeric vehicle id");
            }
        }

        public void loadTable()
        {
            // Load Repairs
            try
            {
                conn.Open();
                cmd = new SqlCommand("getRepair", conn);
                cmd.CommandType = CommandType.StoredProcedure; //added
                cmd.Parameters.AddWithValue("@TechnicianID",TechID);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    adt = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adt.Fill(dt);
                    repairDGV.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No data in Past Repairs\nRepair Some Vehicles for data");
                    dt = new DataTable();
                    repairDGV.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to fetch Repairs data\n" + ex.Message);
                conn.Close();
            }
            //Load Repair Details
            try
            {
                conn.Open();
                cmd = new SqlCommand("getRepairDetails", conn);
                cmd.CommandType = CommandType.StoredProcedure; //added
                cmd.Parameters.AddWithValue("@TechnicianID", TechID);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    adt = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adt.Fill(dt);
                    repairdetailDGV.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No data in Past Vehicles Repaird\nComplete some repairs for data");
                    dt = new DataTable();
                    repairdetailDGV.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to fetch Repair Details data\n" + ex.Message);
                conn.Close();
            }
        }

        public void loadComboBox()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("getAvailaleVehicles", conn);
                cmd.CommandType = CommandType.StoredProcedure; //added
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    dr.Close();
                    adt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adt.Fill(ds);
                    vehicleCB.DataSource = ds.Tables[0];
                    vehicleCB.DisplayMember = "Model";   //Check for combining make and model
                    vehicleCB.ValueMember = "VehicleID";
                }
                else
                {
                    MessageBox.Show("No available vehicle");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load Vehicles\n" + ex.Message);
                conn.Close();
            }
        }

        private void TechnicianVehicle_Load(object sender, EventArgs e)
        {

        }
    }
}