namespace WfMasteringItContest
{
    partial class frmInsertExamSystem
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
            this.txtTenKhoiThi = new System.Windows.Forms.TextBox();
            this.lblTenKhoiThi = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenKhoiThi
            // 
            this.txtTenKhoiThi.Location = new System.Drawing.Point(24, 61);
            this.txtTenKhoiThi.Name = "txtTenKhoiThi";
            this.txtTenKhoiThi.Size = new System.Drawing.Size(201, 20);
            this.txtTenKhoiThi.TabIndex = 12;
            // 
            // lblTenKhoiThi
            // 
            this.lblTenKhoiThi.AutoSize = true;
            this.lblTenKhoiThi.Location = new System.Drawing.Point(24, 45);
            this.lblTenKhoiThi.Name = "lblTenKhoiThi";
            this.lblTenKhoiThi.Size = new System.Drawing.Size(63, 13);
            this.lblTenKhoiThi.TabIndex = 11;
            this.lblTenKhoiThi.Text = "Tên khối thi";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.Controls.Add(this.btnThem);
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 178);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(246, 44);
            this.panelBottom.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(85, 16);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 18;
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
            this.btnClose.Location = new System.Drawing.Point(165, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmInsertExamSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(246, 222);
            this.Controls.Add(this.txtTenKhoiThi);
            this.Controls.Add(this.lblTenKhoiThi);
            this.Controls.Add(this.panelBottom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInsertExamSystem";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmInsertExamSystem";
            this.Load += new System.EventHandler(this.frmInsertExamSystem_Load);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenKhoiThi;
        private System.Windows.Forms.Label lblTenKhoiThi;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnClose;
    }
}