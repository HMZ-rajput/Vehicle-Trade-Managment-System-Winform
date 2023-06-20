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
    public partial class SystemLog : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=VehicleTrade;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        public SystemLog()
        {
            InitializeComponent();
            getSessionLog();
            getTablesAudit();
        }
        private void getSessionLog()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("getSessionLog", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.systemlogDGV.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UNABLE TO FETCH DATA" + ex);
                conn.Close();
            }
        }
        private void getTablesAudit()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("getTablesAudit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.AuditDGV.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UNABLE TO FETCH DATA" + ex);
                conn.Close();
            }
        }
    }
}
