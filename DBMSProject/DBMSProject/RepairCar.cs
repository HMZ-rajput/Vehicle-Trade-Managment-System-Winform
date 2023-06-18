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

namespace DBMSProject
{
    public partial class RepairCar : Form
    {
        int TechID = 1002;    //Temprary Technician id, it will be replaced by id of technician that login
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adt;
        SqlDataReader dr;
        DataTable dt;
        int n;
        Boolean TableLoadAllowed = false;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
         int nLeft,
         int nTop,
         int nRight,
         int nBottom,
         int nWidthEllipse,
         int nHeightEllipse);
        public RepairCar()
        {
            InitializeComponent();

            loadVehiclesCB();
            loadPartsCB();
            loadTable();
        }

        private void RepairCar_Load(object sender, EventArgs e)
        {
            addBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addBtn.Width, addBtn.Height, 5, 5));
            deleteBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, deleteBtn.Width, deleteBtn.Height, 5, 5));
            updateBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, updateBtn.Width, updateBtn.Height, 5, 5));
            completeRepairBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, completeRepairBtn.Width, completeRepairBtn.Height, 5, 5));
            quantityTB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, quantityTB.Width, quantityTB.Height, 5, 5));
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(partCB.Text!="" && vehicleCB.Text!="" && int.TryParse(quantityTB.Text, out n))
            {
                if(int.Parse(quantityTB.Text) > 0)
                {
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand("insertPartRepairDetail",conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@VehicleID", vehicleCB.SelectedValue);
                        cmd.Parameters.AddWithValue("@PartID",partCB.SelectedValue);
                        cmd.Parameters.AddWithValue("@Quantity",int.Parse(quantityTB.Text));
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        loadTable();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("Unable to add Part.\n"+ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Part quantity must be greater then 0");
                }
            }
            else
            {
                MessageBox.Show("Select a part and vehicle to insert part.\nQuantity must be valid number");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (rdIDTB.Text!="" && int.TryParse(rdIDTB.Text,out n) && quantityTB.Text!="" && int.TryParse(quantityTB.Text,out n))
            {
                if (int.Parse(quantityTB.Text)>0)
                {
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand("updateRepairDetail",conn);
                        cmd.CommandType=CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@rdID",int.Parse(rdIDTB.Text));
                        cmd.Parameters.AddWithValue("@Quantity",int.Parse(quantityTB.Text));
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("Unable to update Part.\n"+ex.Message);
                    }
                    loadTable();
                }
                else
                {
                    MessageBox.Show("Quantity must be greater then 0");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid RepairDetail ID and Quantity");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (rdIDTB.Text != "" && int.TryParse(rdIDTB.Text, out n))
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("deleteRepairDetail", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@rdID", int.Parse(rdIDTB.Text));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Unable to delete Part.\n" + ex.Message);
                }
                loadTable();
            }
            else
            {
                MessageBox.Show("Enter a valid RepairDetail ID");
            }
        }

        private void completeRepairBtn_Click(object sender, EventArgs e)
        {
            if (descTB.Text!="" && chargesTB.Text!="")
            {
                if(int.TryParse(chargesTB.Text,out n))
                {
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand("MarkVehicleRepaired",conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@VehicleID",vehicleCB.SelectedValue);
                        cmd.Parameters.AddWithValue("@Description", descTB.Text);
                        cmd.Parameters.AddWithValue("@Charges", int.Parse(chargesTB.Text));
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        loadTable();
                        loadVehiclesCB();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("Unable to mark vehicle as repaired\n"+ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Entere Valid Technician Charges");
                }
            }
            else
            {
                MessageBox.Show("Description and Technician Charges must be Entered before finishing repair.");
            }
        }

        public void loadVehiclesCB()
        {
            try
            {
                vehicleCB.DataSource = null;
                conn.Open();
                cmd = new SqlCommand("getTechnicianVehicles", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TechnicianID",TechID);
                dr = cmd.ExecuteReader();
                if (dr.Read())
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
                    MessageBox.Show("No available vehicle. Add some cars in Repairs from TechVehicle Tabs.");
                }
                TableLoadAllowed = true;
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Unable to load Vehicles ComboBox\n" + ex.Message);
            }
        }

        public void loadPartsCB()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("readSparePart", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    adt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adt.Fill(ds);
                    partCB.DataSource = ds.Tables[0];
                    partCB.DisplayMember = "PartName";
                    partCB.ValueMember = "PartID";
                }
                else
                {
                    MessageBox.Show("No available Spare Parts. Add some SpareParts from Parts Tabs.");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Unable to load SpareParts\n" + ex.Message);
            }
        }

        public void loadTable()
        {
            repairDGV.DataSource = null;
            repairDGV.DataSource = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand("getVehicleRepairDetails", conn);
                cmd.CommandType = CommandType.StoredProcedure; //added
                cmd.Parameters.AddWithValue("@VehicleID", vehicleCB.SelectedValue);
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
                    MessageBox.Show("No available data in Vehicle Repair");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Unable to load Vehicle Repair Details Table.\n" + ex.Message);
            }
        }

        private void vehicleChanged(object sender, EventArgs e)
        {
            if (TableLoadAllowed)
            {
                loadTable();
            }
        }
    }
}
