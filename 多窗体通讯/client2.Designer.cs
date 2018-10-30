namespace 多窗体通讯
{
    partial class client2
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
            this.client2Btn = new System.Windows.Forms.Button();
            this.client2Text = new System.Windows.Forms.TextBox();
            this.client2_sender = new System.Windows.Forms.TextBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.SuspendLayout();
            // 
            // client2Btn
            // 
            this.client2Btn.Location = new System.Drawing.Point(326, 452);
            this.client2Btn.Name = "client2Btn";
            this.client2Btn.Size = new System.Drawing.Size(117, 35);
            this.client2Btn.TabIndex = 3;
            this.client2Btn.Text = "发送";
            this.client2Btn.UseVisualStyleBackColor = true;
            this.client2Btn.Click += new System.EventHandler(this.client2Btn_Click);
            // 
            // client2Text
            // 
            this.client2Text.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.client2Text.Location = new System.Drawing.Point(12, 23);
            this.client2Text.Multiline = true;
            this.client2Text.Name = "client2Text";
            this.client2Text.ReadOnly = true;
            this.client2Text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.client2Text.Size = new System.Drawing.Size(442, 292);
            this.client2Text.TabIndex = 2;
            // 
            // client2_sender
            // 
            this.client2_sender.Location = new System.Drawing.Point(12, 350);
            this.client2_sender.Multiline = true;
            this.client2_sender.Name = "client2_sender";
            this.client2_sender.Size = new System.Drawing.Size(442, 76);
            this.client2_sender.TabIndex = 4;
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
            // client2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 514);
            this.Controls.Add(this.client2_sender);
            this.Controls.Add(this.client2Btn);
            this.Controls.Add(this.client2Text);
            this.Location = new System.Drawing.Point(678, 200);
            this.MaximizeBox = false;
            this.Name = "client2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "客户端2";
            this.Load += new System.EventHandler(this.client2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button client2Btn;
        private System.Windows.Forms.TextBox client2Text;
        private System.Windows.Forms.TextBox client2_sender;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}