namespace photoDownApp
{
    partial class Form1
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
            this.btnStartDown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxInNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFilePath = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpenFold = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartDown
            // 
            this.btnStartDown.Location = new System.Drawing.Point(325, 222);
            this.btnStartDown.Name = "btnStartDown";
            this.btnStartDown.Size = new System.Drawing.Size(75, 23);
            this.btnStartDown.TabIndex = 0;
            this.btnStartDown.Text = "下载";
            this.btnStartDown.UseVisualStyleBackColor = true;
            this.btnStartDown.Click += new System.EventHandler(this.btnStartDown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入要下载的In号：";
            // 
            // tbxInNumber
            // 
            this.tbxInNumber.Location = new System.Drawing.Point(305, 97);
            this.tbxInNumber.Name = "tbxInNumber";
            this.tbxInNumber.Size = new System.Drawing.Size(154, 21);
            this.tbxInNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "请选择保存的文件夹路径：";
            // 
            // tbxFilePath
            // 
            this.tbxFilePath.Location = new System.Drawing.Point(305, 144);
            this.tbxFilePath.Name = "tbxFilePath";
            this.tbxFilePath.ReadOnly = true;
            this.tbxFilePath.Size = new System.Drawing.Size(154, 21);
            this.tbxFilePath.TabIndex = 4;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(485, 144);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(52, 21);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "选择";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "下载进度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 7;
            // 
            // btnOpenFold
            // 
            this.btnOpenFold.Location = new System.Drawing.Point(485, 347);
            this.btnOpenFold.Name = "btnOpenFold";
            this.btnOpenFold.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFold.TabIndex = 8;
            this.btnOpenFold.Text = "打开文件夹";
            this.btnOpenFold.UseVisualStyleBackColor = true;
            this.btnOpenFold.Visible = false;
            this.btnOpenFold.Click += new System.EventHandler(this.btnOpenFold_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenFold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.tbxFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxInNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartDown);
            this.Name = "Form1";
            this.Text = "In美图下载工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxInNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFilePath;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpenFold;
    }
}

