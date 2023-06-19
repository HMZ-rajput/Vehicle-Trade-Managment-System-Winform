using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject
{
    public class AHome : IHome
    {
        public AHome(int usertype, int ID) : base(usertype, ID)
        {
        }

        public override void InitializeComponent()
        {
            base.InitializeComponent();
        }
    }
}
