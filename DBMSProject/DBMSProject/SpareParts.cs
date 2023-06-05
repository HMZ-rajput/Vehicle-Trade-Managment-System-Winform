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
    public partial class SpareParts : Form
    {
        public SpareParts()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;

        private void SpareParts_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
            getSparePartsRecord();
        }
        private void getSparePartsRecord()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("readSparePart", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("UNABLE TO FETCH DATA"+ex);
                con.Close();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("addSparePart", con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            if (nametxt.Text != "" && nametxt.Text != "Enter Part Name" && 
                desctxt.Text != "" && desctxt.Text != "Enter Part Description" &&
                costtxt.Text!="" && desctxt.Text != "Enter Part Cost")
            {
                cmd.Parameters.AddWithValue("@partName", nametxt.Text);
                cmd.Parameters.AddWithValue("@partDescription", desctxt.Text);
                cmd.Parameters.AddWithValue("@partCost", costtxt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("SPARE PART ADDED SUCCESSFULLY");
            }
            else
                MessageBox.Show("ERROR: SPARE PART CAN'T BE ADDED");
            con.Close();
            getSparePartsRecord();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("updateSparePart", con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (idtxt.Text != "" && idtxt.Text != "Enter Part ID" &&
                    nametxt.Text != "" && nametxt.Text != "Enter Part Name")
                {
                    cmd.Parameters.AddWithValue("@partID", int.Parse(idtxt.Text));
                    cmd.Parameters.AddWithValue("@partName", nametxt.Text);
                    cmd.ExecuteNonQuery();
                }
                if (idtxt.Text != "" && idtxt.Text != "Enter Part ID" &&
                    desctxt.Text != "" && desctxt.Text != "Enter Part Description")
                {
                    cmd.Parameters.AddWithValue("@partID", int.Parse(idtxt.Text));
                    cmd.Parameters.AddWithValue("@partDecription", desctxt.Text);
                    cmd.ExecuteNonQuery();
                }
                if (idtxt.Text != "" && idtxt.Text != "Enter Part ID" &&
                    costtxt.Text != "" && desctxt.Text != "Enter Part Cost")
                {
                    cmd.Parameters.AddWithValue("@partID", int.Parse(idtxt.Text));
                    cmd.Parameters.AddWithValue("@partCost", int.Parse(costtxt.Text));
                    cmd.ExecuteNonQuery();
                }
                else
                    MessageBox.Show("ERROR: SPARE PART CAN'T BE UPDATED");
                con.Close();
                MessageBox.Show("SPARE PART UPDATED SUCCESSFULLY");
                getSparePartsRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ID MUST BE AN INTEGER VALUE or COST MUST BE INTEGER VALUE");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("deleteSparePart", con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (idtxt.Text != "" && idtxt.Text != "Enter Part ID")
                {
                    cmd.Parameters.AddWithValue("@partID", int.Parse(idtxt.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("SPARE PART DELETED SUCCESSFULLY");
                }
                else
                    MessageBox.Show("ERROR: SPARE PART CAN'T BE DELETED");
                con.Close();
                getSparePartsRecord();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ID MUST BE AN INTEGER VALUE");
            }
        }
    }
}
