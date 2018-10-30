using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多窗体通讯
{
    public partial class client1 : Form
    {
        public delegate void Clientmessage(string s);
        public Clientmessage clientmessage;
        public client1()
        {
            InitializeComponent();
        }

        private void client1_Load(object sender, EventArgs e)
        {
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "/Skins" + "/EighteenColor1.ssk";
        }
        public void receiveMessage(string s) {
            this.client1Text.AppendText(s);
        }

        private void client1Btn_Click(object sender, EventArgs e)
        {
           clientmessage("客户端1："+client1_sender.Text+"\n");
           client1Text.AppendText("我:" + client1_sender.Text+"\n");
           client1_sender.Text = "";
        }
    }
}
