using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_KiwoomLoginControl
{
    public partial class KHCtrl : UserControl
    {
        public KHCtrl()
        {
            InitializeComponent();
        }

        public void Login()
        {
            axKHOpenAPI.CommConnect();
        }
    }
}
