namespace WfMasteringItContest
{
    partial class frmInsertScore
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
            this.nrcDiemSo = new System.Windows.Forms.NumericUpDown();
            this.lblDiemSo = new System.Windows.Forms.Label();
            this.lblDoiThi = new System.Windows.Forms.Label();
            this.cmbDoiThi = new System.Windows.Forms.ComboBox();
            this.lblTroChoi = new System.Windows.Forms.Label();
            this.cmbTroChoi = new System.Windows.Forms.ComboBox();
            this.lblHeThi = new System.Windows.Forms.Label();
            this.cmbHeThi = new System.Windows.Forms.ComboBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nrcDiemSo)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // nrcDiemSo
            // 
            this.nrcDiemSo.Location = new System.Drawing.Point(18, 171);
            this.nrcDiemSo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nrcDiemSo.Name = "nrcDiemSo";
            this.nrcDiemSo.Size = new System.Drawing.Size(201, 20);
            this.nrcDiemSo.TabIndex = 49;
            // 
            // lblDiemSo
            // 
            this.lblDiemSo.AutoSize = true;
            this.lblDiemSo.Location = new System.Drawing.Point(18, 155);
            this.lblDiemSo.Name = "lblDiemSo";
            this.lblDiemSo.Size = new System.Drawing.Size(45, 13);
            this.lblDiemSo.TabIndex = 48;
            this.lblDiemSo.Text = "Điểm số";
            // 
            // lblDoiThi
            // 
            this.lblDoiThi.AutoSize = true;
            this.lblDoiThi.Location = new System.Drawing.Point(18, 109);
            this.lblDoiThi.Name = "lblDoiThi";
            this.lblDoiThi.Size = new System.Drawing.Size(37, 13);
            this.lblDoiThi.TabIndex = 47;
            this.lblDoiThi.Text = "Đội thi";
            // 
            // cmbDoiThi
            // 
            this.cmbDoiThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoiThi.FormattingEnabled = true;
            this.cmbDoiThi.Location = new System.Drawing.Point(18, 125);
            this.cmbDoiThi.Name = "cmbDoiThi";
            this.cmbDoiThi.Size = new System.Drawing.Size(201, 21);
            this.cmbDoiThi.TabIndex = 46;
            // 
            // lblTroChoi
            // 
            this.lblTroChoi.AutoSize = true;
            this.lblTroChoi.Location = new System.Drawing.Point(18, 63);
            this.lblTroChoi.Name = "lblTroChoi";
            this.lblTroChoi.Size = new System.Drawing.Size(46, 13);
            this.lblTroChoi.TabIndex = 45;
            this.lblTroChoi.Text = "Trò chơi";
            // 
            // cmbTroChoi
            // 
            this.cmbTroChoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTroChoi.FormattingEnabled = true;
            this.cmbTroChoi.Location = new System.Drawing.Point(18, 79);
            this.cmbTroChoi.Name = "cmbTroChoi";
            this.cmbTroChoi.Size = new System.Drawing.Size(201, 21);
            this.cmbTroChoi.TabIndex = 44;
            // 
            // lblHeThi
            // 
            this.lblHeThi.AutoSize = true;
            this.lblHeThi.Location = new System.Drawing.Point(18, 19);
            this.lblHeThi.Name = "lblHeThi";
            this.lblHeThi.Size = new System.Drawing.Size(35, 13);
            this.lblHeThi.TabIndex = 43;
            this.lblHeThi.Text = "Hệ thi";
            // 
            // cmbHeThi
            // 
            this.cmbHeThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeThi.FormattingEnabled = true;
            this.cmbHeThi.Location = new System.Drawing.Point(18, 35);
            this.cmbHeThi.Name = "cmbHeThi";
            this.cmbHeThi.Size = new System.Drawing.Size(201, 21);
            this.cmbHeThi.TabIndex = 42;
            this.cmbHeThi.SelectedIndexChanged += new System.EventHandler(this.cmbHeThi_SelectedValueChanged);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.Controls.Add(this.btnThem);
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 225);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(238, 44);
            this.panelBottom.TabIndex = 41;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(76, 16);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(157, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmInsertScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.nrcDiemSo);
            this.Controls.Add(this.lblDiemSo);
            this.Controls.Add(this.lblDoiThi);
            this.Controls.Add(this.cmbDoiThi);
            this.Controls.Add(this.lblTroChoi);
            this.Controls.Add(this.cmbTroChoi);
            this.Controls.Add(this.lblHeThi);
            this.Controls.Add(this.cmbHeThi);
            this.Controls.Add(this.panelBottom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInsertScore";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmInsertScore";
            this.Load += new System.EventHandler(this.frmInsertScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nrcDiemSo)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nrcDiemSo;
        private System.Windows.Forms.Label lblDiemSo;
        private System.Windows.Forms.Label lblDoiThi;
        private System.Windows.Forms.ComboBox cmbDoiThi;
        private System.Windows.Forms.Label lblTroChoi;
        private System.Windows.Forms.ComboBox cmbTroChoi;
        private System.Windows.Forms.Label lblHeThi;
        private System.Windows.Forms.ComboBox cmbHeThi;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnClose;
    }
}