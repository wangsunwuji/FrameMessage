namespace 窗体通讯_
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnme = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnme
            // 
            this.btnme.Location = new System.Drawing.Point(122, 93);
            this.btnme.Name = "btnme";
            this.btnme.Size = new System.Drawing.Size(176, 79);
            this.btnme.TabIndex = 0;
            this.btnme.Text = "单击我";
            this.btnme.UseVisualStyleBackColor = true;
            this.btnme.Click += new System.EventHandler(this.btnme_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(422, 93);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(155, 79);
            this.reset.TabIndex = 1;
            this.reset.Text = "复位";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(690, 250);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.btnme);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnme;
        private System.Windows.Forms.Button reset;
    }
}

