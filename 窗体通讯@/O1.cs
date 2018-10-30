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
    public partial class O1 : Form
    {
        public O1()
        {
            InitializeComponent();
        }

        private void O1_Load(object sender, EventArgs e)
        {

        }
        public void shows(string c)
        {
            this.L1.Text = c;
        }
    }
}
