using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public partial class Sell : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adt;
        SqlDataReader dr;
        DataTable dt;
        int n, ID;
        Boolean LabelLoadAllowed = false;
        public Sell(int ID)
        {
            InitializeComponent();

            this.ID = ID;
            loadTable();
            loadCustomerCB();
            loadVehicleCB();
            loadCommissionPercLabel();
            //MessageBox.Show(ID+"");
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(priceTB.Text,out n) && vehicleCB.SelectedValue!=null && customerCB.SelectedValue!=null)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("sellCar",conn);
                    cmd.CommandType=CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VehicleID",int.Parse(vehicleCB.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@CustomerID", int.Parse(customerCB.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@EmployeeID", ID);
                    cmd.Parameters.AddWithValue("@SalePrice",int.Parse(priceTB.Text));
                    cmd.Parameters.AddWithValue("@Commission",int.Parse(commissionLB.Text));
                    cmd.Parameters.AddWithValue("@profit", int.Parse(priceTB.Text)-int.Parse(totalLB.Text)-int.Parse(commissionLB.Text));
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    loadVehicleCB();
                    loadTable();
                }catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Unable to Sell car\n"+ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter a valid value for Sell Price\nMake sure that a vehicle and customer have been selected");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(sellidTB.Text, out n) && sellidTB.Text != "")
            {
                try
                {
                    conn.Open();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter a valid Sell ID");
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(sellidTB.Text,out n) && sellidTB.Text!="")
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("deleteSale",conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SaleID", int.Parse(sellidTB.Text));
                    cmd.Parameters.AddWithValue("@EmployeeID", ID);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    loadTable() ;
                    loadVehicleCB() ;
                }catch(Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Unable to Remove Sell\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter a valid Sell ID");
            }
        }

        public void loadTable()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("getEmplyeeSells",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID",ID);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    adt = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adt.Fill(dt);
                    sellDGV.DataSource = dt;
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("No Sell Record\nThere is No sell done by you");
                }
                conn.Close();
            }catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Unable to load Sell\n"+ex.Message);
            }
        }

        public void loadVehicleCB()
        {
            try
            {
                LabelLoadAllowed = false;
                conn.Open();
                cmd = new SqlCommand("readRepairedCar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    adt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adt.Fill(ds);
                    vehicleCB.DataSource = ds.Tables[0];
                    vehicleCB.DisplayMember = "Model";
                    vehicleCB.ValueMember = "VehicleID";

                    conn.Close();
                    LabelLoadAllowed = true;
                    loadLabel();
                }
                else
                {
                    MessageBox.Show("Out of Stock!\nNo vehicle available for sell.");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Unable to load Vehicles\n" + ex.Message);
            }
        }

        public void loadCustomerCB()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("readCustomers", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    adt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adt.Fill(ds);
                    customerCB.DataSource = ds.Tables[0];
                    customerCB.DisplayMember = "Name";
                    customerCB.ValueMember = "CustomerID";
                }
                else
                {
                    MessageBox.Show("No record found of Customers\nAsk admin to Add some Customers from Customer tabs");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Unable to load Customers\n" + ex.Message);
            }
        }

        public void loadLabel()
        {
            if (LabelLoadAllowed)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("getVehicleCost",conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VehicleID",vehicleCB.SelectedValue);
                    costLB.Text = cmd.ExecuteScalar().ToString();

                    cmd = new SqlCommand("getVehicleRepairCost", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VehicleID", vehicleCB.SelectedValue);
                    repairCostLB.Text = cmd.ExecuteScalar().ToString();

                    totalLB.Text = (int.Parse(costLB.Text)+int.Parse(repairCostLB.Text)).ToString();
                    conn.Close();
                }catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Unable to load Labels\n"+ex.Message);
                }
            }
        }

        public void loadCommissionPercLabel()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("getEmployeeComPerc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID", ID);
                commissionPercLB.Text = cmd.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Unable to load Commisssion Percentae Label\n" + ex.Message);
            }
        }

        private void price_Changed(object sender, EventArgs e)
        {
            if (int.TryParse(priceTB.Text, out n))
            {
                if ((int.Parse(priceTB.Text)-int.Parse(totalLB.Text))>0)
                {
                    //commisison = (sell price - total cost) * comission%
                    commissionLB.Text = ((double)(int.Parse(priceTB.Text)-int.Parse(totalLB.Text)) * ((double)int.Parse(commissionPercLB.Text) / 100)).ToString();
                }
                else
                {
                    commissionLB.Text = "0";
                }
            }
            else
            {
                commissionLB.Text = "0";
            }
        }

        private void vehicleCB_Change(object sender, EventArgs e)
        {
            if (LabelLoadAllowed)
            {
                loadLabel();
                commissionLB.Text = "0";
            }
        }
    }
}
