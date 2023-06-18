using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSProject.Home_Decorator
{
    internal class AHome : IHome
    {
        public AHome(int usertype, string name) : base(usertype, name)
        {
        }

        public override void InitializeComponent()
        {
            base.InitializeComponent();
        }
    }
}
