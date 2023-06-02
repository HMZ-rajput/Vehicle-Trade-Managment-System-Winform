using System.Data.SqlClient;

namespace DBMS_ProjectV1._0
{
    public partial class Form1 : Form
    {
        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            conn.Open();
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source = ZAIN; Initial Catalog = bukc; Integrated Security = True");

        }
    }
}