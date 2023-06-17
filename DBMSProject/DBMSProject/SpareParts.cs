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
        int n;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeft,
           int nTop,
           int nRight,
           int nBottom,
           int nWidthEllipse,
           int nHeightEllipse);
        private void SpareParts_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
            getSparePartsRecord();
            addBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addBtn.Width, addBtn.Height, 5, 5));
            deleteBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, deleteBtn.Width, deleteBtn.Height, 5, 5));
            updateBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, updateBtn.Width, updateBtn.Height, 5, 5));
            idtxt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, idtxt.Width, idtxt.Height, 5, 5));
            desctxt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, desctxt.Width, desctxt.Height, 5, 5));
            nametxt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, nametxt.Width, nametxt.Height, 5, 5));
            costtxt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, costtxt.Width, costtxt.Height, 5, 5));
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
                costtxt.Text!="" && desctxt.Text != "Enter Part Cost" && int.TryParse(costtxt.Text,out n))
            {
                cmd.Parameters.AddWithValue("@partName", nametxt.Text);
                cmd.Parameters.AddWithValue("@partDescription", desctxt.Text);
                cmd.Parameters.AddWithValue("@partCost", int.Parse(costtxt.Text));
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
            if (idtxt.Text!="" && int.TryParse(idtxt.Text,out n))
            {
                try
                {
                    con.Open();
                    if (nametxt.Text != "")
                    {
                        cmd = new SqlCommand("updateSparePartsName", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PartID", int.Parse(idtxt.Text));
                        cmd.Parameters.AddWithValue("@PartName", nametxt.Text);
                        cmd.ExecuteNonQuery();
                    }
                    if (desctxt.Text!="")
                    {
                        cmd = new SqlCommand("updateSparePartsDesc", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PartID", int.Parse(idtxt.Text));
                        cmd.Parameters.AddWithValue("@Description", desctxt.Text);
                        cmd.ExecuteNonQuery();
                    }
                    if (costtxt.Text!="" && int.TryParse(costtxt.Text, out n))
                    {
                        cmd = new SqlCommand("updateSparePartsCost", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PartID", int.Parse(idtxt.Text));
                        cmd.Parameters.AddWithValue("@Cost", int.Parse(costtxt.Text));
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }catch(Exception ex)
                {
                    con.Close();
                    MessageBox.Show("Unable to update part\n"+ex.Message);
                }
                getSparePartsRecord();
            }
            else
            {
                MessageBox.Show("ID must be valid and numeric to update part");
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
