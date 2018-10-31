using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 异步通讯
{
    public partial class asynchronous : Form
    {
        public asynchronous()
        {
            InitializeComponent();
            Task1.Text = "";
            Task2.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "/Skins" + "/mp10purple.ssk";
        }

        private void StartTask_Click(object sender, EventArgs e)
        {
            int i=100;
            Task1.Text = "正在处理";
            Task2.Text = "";
            delegateTask dTask = countFirst;
            IAsyncResult result= dTask.BeginInvoke(i,null,null);
            Task2.Text = countSecond(i).ToString();
            int m =dTask.EndInvoke(result);
            Task1.Text =m.ToString();
        }
        int countFirst(int i) {
            i *= i;
            System.Threading.Thread.Sleep(5000);
            return i;
        }
        int countSecond(int i) {
            i *= i;
            return i;
        }
        public delegate int delegateTask(int i);
    }
}
