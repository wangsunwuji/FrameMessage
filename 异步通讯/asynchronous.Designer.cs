namespace 异步通讯
{
    partial class asynchronous
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
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.label1 = new System.Windows.Forms.Label();
            this.StartTask = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Task1 = new System.Windows.Forms.Label();
            this.Task2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "任务1：";
            // 
            // StartTask
            // 
            this.StartTask.Location = new System.Drawing.Point(88, 147);
            this.StartTask.Name = "StartTask";
            this.StartTask.Size = new System.Drawing.Size(100, 63);
            this.StartTask.TabIndex = 1;
            this.StartTask.Text = "开始任务";
            this.StartTask.UseVisualStyleBackColor = true;
            this.StartTask.Click += new System.EventHandler(this.StartTask_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "任务2：";
            // 
            // Task1
            // 
            this.Task1.AutoSize = true;
            this.Task1.Location = new System.Drawing.Point(324, 130);
            this.Task1.Name = "Task1";
            this.Task1.Size = new System.Drawing.Size(60, 15);
            this.Task1.TabIndex = 3;
            this.Task1.Text = "任务1：";
            // 
            // Task2
            // 
            this.Task2.AutoSize = true;
            this.Task2.Location = new System.Drawing.Point(324, 207);
            this.Task2.Name = "Task2";
            this.Task2.Size = new System.Drawing.Size(60, 15);
            this.Task2.TabIndex = 4;
            this.Task2.Text = "任务2：";
            // 
            // asynchronous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 354);
            this.Controls.Add(this.Task2);
            this.Controls.Add(this.Task1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartTask);
            this.Controls.Add(this.label1);
            this.Name = "asynchronous";
            this.Text = "异步通讯";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Task1;
        private System.Windows.Forms.Label Task2;
    }
}

