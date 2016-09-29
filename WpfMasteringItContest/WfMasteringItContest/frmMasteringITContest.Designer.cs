namespace WfMasteringItContest
{
    partial class frmMasteringITContest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tácVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khốiThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.độiThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tròChoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cauHoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luatThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmSốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelCHhinhSua = new System.Windows.Forms.Label();
            this.lblXemTheoDanhSach = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.tácVụToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tácVụToolStripMenuItem
            // 
            this.tácVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khốiThiToolStripMenuItem,
            this.độiThiToolStripMenuItem,
            this.tròChoiToolStripMenuItem,
            this.cauHoiToolStripMenuItem,
            this.luatThiToolStripMenuItem,
            this.điểmSốToolStripMenuItem});
            this.tácVụToolStripMenuItem.Name = "tácVụToolStripMenuItem";
            this.tácVụToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.tácVụToolStripMenuItem.Text = "Tác Vụ";
            // 
            // khốiThiToolStripMenuItem
            // 
            this.khốiThiToolStripMenuItem.Name = "khốiThiToolStripMenuItem";
            this.khốiThiToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.khốiThiToolStripMenuItem.Text = "Khối Thi";
            this.khốiThiToolStripMenuItem.Click += new System.EventHandler(this.khoiThiToolStripMenuItem_Click);
            // 
            // độiThiToolStripMenuItem
            // 
            this.độiThiToolStripMenuItem.Name = "độiThiToolStripMenuItem";
            this.độiThiToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.độiThiToolStripMenuItem.Text = "Đội Thi";
            this.độiThiToolStripMenuItem.Click += new System.EventHandler(this.doiThiToolStripMenuItem_Click);
            // 
            // tròChoiToolStripMenuItem
            // 
            this.tròChoiToolStripMenuItem.Name = "tròChoiToolStripMenuItem";
            this.tròChoiToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.tròChoiToolStripMenuItem.Text = "Trò Chơi";
            this.tròChoiToolStripMenuItem.Click += new System.EventHandler(this.troChoiToolStripMenuItem_Click);
            // 
            // cauHoiToolStripMenuItem
            // 
            this.cauHoiToolStripMenuItem.Name = "cauHoiToolStripMenuItem";
            this.cauHoiToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.cauHoiToolStripMenuItem.Text = "Câu Hỏi";
            this.cauHoiToolStripMenuItem.Click += new System.EventHandler(this.cauHoiToolStripMenuItem_Click);
            // 
            // luatThiToolStripMenuItem
            // 
            this.luatThiToolStripMenuItem.Name = "luatThiToolStripMenuItem";
            this.luatThiToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.luatThiToolStripMenuItem.Text = "Luật Thi";
            this.luatThiToolStripMenuItem.Click += new System.EventHandler(this.luatThiStripMenuItem_Click);
            // 
            // điểmSốToolStripMenuItem
            // 
            this.điểmSốToolStripMenuItem.Name = "điểmSốToolStripMenuItem";
            this.điểmSốToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.điểmSốToolStripMenuItem.Text = "Điểm Số";
            this.điểmSốToolStripMenuItem.Click += new System.EventHandler(this.diemSoToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelCHhinhSua);
            this.panelTop.Controls.Add(this.lblXemTheoDanhSach);
            this.panelTop.Controls.Add(this.cmbSearch);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 24);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(632, 39);
            this.panelTop.TabIndex = 8;
            // 
            // labelCHhinhSua
            // 
            this.labelCHhinhSua.AutoSize = true;
            this.labelCHhinhSua.Location = new System.Drawing.Point(3, 13);
            this.labelCHhinhSua.Name = "labelCHhinhSua";
            this.labelCHhinhSua.Size = new System.Drawing.Size(307, 13);
            this.labelCHhinhSua.TabIndex = 2;
            this.labelCHhinhSua.Text = "Chỉnh sửa trực tiếp vào trong data gridview sau đó nhấn nút lưu";
            // 
            // lblXemTheoDanhSach
            // 
            this.lblXemTheoDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblXemTheoDanhSach.AutoSize = true;
            this.lblXemTheoDanhSach.Location = new System.Drawing.Point(283, 13);
            this.lblXemTheoDanhSach.Name = "lblXemTheoDanhSach";
            this.lblXemTheoDanhSach.Size = new System.Drawing.Size(105, 13);
            this.lblXemTheoDanhSach.TabIndex = 1;
            this.lblXemTheoDanhSach.Text = "Xem theo danh sách";
            // 
            // cmbSearch
            // 
            this.cmbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Khối Thi",
            "Đội Thi",
            "Trò Chơi",
            "Câu Hỏi",
            "Điểm Số"});
            this.cmbSearch.Location = new System.Drawing.Point(407, 10);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(224, 21);
            this.cmbSearch.TabIndex = 0;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.Controls.Add(this.btnCancel);
            this.panelBottom.Controls.Add(this.btnSaveChange);
            this.panelBottom.Controls.Add(this.btnDelete);
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 332);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(632, 44);
            this.panelBottom.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(168, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnSaveChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSaveChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChange.Location = new System.Drawing.Point(87, 16);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChange.TabIndex = 3;
            this.btnSaveChange.Text = "Lưu";
            this.btnSaveChange.UseVisualStyleBackColor = true;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(6, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(551, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 63);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(632, 269);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // frmMasteringITContest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 376);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStrip);
            this.Name = "frmMasteringITContest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMasteringITContest";
            this.Load += new System.EventHandler(this.frmMasteringITContest_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tácVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khốiThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem độiThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tròChoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cauHoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luatThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điểmSốToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelCHhinhSua;
        private System.Windows.Forms.Label lblXemTheoDanhSach;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

