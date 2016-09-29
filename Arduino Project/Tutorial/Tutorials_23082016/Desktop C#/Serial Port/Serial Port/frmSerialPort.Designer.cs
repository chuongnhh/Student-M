namespace Serial_Port
{
    partial class frmSerialPort
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
            this.components = new System.ComponentModel.Container();
            this.cboSerialPort = new System.Windows.Forms.ComboBox();
            this.btnSerialPort = new System.Windows.Forms.Button();
            this.rtbRecieved = new System.Windows.Forms.RichTextBox();
            this.txtTransmit = new System.Windows.Forms.TextBox();
            this.btnTransmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // cboSerialPort
            // 
            this.cboSerialPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSerialPort.FormattingEnabled = true;
            this.cboSerialPort.Location = new System.Drawing.Point(13, 11);
            this.cboSerialPort.Name = "cboSerialPort";
            this.cboSerialPort.Size = new System.Drawing.Size(145, 21);
            this.cboSerialPort.TabIndex = 0;
            // 
            // btnSerialPort
            // 
            this.btnSerialPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerialPort.Location = new System.Drawing.Point(164, 10);
            this.btnSerialPort.Name = "btnSerialPort";
            this.btnSerialPort.Size = new System.Drawing.Size(75, 23);
            this.btnSerialPort.TabIndex = 1;
            this.btnSerialPort.Text = "Connect";
            this.btnSerialPort.UseVisualStyleBackColor = true;
            this.btnSerialPort.Click += new System.EventHandler(this.btnSerialPort_Click);
            // 
            // rtbRecieved
            // 
            this.rtbRecieved.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbRecieved.Location = new System.Drawing.Point(13, 39);
            this.rtbRecieved.Name = "rtbRecieved";
            this.rtbRecieved.Size = new System.Drawing.Size(226, 268);
            this.rtbRecieved.TabIndex = 2;
            this.rtbRecieved.Text = "";
            // 
            // txtTransmit
            // 
            this.txtTransmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTransmit.Location = new System.Drawing.Point(12, 314);
            this.txtTransmit.Name = "txtTransmit";
            this.txtTransmit.Size = new System.Drawing.Size(196, 20);
            this.txtTransmit.TabIndex = 3;
            this.txtTransmit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTransmit_KeyDown);
            // 
            // btnTransmit
            // 
            this.btnTransmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransmit.AutoSize = true;
            this.btnTransmit.Location = new System.Drawing.Point(209, 312);
            this.btnTransmit.Name = "btnTransmit";
            this.btnTransmit.Size = new System.Drawing.Size(29, 23);
            this.btnTransmit.TabIndex = 4;
            this.btnTransmit.Text = ">>";
            this.btnTransmit.UseVisualStyleBackColor = true;
            this.btnTransmit.Click += new System.EventHandler(this.btnTransmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(164, 340);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // frmSerialPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 375);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTransmit);
            this.Controls.Add(this.txtTransmit);
            this.Controls.Add(this.rtbRecieved);
            this.Controls.Add(this.btnSerialPort);
            this.Controls.Add(this.cboSerialPort);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSerialPort";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Port";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSerialPort;
        private System.Windows.Forms.Button btnSerialPort;
        private System.Windows.Forms.RichTextBox rtbRecieved;
        private System.Windows.Forms.TextBox txtTransmit;
        private System.Windows.Forms.Button btnTransmit;
        private System.Windows.Forms.Button btnClose;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

