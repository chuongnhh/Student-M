namespace WfMasteringItContest
{
    partial class frmInsertCompetitionRules
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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblHeThi = new System.Windows.Forms.Label();
            this.cmbHeThi = new System.Windows.Forms.ComboBox();
            this.txtLuatThi = new System.Windows.Forms.TextBox();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.lblTroChoi = new System.Windows.Forms.Label();
            this.cmbTroChoi = new System.Windows.Forms.ComboBox();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Controls.Add(this.btnThem);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 290);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(271, 44);
            this.panelBottom.TabIndex = 73;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(190, 15);
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
            this.btnThem.Location = new System.Drawing.Point(109, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblHeThi
            // 
            this.lblHeThi.AutoSize = true;
            this.lblHeThi.Location = new System.Drawing.Point(11, 12);
            this.lblHeThi.Name = "lblHeThi";
            this.lblHeThi.Size = new System.Drawing.Size(35, 13);
            this.lblHeThi.TabIndex = 72;
            this.lblHeThi.Text = "Hệ thi";
            // 
            // cmbHeThi
            // 
            this.cmbHeThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeThi.FormattingEnabled = true;
            this.cmbHeThi.Location = new System.Drawing.Point(11, 28);
            this.cmbHeThi.Name = "cmbHeThi";
            this.cmbHeThi.Size = new System.Drawing.Size(246, 21);
            this.cmbHeThi.TabIndex = 71;
            this.cmbHeThi.SelectedIndexChanged += new System.EventHandler(this.cmbHeThi_SelectedValueChanged);
            // 
            // txtLuatThi
            // 
            this.txtLuatThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLuatThi.Location = new System.Drawing.Point(11, 116);
            this.txtLuatThi.Multiline = true;
            this.txtLuatThi.Name = "txtLuatThi";
            this.txtLuatThi.Size = new System.Drawing.Size(246, 159);
            this.txtLuatThi.TabIndex = 70;
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Location = new System.Drawing.Point(11, 100);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(42, 13);
            this.lblNoiDung.TabIndex = 69;
            this.lblNoiDung.Text = "Luật thi";
            // 
            // lblTroChoi
            // 
            this.lblTroChoi.AutoSize = true;
            this.lblTroChoi.Location = new System.Drawing.Point(11, 55);
            this.lblTroChoi.Name = "lblTroChoi";
            this.lblTroChoi.Size = new System.Drawing.Size(46, 13);
            this.lblTroChoi.TabIndex = 68;
            this.lblTroChoi.Text = "Trò chơi";
            // 
            // cmbTroChoi
            // 
            this.cmbTroChoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTroChoi.FormattingEnabled = true;
            this.cmbTroChoi.Location = new System.Drawing.Point(11, 70);
            this.cmbTroChoi.Name = "cmbTroChoi";
            this.cmbTroChoi.Size = new System.Drawing.Size(246, 21);
            this.cmbTroChoi.TabIndex = 67;
            // 
            // frmInsertCompetitionRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(271, 334);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.lblHeThi);
            this.Controls.Add(this.cmbHeThi);
            this.Controls.Add(this.txtLuatThi);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.lblTroChoi);
            this.Controls.Add(this.cmbTroChoi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInsertCompetitionRules";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmInsertCompetitionRules";
            this.Load += new System.EventHandler(this.frmInsertCompetitionRules_Load);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblHeThi;
        private System.Windows.Forms.ComboBox cmbHeThi;
        private System.Windows.Forms.TextBox txtLuatThi;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.Label lblTroChoi;
        private System.Windows.Forms.ComboBox cmbTroChoi;
    }
}