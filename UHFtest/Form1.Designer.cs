namespace UHFtest
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_test = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_ReadMultipleEPC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_bank = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_accessPWD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_lock = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_killPWD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_kill = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(467, 108);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(114, 32);
            this.btn_test.TabIndex = 0;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(13, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(433, 364);
            this.listBox1.TabIndex = 1;
            // 
            // btn_ReadMultipleEPC
            // 
            this.btn_ReadMultipleEPC.Location = new System.Drawing.Point(467, 179);
            this.btn_ReadMultipleEPC.Name = "btn_ReadMultipleEPC";
            this.btn_ReadMultipleEPC.Size = new System.Drawing.Size(115, 32);
            this.btn_ReadMultipleEPC.TabIndex = 2;
            this.btn_ReadMultipleEPC.Text = "Read multiple EPC";
            this.btn_ReadMultipleEPC.UseVisualStyleBackColor = true;
            this.btn_ReadMultipleEPC.Click += new System.EventHandler(this.btn_ReadMultipleEPC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_lock);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_accessPWD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_type);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_bank);
            this.groupBox1.Location = new System.Drawing.Point(12, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 78);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lock tag";
            // 
            // comboBox_bank
            // 
            this.comboBox_bank.FormattingEnabled = true;
            this.comboBox_bank.Items.AddRange(new object[] {
            "USER",
            "TID",
            "EPC",
            "ACCESS PWD",
            "KILL PWD"});
            this.comboBox_bank.Location = new System.Drawing.Point(15, 40);
            this.comboBox_bank.Name = "comboBox_bank";
            this.comboBox_bank.Size = new System.Drawing.Size(88, 20);
            this.comboBox_bank.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lock bank";
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "OPEN",
            "PERMANENTLY OPEN",
            "LOCK",
            "PERMANENTLY LOCK"});
            this.comboBox_type.Location = new System.Drawing.Point(128, 40);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(117, 20);
            this.comboBox_type.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lock type";
            // 
            // textBox_accessPWD
            // 
            this.textBox_accessPWD.Location = new System.Drawing.Point(272, 39);
            this.textBox_accessPWD.MaxLength = 8;
            this.textBox_accessPWD.Name = "textBox_accessPWD";
            this.textBox_accessPWD.Size = new System.Drawing.Size(139, 21);
            this.textBox_accessPWD.TabIndex = 4;
            this.textBox_accessPWD.Text = "00000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Access password(HEX)";
            // 
            // btn_lock
            // 
            this.btn_lock.Location = new System.Drawing.Point(441, 32);
            this.btn_lock.Name = "btn_lock";
            this.btn_lock.Size = new System.Drawing.Size(128, 32);
            this.btn_lock.TabIndex = 6;
            this.btn_lock.Text = "Lock";
            this.btn_lock.UseVisualStyleBackColor = true;
            this.btn_lock.Click += new System.EventHandler(this.btn_lock_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_kill);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_killPWD);
            this.groupBox2.Location = new System.Drawing.Point(11, 504);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 67);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kill tag";
            // 
            // textBox_killPWD
            // 
            this.textBox_killPWD.Location = new System.Drawing.Point(273, 33);
            this.textBox_killPWD.MaxLength = 8;
            this.textBox_killPWD.Name = "textBox_killPWD";
            this.textBox_killPWD.Size = new System.Drawing.Size(139, 21);
            this.textBox_killPWD.TabIndex = 0;
            this.textBox_killPWD.Text = "00000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kill password(HEX)";
            // 
            // btn_kill
            // 
            this.btn_kill.Location = new System.Drawing.Point(443, 20);
            this.btn_kill.Name = "btn_kill";
            this.btn_kill.Size = new System.Drawing.Size(126, 33);
            this.btn_kill.TabIndex = 2;
            this.btn_kill.Text = "Kill";
            this.btn_kill.UseVisualStyleBackColor = true;
            this.btn_kill.Click += new System.EventHandler(this.btn_kill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 576);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ReadMultipleEPC);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_test);
            this.Name = "Form1";
            this.Text = "UHFtest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_ReadMultipleEPC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_bank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_accessPWD;
        private System.Windows.Forms.Button btn_lock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_kill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_killPWD;
    }
}

