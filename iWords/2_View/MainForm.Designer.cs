namespace iWords
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonWrong = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonUnknown = new System.Windows.Forms.Button();
            this.labelEnglish = new System.Windows.Forms.Label();
            this.labelChinese = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonVague = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerExam = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxChinese = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxEnglish);
            this.panel1.Controls.Add(this.labelRate);
            this.panel1.Controls.Add(this.labelConfirm);
            this.panel1.Controls.Add(this.labelDay);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePickerExam);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.textBoxChinese);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 690);
            this.panel1.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(374, 26);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(35, 14);
            this.labelTotal.TabIndex = 20;
            this.labelTotal.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 19;
            this.label5.Text = "Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonWrong);
            this.groupBox1.Controls.Add(this.buttonRight);
            this.groupBox1.Controls.Add(this.buttonUnknown);
            this.groupBox1.Controls.Add(this.labelEnglish);
            this.groupBox1.Controls.Add(this.labelChinese);
            this.groupBox1.Controls.Add(this.buttonConfirm);
            this.groupBox1.Controls.Add(this.buttonVague);
            this.groupBox1.Location = new System.Drawing.Point(190, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 372);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training";
            // 
            // buttonWrong
            // 
            this.buttonWrong.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonWrong.Location = new System.Drawing.Point(86, 294);
            this.buttonWrong.Name = "buttonWrong";
            this.buttonWrong.Size = new System.Drawing.Size(87, 27);
            this.buttonWrong.TabIndex = 18;
            this.buttonWrong.TabStop = false;
            this.buttonWrong.Text = "Wrong";
            this.buttonWrong.UseVisualStyleBackColor = true;
            this.buttonWrong.Click += new System.EventHandler(this.buttonWrong_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRight.Location = new System.Drawing.Point(365, 294);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(87, 27);
            this.buttonRight.TabIndex = 19;
            this.buttonRight.TabStop = false;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonUnknown
            // 
            this.buttonUnknown.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonUnknown.Location = new System.Drawing.Point(365, 134);
            this.buttonUnknown.Name = "buttonUnknown";
            this.buttonUnknown.Size = new System.Drawing.Size(87, 27);
            this.buttonUnknown.TabIndex = 16;
            this.buttonUnknown.TabStop = false;
            this.buttonUnknown.Text = "Unknown";
            this.buttonUnknown.UseVisualStyleBackColor = true;
            this.buttonUnknown.Click += new System.EventHandler(this.buttonUnknown_Click);
            // 
            // labelEnglish
            // 
            this.labelEnglish.AutoSize = true;
            this.labelEnglish.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEnglish.Location = new System.Drawing.Point(86, 218);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(79, 19);
            this.labelEnglish.TabIndex = 17;
            this.labelEnglish.Text = "English";
            // 
            // labelChinese
            // 
            this.labelChinese.AutoSize = true;
            this.labelChinese.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelChinese.Location = new System.Drawing.Point(86, 58);
            this.labelChinese.Name = "labelChinese";
            this.labelChinese.Size = new System.Drawing.Size(79, 19);
            this.labelChinese.TabIndex = 13;
            this.labelChinese.Text = "Chinese";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonConfirm.Location = new System.Drawing.Point(86, 134);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(87, 27);
            this.buttonConfirm.TabIndex = 14;
            this.buttonConfirm.TabStop = false;
            this.buttonConfirm.Text = "Known";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonVague
            // 
            this.buttonVague.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonVague.Location = new System.Drawing.Point(227, 134);
            this.buttonVague.Name = "buttonVague";
            this.buttonVague.Size = new System.Drawing.Size(87, 27);
            this.buttonVague.TabIndex = 15;
            this.buttonVague.TabStop = false;
            this.buttonVague.Text = "Vague";
            this.buttonVague.UseVisualStyleBackColor = true;
            this.buttonVague.Click += new System.EventHandler(this.buttonVague_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(827, 555);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 27);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.TabStop = false;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 561);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "English";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 561);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Chinese";
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.Location = new System.Drawing.Point(490, 557);
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.Size = new System.Drawing.Size(307, 23);
            this.textBoxEnglish.TabIndex = 1;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.ForeColor = System.Drawing.Color.White;
            this.labelRate.Location = new System.Drawing.Point(545, 26);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(28, 14);
            this.labelRate.TabIndex = 8;
            this.labelRate.Text = "50%";
            // 
            // labelConfirm
            // 
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.ForeColor = System.Drawing.Color.White;
            this.labelConfirm.Location = new System.Drawing.Point(257, 26);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(35, 14);
            this.labelConfirm.TabIndex = 7;
            this.labelConfirm.Text = "1000";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.ForeColor = System.Drawing.Color.White;
            this.labelDay.Location = new System.Drawing.Point(36, 26);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(21, 14);
            this.labelDay.TabIndex = 6;
            this.labelDay.Text = "80";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Days Remain";
            // 
            // dateTimePickerExam
            // 
            this.dateTimePickerExam.Location = new System.Drawing.Point(111, 635);
            this.dateTimePickerExam.Name = "dateTimePickerExam";
            this.dateTimePickerExam.Size = new System.Drawing.Size(233, 23);
            this.dateTimePickerExam.TabIndex = 3;
            this.dateTimePickerExam.TabStop = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(29, 639);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(35, 14);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Exam";
            // 
            // textBoxChinese
            // 
            this.textBoxChinese.Location = new System.Drawing.Point(111, 557);
            this.textBoxChinese.Name = "textBoxChinese";
            this.textBoxChinese.Size = new System.Drawing.Size(233, 23);
            this.textBoxChinese.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(942, 690);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iWords";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUnknown;
        private System.Windows.Forms.Button buttonVague;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelChinese;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEnglish;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelConfirm;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerExam;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxChinese;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonWrong;
        private System.Windows.Forms.Button buttonRight;
    }
}

