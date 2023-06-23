using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public class LoginSingleton
    {
        public string Username { get; set; }
        public string Category { get; set; }
        // Private constructor to prevent direct instantiation
        private LoginSingleton()
        {
             
        }
        private static LoginSingleton instance;
        public static LoginSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new LoginSingleton();
            }
            else
            {
                MessageBox.Show("Instance Already created","Dialog", MessageBoxButtons.OK);
            }
            return instance;
        }
        public static void  DestroyInstance()
        {
            instance = null;
        }
    }
}
