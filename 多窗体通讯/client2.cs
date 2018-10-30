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
    public partial class client2 : Form
    {
        public delegate void Clientmessage(string s);
        public Clientmessage clientmessage;
        public client2()
        {
            InitializeComponent();
        }

        private void client2_Load(object sender, EventArgs e)
        {
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "/Skins" + "/EighteenColor2.ssk";
        }
        public void receiveMessage(string s)
        {
            this.client2Text.AppendText(s);
        }

        private void client2Btn_Click(object sender, EventArgs e)
        {
            clientmessage("客户端2：" + client2_sender.Text + "\n");
            client2Text.AppendText("我:" + client2_sender.Text + "\n");
            client2_sender.Text = "";
        }
    }
}
