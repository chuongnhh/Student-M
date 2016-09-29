namespace WfMasteringItContest
{
    partial class frmInsertGame
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
            this.lblHeThi = new System.Windows.Forms.Label();
            this.cmbHeThi = new System.Windows.Forms.ComboBox();
            this.nrcThoiGian = new System.Windows.Forms.NumericUpDown();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.txtTenTroChoi = new System.Windows.Forms.TextBox();
            this.lblTenTroChoi = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nrcThoiGian)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeThi
            // 
            this.lblHeThi.AutoSize = true;
            this.lblHeThi.Location = new System.Drawing.Point(22, 38);
            this.lblHeThi.Name = "lblHeThi";
            this.lblHeThi.Size = new System.Drawing.Size(57, 13);
            this.lblHeThi.TabIndex = 45;
            this.lblHeThi.Text = "Hệ thi đấu";
            // 
            // cmbHeThi
            // 
            this.cmbHeThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeThi.FormattingEnabled = true;
            this.cmbHeThi.Location = new System.Drawing.Point(22, 54);
            this.cmbHeThi.Name = "cmbHeThi";
            this.cmbHeThi.Size = new System.Drawing.Size(201, 21);
            this.cmbHeThi.TabIndex = 44;
            // 
            // nrcThoiGian
            // 
            this.nrcThoiGian.Location = new System.Drawing.Point(22, 141);
            this.nrcThoiGian.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nrcThoiGian.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nrcThoiGian.Name = "nrcThoiGian";
            this.nrcThoiGian.Size = new System.Drawing.Size(201, 20);
            this.nrcThoiGian.TabIndex = 43;
            this.nrcThoiGian.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(22, 127);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(51, 13);
            this.lblThoiGian.TabIndex = 42;
            this.lblThoiGian.Text = "Thời gian";
            // 
            // txtTenTroChoi
            // 
            this.txtTenTroChoi.Location = new System.Drawing.Point(22, 99);
            this.txtTenTroChoi.Name = "txtTenTroChoi";
            this.txtTenTroChoi.Size = new System.Drawing.Size(201, 20);
            this.txtTenTroChoi.TabIndex = 41;
            // 
            // lblTenTroChoi
            // 
            this.lblTenTroChoi.AutoSize = true;
            this.lblTenTroChoi.Location = new System.Drawing.Point(22, 83);
            this.lblTenTroChoi.Name = "lblTenTroChoi";
            this.lblTenTroChoi.Size = new System.Drawing.Size(64, 13);
            this.lblTenTroChoi.TabIndex = 40;
            this.lblTenTroChoi.Text = "Tên trò chơi";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Controls.Add(this.btnThem);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 217);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(245, 44);
            this.panelBottom.TabIndex = 39;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(164, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(75, 16);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmInsertGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(245, 261);
            this.Controls.Add(this.lblHeThi);
            this.Controls.Add(this.cmbHeThi);
            this.Controls.Add(this.nrcThoiGian);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.txtTenTroChoi);
            this.Controls.Add(this.lblTenTroChoi);
            this.Controls.Add(this.panelBottom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInsertGame";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmInsertGame";
            this.Load += new System.EventHandler(this.frmInsertGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nrcThoiGian)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeThi;
        private System.Windows.Forms.ComboBox cmbHeThi;
        private System.Windows.Forms.NumericUpDown nrcThoiGian;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.TextBox txtTenTroChoi;
        private System.Windows.Forms.Label lblTenTroChoi;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnThem;
    }
}