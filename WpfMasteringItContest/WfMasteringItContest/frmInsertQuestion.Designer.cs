namespace WfMasteringItContest
{
    partial class frmInsertQuestion
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
            this.cmbDapAnDung = new System.Windows.Forms.ComboBox();
            this.lblHeThi = new System.Windows.Forms.Label();
            this.cmbHeThi = new System.Windows.Forms.ComboBox();
            this.lblDapAnDung = new System.Windows.Forms.Label();
            this.txtLuaChonD = new System.Windows.Forms.TextBox();
            this.lblLuaChonD = new System.Windows.Forms.Label();
            this.txtLuaChonC = new System.Windows.Forms.TextBox();
            this.lblLuaChonC = new System.Windows.Forms.Label();
            this.txtLuaChonB = new System.Windows.Forms.TextBox();
            this.lblLuaChonB = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtLuaChonA = new System.Windows.Forms.TextBox();
            this.lblLuaChonA = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.lblTroChoi = new System.Windows.Forms.Label();
            this.cmbTroChoi = new System.Windows.Forms.ComboBox();
            this.txtTenCauHoi = new System.Windows.Forms.TextBox();
            this.lblTenCauHoi = new System.Windows.Forms.Label();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.ckbTuLuan = new System.Windows.Forms.CheckBox();
            this.txtDapAn = new System.Windows.Forms.TextBox();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDapAnDung
            // 
            this.cmbDapAnDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDapAnDung.FormattingEnabled = true;
            this.cmbDapAnDung.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbDapAnDung.Location = new System.Drawing.Point(225, 69);
            this.cmbDapAnDung.Name = "cmbDapAnDung";
            this.cmbDapAnDung.Size = new System.Drawing.Size(212, 21);
            this.cmbDapAnDung.TabIndex = 91;
            // 
            // lblHeThi
            // 
            this.lblHeThi.AutoSize = true;
            this.lblHeThi.Location = new System.Drawing.Point(13, 10);
            this.lblHeThi.Name = "lblHeThi";
            this.lblHeThi.Size = new System.Drawing.Size(35, 13);
            this.lblHeThi.TabIndex = 90;
            this.lblHeThi.Text = "Hệ thi";
            // 
            // cmbHeThi
            // 
            this.cmbHeThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeThi.FormattingEnabled = true;
            this.cmbHeThi.Location = new System.Drawing.Point(13, 26);
            this.cmbHeThi.Name = "cmbHeThi";
            this.cmbHeThi.Size = new System.Drawing.Size(196, 21);
            this.cmbHeThi.TabIndex = 89;
            this.cmbHeThi.SelectedIndexChanged += new System.EventHandler(this.cmbHeThi_SelectedValueChanged);
            // 
            // lblDapAnDung
            // 
            this.lblDapAnDung.AutoSize = true;
            this.lblDapAnDung.Location = new System.Drawing.Point(225, 52);
            this.lblDapAnDung.Name = "lblDapAnDung";
            this.lblDapAnDung.Size = new System.Drawing.Size(45, 13);
            this.lblDapAnDung.TabIndex = 88;
            this.lblDapAnDung.Text = "Đáp án ";
            // 
            // txtLuaChonD
            // 
            this.txtLuaChonD.Location = new System.Drawing.Point(12, 418);
            this.txtLuaChonD.Multiline = true;
            this.txtLuaChonD.Name = "txtLuaChonD";
            this.txtLuaChonD.Size = new System.Drawing.Size(422, 34);
            this.txtLuaChonD.TabIndex = 87;
            // 
            // lblLuaChonD
            // 
            this.lblLuaChonD.AutoSize = true;
            this.lblLuaChonD.Location = new System.Drawing.Point(12, 403);
            this.lblLuaChonD.Name = "lblLuaChonD";
            this.lblLuaChonD.Size = new System.Drawing.Size(63, 13);
            this.lblLuaChonD.TabIndex = 86;
            this.lblLuaChonD.Text = "Lựa chọn D";
            // 
            // txtLuaChonC
            // 
            this.txtLuaChonC.Location = new System.Drawing.Point(12, 363);
            this.txtLuaChonC.Multiline = true;
            this.txtLuaChonC.Name = "txtLuaChonC";
            this.txtLuaChonC.Size = new System.Drawing.Size(422, 34);
            this.txtLuaChonC.TabIndex = 85;
            // 
            // lblLuaChonC
            // 
            this.lblLuaChonC.AutoSize = true;
            this.lblLuaChonC.Location = new System.Drawing.Point(12, 346);
            this.lblLuaChonC.Name = "lblLuaChonC";
            this.lblLuaChonC.Size = new System.Drawing.Size(62, 13);
            this.lblLuaChonC.TabIndex = 84;
            this.lblLuaChonC.Text = "Lựa chọn C";
            // 
            // txtLuaChonB
            // 
            this.txtLuaChonB.Location = new System.Drawing.Point(12, 309);
            this.txtLuaChonB.Multiline = true;
            this.txtLuaChonB.Name = "txtLuaChonB";
            this.txtLuaChonB.Size = new System.Drawing.Size(422, 34);
            this.txtLuaChonB.TabIndex = 83;
            // 
            // lblLuaChonB
            // 
            this.lblLuaChonB.AutoSize = true;
            this.lblLuaChonB.Location = new System.Drawing.Point(12, 294);
            this.lblLuaChonB.Name = "lblLuaChonB";
            this.lblLuaChonB.Size = new System.Drawing.Size(62, 13);
            this.lblLuaChonB.TabIndex = 82;
            this.lblLuaChonB.Text = "Lựa chọn B";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(372, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(290, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtLuaChonA
            // 
            this.txtLuaChonA.Location = new System.Drawing.Point(12, 254);
            this.txtLuaChonA.Multiline = true;
            this.txtLuaChonA.Name = "txtLuaChonA";
            this.txtLuaChonA.Size = new System.Drawing.Size(422, 34);
            this.txtLuaChonA.TabIndex = 81;
            // 
            // lblLuaChonA
            // 
            this.lblLuaChonA.AutoSize = true;
            this.lblLuaChonA.Location = new System.Drawing.Point(12, 237);
            this.lblLuaChonA.Name = "lblLuaChonA";
            this.lblLuaChonA.Size = new System.Drawing.Size(62, 13);
            this.lblLuaChonA.TabIndex = 80;
            this.lblLuaChonA.Text = "Lựa chọn A";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoiDung.Location = new System.Drawing.Point(13, 127);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoiDung.Size = new System.Drawing.Size(421, 107);
            this.txtNoiDung.TabIndex = 79;
            // 
            // lblTroChoi
            // 
            this.lblTroChoi.AutoSize = true;
            this.lblTroChoi.Location = new System.Drawing.Point(13, 52);
            this.lblTroChoi.Name = "lblTroChoi";
            this.lblTroChoi.Size = new System.Drawing.Size(46, 13);
            this.lblTroChoi.TabIndex = 77;
            this.lblTroChoi.Text = "Trò chơi";
            // 
            // cmbTroChoi
            // 
            this.cmbTroChoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTroChoi.FormattingEnabled = true;
            this.cmbTroChoi.Location = new System.Drawing.Point(13, 69);
            this.cmbTroChoi.Name = "cmbTroChoi";
            this.cmbTroChoi.Size = new System.Drawing.Size(196, 21);
            this.cmbTroChoi.TabIndex = 76;
            this.cmbTroChoi.SelectedIndexChanged += new System.EventHandler(this.cmbTroChoi_SelectedValueChanged);
            // 
            // txtTenCauHoi
            // 
            this.txtTenCauHoi.Location = new System.Drawing.Point(225, 26);
            this.txtTenCauHoi.Name = "txtTenCauHoi";
            this.txtTenCauHoi.Size = new System.Drawing.Size(212, 20);
            this.txtTenCauHoi.TabIndex = 75;
            // 
            // lblTenCauHoi
            // 
            this.lblTenCauHoi.AutoSize = true;
            this.lblTenCauHoi.Location = new System.Drawing.Point(225, 10);
            this.lblTenCauHoi.Name = "lblTenCauHoi";
            this.lblTenCauHoi.Size = new System.Drawing.Size(64, 13);
            this.lblTenCauHoi.TabIndex = 74;
            this.lblTenCauHoi.Text = "Tên câu hỏi";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Location = new System.Drawing.Point(13, 111);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(50, 13);
            this.lblNoiDung.TabIndex = 78;
            this.lblNoiDung.Text = "Nội dung";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Controls.Add(this.btnThem);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 468);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(452, 44);
            this.panelBottom.TabIndex = 73;
            // 
            // ckbTuLuan
            // 
            this.ckbTuLuan.AutoSize = true;
            this.ckbTuLuan.Location = new System.Drawing.Point(290, 50);
            this.ckbTuLuan.Name = "ckbTuLuan";
            this.ckbTuLuan.Size = new System.Drawing.Size(68, 17);
            this.ckbTuLuan.TabIndex = 93;
            this.ckbTuLuan.Text = "Tự luận?";
            this.ckbTuLuan.UseVisualStyleBackColor = true;
            this.ckbTuLuan.CheckedChanged += new System.EventHandler(this.ckbTuLuan_CheckedChanged);
            // 
            // txtDapAn
            // 
            this.txtDapAn.Location = new System.Drawing.Point(225, 69);
            this.txtDapAn.Multiline = true;
            this.txtDapAn.Name = "txtDapAn";
            this.txtDapAn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDapAn.Size = new System.Drawing.Size(212, 52);
            this.txtDapAn.TabIndex = 94;
            this.txtDapAn.Visible = false;
            // 
            // frmInsertQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(452, 512);
            this.Controls.Add(this.txtDapAn);
            this.Controls.Add(this.ckbTuLuan);
            this.Controls.Add(this.cmbDapAnDung);
            this.Controls.Add(this.lblHeThi);
            this.Controls.Add(this.cmbHeThi);
            this.Controls.Add(this.lblDapAnDung);
            this.Controls.Add(this.txtLuaChonD);
            this.Controls.Add(this.lblLuaChonD);
            this.Controls.Add(this.txtLuaChonC);
            this.Controls.Add(this.lblLuaChonC);
            this.Controls.Add(this.txtLuaChonB);
            this.Controls.Add(this.lblLuaChonB);
            this.Controls.Add(this.txtLuaChonA);
            this.Controls.Add(this.lblLuaChonA);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.lblTroChoi);
            this.Controls.Add(this.cmbTroChoi);
            this.Controls.Add(this.txtTenCauHoi);
            this.Controls.Add(this.lblTenCauHoi);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.panelBottom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInsertQuestion";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmInsertQuestion";
            this.Load += new System.EventHandler(this.frmInsertQuestion_Load);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDapAnDung;
        private System.Windows.Forms.Label lblHeThi;
        private System.Windows.Forms.ComboBox cmbHeThi;
        private System.Windows.Forms.Label lblDapAnDung;
        private System.Windows.Forms.TextBox txtLuaChonD;
        private System.Windows.Forms.Label lblLuaChonD;
        private System.Windows.Forms.TextBox txtLuaChonC;
        private System.Windows.Forms.Label lblLuaChonC;
        private System.Windows.Forms.TextBox txtLuaChonB;
        private System.Windows.Forms.Label lblLuaChonB;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtLuaChonA;
        private System.Windows.Forms.Label lblLuaChonA;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label lblTroChoi;
        private System.Windows.Forms.ComboBox cmbTroChoi;
        private System.Windows.Forms.TextBox txtTenCauHoi;
        private System.Windows.Forms.Label lblTenCauHoi;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.CheckBox ckbTuLuan;
        private System.Windows.Forms.TextBox txtDapAn;
    }
}