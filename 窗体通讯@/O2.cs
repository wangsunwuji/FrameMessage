using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体通讯_
{
    public partial class O2 : Form
    {
        public O2()
        {
            InitializeComponent();
        }

        private void O2_Load(object sender, EventArgs e)
        {

        }
        public void shows(string c)
        {
            this.L2.Text = c;
        }
    }
}
