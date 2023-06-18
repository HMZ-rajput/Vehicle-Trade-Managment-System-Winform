using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void RepairCar_Load(object sender, EventArgs e)
        {
            addBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addBtn.Width, addBtn.Height, 5, 5));
            deleteBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, deleteBtn.Width, deleteBtn.Height, 5, 5));
            updateBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, updateBtn.Width, updateBtn.Height, 5, 5));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 5, 5));
            quantityTB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, quantityTB.Width, quantityTB.Height, 5, 5));
        }
    }
}
