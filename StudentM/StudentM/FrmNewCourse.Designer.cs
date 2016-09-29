namespace StudentM
{
    partial class FrmNewCourse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.btnNewLevel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPractice = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSkill = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSecondDay = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFirstDay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpClosing = new System.Windows.Forms.DateTimePicker();
            this.dtpOpening = new System.Windows.Forms.DateTimePicker();
            this.dtpCourseTime = new System.Windows.Forms.DateTimePicker();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveAndQuit = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 75);
            this.panel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::StudentM.Properties.Resources.course;
            this.pictureBox1.Location = new System.Drawing.Point(413, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(0, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Thêm khóa học mới";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnFindStudent);
            this.panel2.Controls.Add(this.btnNewLevel);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cmbLevel);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cmbPractice);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cmbSkill);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbSecondDay);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbFirstDay);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtpClosing);
            this.panel2.Controls.Add(this.dtpOpening);
            this.panel2.Controls.Add(this.dtpCourseTime);
            this.panel2.Controls.Add(this.txtCourseName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCourseID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 299);
            this.panel2.TabIndex = 37;
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindStudent.BackgroundImage = global::StudentM.Properties.Resources.search;
            this.btnFindStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindStudent.Location = new System.Drawing.Point(417, 25);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(21, 21);
            this.btnFindStudent.TabIndex = 97;
            this.btnFindStudent.UseVisualStyleBackColor = true;
            // 
            // btnNewLevel
            // 
            this.btnNewLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewLevel.BackgroundImage = global::StudentM.Properties.Resources.add;
            this.btnNewLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewLevel.Location = new System.Drawing.Point(388, 25);
            this.btnNewLevel.Name = "btnNewLevel";
            this.btnNewLevel.Size = new System.Drawing.Size(21, 21);
            this.btnNewLevel.TabIndex = 96;
            this.btnNewLevel.UseVisualStyleBackColor = true;
            this.btnNewLevel.Click += new System.EventHandler(this.btnNewLevel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Cấp độ";
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Location = new System.Drawing.Point(83, 25);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(299, 21);
            this.cmbLevel.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Thực hành";
            // 
            // cmbPractice
            // 
            this.cmbPractice.BackColor = System.Drawing.Color.White;
            this.cmbPractice.FormattingEnabled = true;
            this.cmbPractice.Items.AddRange(new object[] {
            "Thứ hai",
            "Thứ ba",
            "Thứ tư",
            "Thứ năm",
            "Thứ sáu",
            "Thứ bảy",
            "Chủ nhật - sáng",
            "Chủ nhật - chiều"});
            this.cmbPractice.Location = new System.Drawing.Point(83, 248);
            this.cmbPractice.Name = "cmbPractice";
            this.cmbPractice.Size = new System.Drawing.Size(358, 21);
            this.cmbPractice.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Kỹ năng";
            // 
            // cmbSkill
            // 
            this.cmbSkill.BackColor = System.Drawing.Color.White;
            this.cmbSkill.FormattingEnabled = true;
            this.cmbSkill.Items.AddRange(new object[] {
            "Thứ hai",
            "Thứ ba",
            "Thứ tư",
            "Thứ năm",
            "Thứ sáu",
            "Thứ bảy",
            "Chủ nhật - sáng",
            "Chủ nhật - chiều"});
            this.cmbSkill.Location = new System.Drawing.Point(83, 221);
            this.cmbSkill.Name = "cmbSkill";
            this.cmbSkill.Size = new System.Drawing.Size(358, 21);
            this.cmbSkill.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Ngày hai";
            // 
            // cmbSecondDay
            // 
            this.cmbSecondDay.BackColor = System.Drawing.Color.White;
            this.cmbSecondDay.FormattingEnabled = true;
            this.cmbSecondDay.Items.AddRange(new object[] {
            "Thứ hai",
            "Thứ ba",
            "Thứ tư",
            "Thứ năm",
            "Thứ sáu",
            "Thứ bảy",
            "Chủ nhật - sáng",
            "Chủ nhật - chiều"});
            this.cmbSecondDay.Location = new System.Drawing.Point(83, 194);
            this.cmbSecondDay.Name = "cmbSecondDay";
            this.cmbSecondDay.Size = new System.Drawing.Size(358, 21);
            this.cmbSecondDay.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Ngày một";
            // 
            // cmbFirstDay
            // 
            this.cmbFirstDay.BackColor = System.Drawing.Color.White;
            this.cmbFirstDay.FormattingEnabled = true;
            this.cmbFirstDay.Items.AddRange(new object[] {
            "Thứ hai",
            "Thứ ba",
            "Thứ tư",
            "Thứ năm",
            "Thứ sáu",
            "Thứ bảy",
            "Chủ nhật - sáng",
            "Chủ nhật - chiều"});
            this.cmbFirstDay.Location = new System.Drawing.Point(83, 167);
            this.cmbFirstDay.Name = "cmbFirstDay";
            this.cmbFirstDay.Size = new System.Drawing.Size(358, 21);
            this.cmbFirstDay.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Bế giảng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Khai giảng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Thời gian";
            // 
            // dtpClosing
            // 
            this.dtpClosing.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpClosing.Location = new System.Drawing.Point(292, 130);
            this.dtpClosing.Name = "dtpClosing";
            this.dtpClosing.Size = new System.Drawing.Size(148, 20);
            this.dtpClosing.TabIndex = 33;
            // 
            // dtpOpening
            // 
            this.dtpOpening.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOpening.Location = new System.Drawing.Point(83, 130);
            this.dtpOpening.Name = "dtpOpening";
            this.dtpOpening.Size = new System.Drawing.Size(139, 20);
            this.dtpOpening.TabIndex = 32;
            // 
            // dtpCourseTime
            // 
            this.dtpCourseTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCourseTime.Location = new System.Drawing.Point(83, 104);
            this.dtpCourseTime.Name = "dtpCourseTime";
            this.dtpCourseTime.ShowUpDown = true;
            this.dtpCourseTime.Size = new System.Drawing.Size(139, 20);
            this.dtpCourseTime.TabIndex = 31;
            // 
            // txtCourseName
            // 
            this.txtCourseName.BackColor = System.Drawing.Color.White;
            this.txtCourseName.Location = new System.Drawing.Point(83, 78);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(358, 20);
            this.txtCourseName.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Khóa học (*)";
            // 
            // txtCourseID
            // 
            this.txtCourseID.BackColor = System.Drawing.Color.White;
            this.txtCourseID.Location = new System.Drawing.Point(83, 52);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(357, 20);
            this.txtCourseID.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã số (*)";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnSaveAndQuit);
            this.panel3.Controls.Add(this.btnQuit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 372);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 49);
            this.panel3.TabIndex = 38;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(124, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAndQuit
            // 
            this.btnSaveAndQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAndQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveAndQuit.Location = new System.Drawing.Point(230, 12);
            this.btnSaveAndQuit.Name = "btnSaveAndQuit";
            this.btnSaveAndQuit.Size = new System.Drawing.Size(100, 23);
            this.btnSaveAndQuit.TabIndex = 39;
            this.btnSaveAndQuit.Text = "Lưu và đóng";
            this.btnSaveAndQuit.UseVisualStyleBackColor = true;
            this.btnSaveAndQuit.Click += new System.EventHandler(this.btnSaveAndQuit_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Location = new System.Drawing.Point(336, 12);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 23);
            this.btnQuit.TabIndex = 38;
            this.btnQuit.Text = "Đóng";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // FrmNewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 421);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewCourse";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khóa học";
            this.Load += new System.EventHandler(this.FrmNewCourse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFindStudent;
        private System.Windows.Forms.Button btnNewLevel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPractice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSkill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSecondDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFirstDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpClosing;
        private System.Windows.Forms.DateTimePicker dtpOpening;
        private System.Windows.Forms.DateTimePicker dtpCourseTime;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveAndQuit;
        private System.Windows.Forms.Button btnQuit;
    }
}