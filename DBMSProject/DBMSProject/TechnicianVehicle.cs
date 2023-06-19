using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBMSProject
{
    public partial class TechnicianVehicle : Form
    {
            //Temprary Technician id, it will be replaced by id of technician that login
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adt;
        SqlDataReader dr;
        DataTable dt;
        int n;
        int ID;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse);
        public TechnicianVehicle(int ID)
        {
            InitializeComponent();
            this.ID = ID;

            loadTable();
            loadComboBox();
            //MessageBox.Show(""+TechID);
;        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (vehicleCB.Text!="")
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("startVehicleRepair", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TechnicianID",ID);
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
            loadTable();
            loadComboBox();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            
            if (idTB.Text!="" && int.TryParse(idTB.Text,out n))
            {
                DialogResult dialogResult = MessageBox.Show("Warning, If you remove a vehicle then all the repairs done to it will also be removed.\nAre you sure you want to remove vehicle?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand("VehicleRepairUpdate", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TechnicianID", ID);
                        cmd.Parameters.AddWithValue("@VehicleID", int.Parse(idTB.Text));
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        loadTable();
                        loadComboBox();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("Unable to remove vehicle"+ex);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                } 
            }
            else
            {
                MessageBox.Show("Enter a valid numeric vehicle id");
            }
            loadTable();
            loadComboBox();
        }

        public void loadTable()
        {
            repairdetailDGV.DataSource = null;
            repairDGV.DataSource=null;
            // Load Repairs
            try
            {
                conn.Open();
                cmd = new SqlCommand("getRepair", conn);
                cmd.CommandType = CommandType.StoredProcedure; //added
                cmd.Parameters.AddWithValue("@TechnicianID",ID);
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
                cmd.Parameters.AddWithValue("@TechnicianID", ID);
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
            vehicleCB.DataSource = null;
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
            addBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addBtn.Width, addBtn.Height, 5, 5));
            updateBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, updateBtn.Width, updateBtn.Height, 5, 5));
            idTB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, idTB.Width, idTB.Height, 5, 5));
        }
    }
}
