namespace QuanLySpa.NhanVien
{
    partial class fThemThongTin
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
            this.cmbTenNV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlRadioButton = new System.Windows.Forms.Panel();
            this.rdbtnCa2 = new System.Windows.Forms.RadioButton();
            this.rdbtnTienMat = new System.Windows.Forms.RadioButton();
            this.rdbtnCertificat = new System.Windows.Forms.RadioButton();
            this.nmdGiamGia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbTenDV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbTienMat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbCertificat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlRadioButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmdGiamGia)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbTenNV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(51, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 43);
            this.panel1.TabIndex = 0;
            // 
            // cmbTenNV
            // 
            this.cmbTenNV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTenNV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTenNV.FormattingEnabled = true;
            this.cmbTenNV.Location = new System.Drawing.Point(113, 11);
            this.cmbTenNV.Name = "cmbTenNV";
            this.cmbTenNV.Size = new System.Drawing.Size(343, 26);
            this.cmbTenNV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người Làm:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlRadioButton);
            this.panel2.Controls.Add(this.nmdGiamGia);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(50, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 46);
            this.panel2.TabIndex = 3;
            // 
            // pnlRadioButton
            // 
            this.pnlRadioButton.Controls.Add(this.rdbtnCa2);
            this.pnlRadioButton.Controls.Add(this.rdbtnTienMat);
            this.pnlRadioButton.Controls.Add(this.rdbtnCertificat);
            this.pnlRadioButton.Location = new System.Drawing.Point(200, 3);
            this.pnlRadioButton.Name = "pnlRadioButton";
            this.pnlRadioButton.Size = new System.Drawing.Size(261, 39);
            this.pnlRadioButton.TabIndex = 3;
            // 
            // rdbtnCa2
            // 
            this.rdbtnCa2.AutoSize = true;
            this.rdbtnCa2.Location = new System.Drawing.Point(202, 8);
            this.rdbtnCa2.Name = "rdbtnCa2";
            this.rdbtnCa2.Size = new System.Drawing.Size(57, 22);
            this.rdbtnCa2.TabIndex = 5;
            this.rdbtnCa2.Text = "Cả 2";
            this.rdbtnCa2.UseVisualStyleBackColor = true;
            // 
            // rdbtnTienMat
            // 
            this.rdbtnTienMat.AutoSize = true;
            this.rdbtnTienMat.Location = new System.Drawing.Point(100, 8);
            this.rdbtnTienMat.Name = "rdbtnTienMat";
            this.rdbtnTienMat.Size = new System.Drawing.Size(83, 22);
            this.rdbtnTienMat.TabIndex = 4;
            this.rdbtnTienMat.Text = "Tiền mặt";
            this.rdbtnTienMat.UseVisualStyleBackColor = true;
            // 
            // rdbtnCertificat
            // 
            this.rdbtnCertificat.AutoSize = true;
            this.rdbtnCertificat.Checked = true;
            this.rdbtnCertificat.Location = new System.Drawing.Point(6, 8);
            this.rdbtnCertificat.Name = "rdbtnCertificat";
            this.rdbtnCertificat.Size = new System.Drawing.Size(84, 22);
            this.rdbtnCertificat.TabIndex = 3;
            this.rdbtnCertificat.TabStop = true;
            this.rdbtnCertificat.Text = "Certificat";
            this.rdbtnCertificat.UseVisualStyleBackColor = true;
            this.rdbtnCertificat.CheckedChanged += new System.EventHandler(this.rdbtnCertificat_CheckedChanged);
            // 
            // nmdGiamGia
            // 
            this.nmdGiamGia.Location = new System.Drawing.Point(113, 12);
            this.nmdGiamGia.Name = "nmdGiamGia";
            this.nmdGiamGia.Size = new System.Drawing.Size(82, 24);
            this.nmdGiamGia.TabIndex = 2;
            this.nmdGiamGia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nmdGiamGia_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giảm giá:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbTenDV);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(51, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 43);
            this.panel3.TabIndex = 1;
            // 
            // cmbTenDV
            // 
            this.cmbTenDV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTenDV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTenDV.FormattingEnabled = true;
            this.cmbTenDV.Location = new System.Drawing.Point(113, 11);
            this.cmbTenDV.Name = "cmbTenDV";
            this.cmbTenDV.Size = new System.Drawing.Size(343, 26);
            this.cmbTenDV.TabIndex = 1;
            this.cmbTenDV.SelectedIndexChanged += new System.EventHandler(this.cmbTenDV_SelectedIndexChanged);
            this.cmbTenDV.SelectedValueChanged += new System.EventHandler(this.cmbTenDV_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên DV:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbTienMat);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(50, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(464, 43);
            this.panel4.TabIndex = 4;
            // 
            // txbTienMat
            // 
            this.txbTienMat.Location = new System.Drawing.Point(113, 10);
            this.txbTienMat.Name = "txbTienMat";
            this.txbTienMat.Size = new System.Drawing.Size(343, 24);
            this.txbTienMat.TabIndex = 1;
            this.txbTienMat.Text = "0";
            this.txbTienMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTienMat_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tiền mặt:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbCertificat);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(50, 207);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(464, 43);
            this.panel5.TabIndex = 5;
            // 
            // txbCertificat
            // 
            this.txbCertificat.Location = new System.Drawing.Point(113, 10);
            this.txbCertificat.Name = "txbCertificat";
            this.txbCertificat.Size = new System.Drawing.Size(343, 24);
            this.txbCertificat.TabIndex = 1;
            this.txbCertificat.Text = "0";
            this.txbCertificat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCertificat_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Certificat:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnDong);
            this.panel6.Controls.Add(this.btnThem);
            this.panel6.Location = new System.Drawing.Point(50, 255);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(464, 77);
            this.panel6.TabIndex = 6;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(362, 14);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(86, 30);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(260, 14);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 30);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // fThemThongTin
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDong;
            this.ClientSize = new System.Drawing.Size(574, 344);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fThemThongTin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập dữ liệu";
            this.Load += new System.EventHandler(this.fThemThongTin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlRadioButton.ResumeLayout(false);
            this.pnlRadioButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmdGiamGia)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbTenNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbtnCa2;
        private System.Windows.Forms.RadioButton rdbtnTienMat;
        private System.Windows.Forms.RadioButton rdbtnCertificat;
        private System.Windows.Forms.NumericUpDown nmdGiamGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbTenDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbTienMat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbCertificat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Panel pnlRadioButton;
    }
}