namespace PlcTest
{
    partial class FrmPlcTest
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
            this.lblStart = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.rtxtRead = new System.Windows.Forms.RichTextBox();
            this.rtxtWrite = new System.Windows.Forms.RichTextBox();
            this.lblWrite = new System.Windows.Forms.Label();
            this.lblRead = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(12, 15);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(65, 12);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "起始位置：";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(83, 12);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(208, 21);
            this.txtStart.TabIndex = 1;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(12, 42);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(65, 12);
            this.lblEnd.TabIndex = 0;
            this.lblEnd.Text = "终止位置：";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(83, 39);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(208, 21);
            this.txtEnd.TabIndex = 2;
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(297, 10);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 4;
            this.btnBuild.Text = "生成";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // rtxtRead
            // 
            this.rtxtRead.Location = new System.Drawing.Point(83, 123);
            this.rtxtRead.Name = "rtxtRead";
            this.rtxtRead.Size = new System.Drawing.Size(289, 60);
            this.rtxtRead.TabIndex = 5;
            this.rtxtRead.Text = "";
            // 
            // rtxtWrite
            // 
            this.rtxtWrite.Location = new System.Drawing.Point(83, 189);
            this.rtxtWrite.Name = "rtxtWrite";
            this.rtxtWrite.Size = new System.Drawing.Size(289, 60);
            this.rtxtWrite.TabIndex = 6;
            this.rtxtWrite.Text = "";
            // 
            // lblWrite
            // 
            this.lblWrite.AutoSize = true;
            this.lblWrite.Location = new System.Drawing.Point(12, 192);
            this.lblWrite.Name = "lblWrite";
            this.lblWrite.Size = new System.Drawing.Size(65, 12);
            this.lblWrite.TabIndex = 0;
            this.lblWrite.Text = "写入指令：";
            // 
            // lblRead
            // 
            this.lblRead.AutoSize = true;
            this.lblRead.Location = new System.Drawing.Point(12, 126);
            this.lblRead.Name = "lblRead";
            this.lblRead.Size = new System.Drawing.Size(65, 12);
            this.lblRead.TabIndex = 0;
            this.lblRead.Text = "读取指令：";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(83, 66);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(289, 21);
            this.txtData.TabIndex = 3;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 69);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(65, 12);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "写入数据：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "每写入一个数据位置，需要4个字节，十六进制";
            // 
            // FrmPlcTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.rtxtWrite);
            this.Controls.Add(this.rtxtRead);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.lblRead);
            this.Controls.Add(this.lblWrite);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.lblStart);
            this.Name = "FrmPlcTest";
            this.Text = "PlcTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.RichTextBox rtxtRead;
        private System.Windows.Forms.RichTextBox rtxtWrite;
        private System.Windows.Forms.Label lblWrite;
        private System.Windows.Forms.Label lblRead;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label1;
    }
}

