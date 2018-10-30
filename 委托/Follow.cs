using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 委托
{
    public partial class Follow : Form
    {
        public Follow()
        {
            InitializeComponent();
        }
        public delegate void countNum(string c);
        public countNum count;
        private int n=0;
        private void btnCount_Click(object sender, EventArgs e)
        {
            n++;
            if (count!=null)
            {
                count(n.ToString());
            }
            
        }

        private void Follow_Load(object sender, EventArgs e)
        {

        }
    }
}
