

using System.Data.SqlClient;

namespace DBMS_ProjectV1._0
{
    public partial class Form1 : Form
    {
        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=Testdb;Integrated Security=True");
            conn.Open();
            conn.Close();
        }
    }
}