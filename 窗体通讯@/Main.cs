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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
        }
        private void Main_Load(object sender, EventArgs e)
        {
            O1 o1 = new O1();
            O2 o2 = new O2();
            O3 o3 = new O3();
            s += o1.shows;
            s += o2.shows;
            s += o3.shows;
            o1.Show();
            o2.Show();
            o3.Show();
        }
        public delegate void showCount(string c);
        showCount s;

        private void btnme_Click(object sender, EventArgs e)
        {
            if (s != null)
            {
                s(Count().ToString());
            }
        }
        private int i=0;
        int Count()
        {
            return i++;
        }
    }
}
