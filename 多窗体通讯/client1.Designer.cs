namespace 多窗体通讯
{
    partial class client1
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
            this.client1Btn = new System.Windows.Forms.Button();
            this.client1Text = new System.Windows.Forms.TextBox();
            this.client1_sender = new System.Windows.Forms.TextBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.SuspendLayout();
            // 
            // client1Btn
            // 
            this.client1Btn.Location = new System.Drawing.Point(337, 457);
            this.client1Btn.Name = "client1Btn";
            this.client1Btn.Size = new System.Drawing.Size(117, 35);
            this.client1Btn.TabIndex = 3;
            this.client1Btn.Text = "发送";
            this.client1Btn.UseVisualStyleBackColor = true;
            this.client1Btn.Click += new System.EventHandler(this.client1Btn_Click);
            // 
            // client1Text
            // 
            this.client1Text.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.client1Text.Location = new System.Drawing.Point(12, 23);
            this.client1Text.Multiline = true;
            this.client1Text.Name = "client1Text";
            this.client1Text.ReadOnly = true;
            this.client1Text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.client1Text.Size = new System.Drawing.Size(442, 292);
            this.client1Text.TabIndex = 2;
            this.client1Text.UseSystemPasswordChar = true;
            // 
            // client1_sender
            // 
            this.client1_sender.Location = new System.Drawing.Point(12, 350);
            this.client1_sender.Multiline = true;
            this.client1_sender.Name = "client1_sender";
            this.client1_sender.Size = new System.Drawing.Size(442, 76);
            this.client1_sender.TabIndex = 4;
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
            // client1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 514);
            this.Controls.Add(this.client1_sender);
            this.Controls.Add(this.client1Btn);
            this.Controls.Add(this.client1Text);
            this.Location = new System.Drawing.Point(1156, 200);
            this.MaximizeBox = false;
            this.Name = "client1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " 客户端1";
            this.Load += new System.EventHandler(this.client1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button client1Btn;
        private System.Windows.Forms.TextBox client1Text;
        private System.Windows.Forms.TextBox client1_sender;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}