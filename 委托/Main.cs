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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Follow f = new Follow();
            f.count+= ShowNum;
            f.Show();
        }
       
        private void Main_Load(object sender, EventArgs e)
        {
          
        }
        private void ShowNum(string c)
        {
            this.num.Text = c;
        }
        


    }
}
