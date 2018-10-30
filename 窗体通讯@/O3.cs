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
    public partial class O3 : Form
    {
        public O3()
        {
            InitializeComponent();
        }

        private void O3_Load(object sender, EventArgs e)
        {

        }
        public void shows(string c)
        {
            this.L3.Text = c;
        }
        public delegate void showCount(string c);

    }
}
