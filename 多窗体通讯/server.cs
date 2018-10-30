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
    public partial class server : Form
    {
        public delegate void Message(string s);
        Message message;
      
        public server()
        {
            InitializeComponent();
            client1 client = new client1();
            client2 client22 = new client2();
            client.clientmessage = showClientMessage;
            client22.clientmessage = showClientMessage;
            message += client.receiveMessage;
            message += client22.receiveMessage;
            client.Show();
            client22.Show();
        }
        public void showClientMessage(string s)
        {
            serverText.AppendText(s);
        }
        private void server_Load(object sender, EventArgs e)
        {
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "/Skins" + "/Longhorn.ssk";
        }
        private void serverbtn_Click(object sender, EventArgs e)
        {
            if (message != null)
            {
                message("服务端消息："+server_sender.Text+"\r\n");
            }
            showClientMessage("我："+server_sender.Text+"\n");
            server_sender.Text = "";
        }
        
    }
}
