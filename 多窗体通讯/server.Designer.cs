namespace 多窗体通讯
{
    partial class server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serverText = new System.Windows.Forms.TextBox();
            this.serverbtn = new System.Windows.Forms.Button();
            this.server_sender = new System.Windows.Forms.TextBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.SuspendLayout();
            // 
            // serverText
            // 
            this.serverText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.serverText.Location = new System.Drawing.Point(12, 23);
            this.serverText.Multiline = true;
            this.serverText.Name = "serverText";
            this.serverText.ReadOnly = true;
            this.serverText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.serverText.Size = new System.Drawing.Size(442, 292);
            this.serverText.TabIndex = 0;
            // 
            // serverbtn
            // 
            this.serverbtn.Location = new System.Drawing.Point(337, 457);
            this.serverbtn.Name = "serverbtn";
            this.serverbtn.Size = new System.Drawing.Size(117, 35);
            this.serverbtn.TabIndex = 1;
            this.serverbtn.Text = "发送";
            this.serverbtn.UseVisualStyleBackColor = true;
            this.serverbtn.Click += new System.EventHandler(this.serverbtn_Click);
            // 
            // server_sender
            // 
            this.server_sender.Location = new System.Drawing.Point(12, 350);
            this.server_sender.Multiline = true;
            this.server_sender.Name = "server_sender";
            this.server_sender.Size = new System.Drawing.Size(442, 76);
            this.server_sender.TabIndex = 2;
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 514);
            this.Controls.Add(this.server_sender);
            this.Controls.Add(this.serverbtn);
            this.Controls.Add(this.serverText);
            this.Location = new System.Drawing.Point(200, 200);
            this.MaximizeBox = false;
            this.Name = "server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "服务端";
            this.Load += new System.EventHandler(this.server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverText;
        private System.Windows.Forms.Button serverbtn;
        private System.Windows.Forms.TextBox server_sender;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}