namespace QuanLySpa.NhanVien
{
    partial class QLDichVu
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvDV = new System.Windows.Forms.DataGridView();
            this.clMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThoiGianDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTimDV = new System.Windows.Forms.Button();
            this.txbTimKiemDV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbThoiGianDV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbGiaDV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbDongYDV = new System.Windows.Forms.Label();
            this.btnCancelDV = new System.Windows.Forms.Button();
            this.btnOkDV = new System.Windows.Forms.Button();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.btnSuaDV = new System.Windows.Forms.Button();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbTenDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbMaDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDV)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvDV);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Location = new System.Drawing.Point(386, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(623, 486);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin ";
            // 
            // dtgvDV
            // 
            this.dtgvDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaDV,
            this.clTenDV,
            this.clThoiGianDV,
            this.clGiaDV});
            this.dtgvDV.Location = new System.Drawing.Point(8, 86);
            this.dtgvDV.Name = "dtgvDV";
            this.dtgvDV.Size = new System.Drawing.Size(602, 393);
            this.dtgvDV.TabIndex = 1;
            this.dtgvDV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDV_RowEnter);
            // 
            // clMaDV
            // 
            this.clMaDV.DataPropertyName = "MaDV";
            this.clMaDV.HeaderText = "Mã DV";
            this.clMaDV.Name = "clMaDV";
            // 
            // clTenDV
            // 
            this.clTenDV.DataPropertyName = "TenDV";
            this.clTenDV.HeaderText = "Tên DV";
            this.clTenDV.Name = "clTenDV";
            // 
            // clThoiGianDV
            // 
            this.clThoiGianDV.DataPropertyName = "ThoiGianDV";
            this.clThoiGianDV.HeaderText = "Thời gian";
            this.clThoiGianDV.Name = "clThoiGianDV";
            // 
            // clGiaDV
            // 
            this.clGiaDV.DataPropertyName = "GiaDV";
            this.clGiaDV.HeaderText = "Giá DV";
            this.clGiaDV.Name = "clGiaDV";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnTimDV);
            this.panel4.Controls.Add(this.txbTimKiemDV);
            this.panel4.Location = new System.Drawing.Point(8, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(602, 54);
            this.panel4.TabIndex = 0;
            // 
            // btnTimDV
            // 
            this.btnTimDV.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTimDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimDV.FlatAppearance.BorderSize = 0;
            this.btnTimDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimDV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimDV.ForeColor = System.Drawing.Color.White;
            this.btnTimDV.Location = new System.Drawing.Point(492, 13);
            this.btnTimDV.Name = "btnTimDV";
            this.btnTimDV.Size = new System.Drawing.Size(86, 30);
            this.btnTimDV.TabIndex = 4;
            this.btnTimDV.Text = "Search";
            this.btnTimDV.UseVisualStyleBackColor = false;
            this.btnTimDV.Click += new System.EventHandler(this.btnTimDV_Click);
            // 
            // txbTimKiemDV
            // 
            this.txbTimKiemDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimKiemDV.Location = new System.Drawing.Point(144, 16);
            this.txbTimKiemDV.Name = "txbTimKiemDV";
            this.txbTimKiemDV.Size = new System.Drawing.Size(309, 26);
            this.txbTimKiemDV.TabIndex = 3;
            this.txbTimKiemDV.TextChanged += new System.EventHandler(this.txbTimKiemDV_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(365, 486);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbThoiGianDV);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(8, 166);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(350, 40);
            this.panel6.TabIndex = 3;
            // 
            // txbThoiGianDV
            // 
            this.txbThoiGianDV.Location = new System.Drawing.Point(95, 7);
            this.txbThoiGianDV.Name = "txbThoiGianDV";
            this.txbThoiGianDV.Size = new System.Drawing.Size(252, 24);
            this.txbThoiGianDV.TabIndex = 1;
            this.txbThoiGianDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbThoiGianDV_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thời Gian:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbGiaDV);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(8, 219);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(350, 40);
            this.panel5.TabIndex = 4;
            // 
            // txbGiaDV
            // 
            this.txbGiaDV.Location = new System.Drawing.Point(95, 7);
            this.txbGiaDV.Name = "txbGiaDV";
            this.txbGiaDV.Size = new System.Drawing.Size(252, 24);
            this.txbGiaDV.TabIndex = 1;
            this.txbGiaDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbGiaDV_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá DV:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbDongYDV);
            this.panel3.Controls.Add(this.btnCancelDV);
            this.panel3.Controls.Add(this.btnOkDV);
            this.panel3.Controls.Add(this.btnXoaDV);
            this.panel3.Controls.Add(this.btnSuaDV);
            this.panel3.Controls.Add(this.btnThemDV);
            this.panel3.Location = new System.Drawing.Point(8, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 104);
            this.panel3.TabIndex = 3;
            // 
            // lbDongYDV
            // 
            this.lbDongYDV.AutoSize = true;
            this.lbDongYDV.Location = new System.Drawing.Point(92, 8);
            this.lbDongYDV.Name = "lbDongYDV";
            this.lbDongYDV.Size = new System.Drawing.Size(224, 18);
            this.lbDongYDV.TabIndex = 6;
            this.lbDongYDV.Text = "Bạn có chắc chắn muốn thay đổi";
            // 
            // btnCancelDV
            // 
            this.btnCancelDV.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancelDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelDV.FlatAppearance.BorderSize = 0;
            this.btnCancelDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelDV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDV.ForeColor = System.Drawing.Color.White;
            this.btnCancelDV.Location = new System.Drawing.Point(207, 37);
            this.btnCancelDV.Name = "btnCancelDV";
            this.btnCancelDV.Size = new System.Drawing.Size(86, 30);
            this.btnCancelDV.TabIndex = 5;
            this.btnCancelDV.Text = "Không";
            this.btnCancelDV.UseVisualStyleBackColor = false;
            this.btnCancelDV.Click += new System.EventHandler(this.btnCancelDV_Click);
            // 
            // btnOkDV
            // 
            this.btnOkDV.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnOkDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOkDV.FlatAppearance.BorderSize = 0;
            this.btnOkDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkDV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkDV.ForeColor = System.Drawing.Color.White;
            this.btnOkDV.Location = new System.Drawing.Point(103, 37);
            this.btnOkDV.Name = "btnOkDV";
            this.btnOkDV.Size = new System.Drawing.Size(86, 30);
            this.btnOkDV.TabIndex = 4;
            this.btnOkDV.Text = "Có";
            this.btnOkDV.UseVisualStyleBackColor = false;
            this.btnOkDV.Click += new System.EventHandler(this.btnOkDV_Click);
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXoaDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaDV.FlatAppearance.BorderSize = 0;
            this.btnXoaDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDV.ForeColor = System.Drawing.Color.White;
            this.btnXoaDV.Location = new System.Drawing.Point(264, 3);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(86, 30);
            this.btnXoaDV.TabIndex = 3;
            this.btnXoaDV.Text = "Delete";
            this.btnXoaDV.UseVisualStyleBackColor = false;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSuaDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSuaDV.FlatAppearance.BorderSize = 0;
            this.btnSuaDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaDV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDV.ForeColor = System.Drawing.Color.White;
            this.btnSuaDV.Location = new System.Drawing.Point(159, 3);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(86, 30);
            this.btnSuaDV.TabIndex = 2;
            this.btnSuaDV.Text = "Edit";
            this.btnSuaDV.UseVisualStyleBackColor = false;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // btnThemDV
            // 
            this.btnThemDV.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThemDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemDV.FlatAppearance.BorderSize = 0;
            this.btnThemDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDV.ForeColor = System.Drawing.Color.White;
            this.btnThemDV.Location = new System.Drawing.Point(57, 3);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(86, 30);
            this.btnThemDV.TabIndex = 1;
            this.btnThemDV.Text = "Add";
            this.btnThemDV.UseVisualStyleBackColor = false;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbTenDV);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(8, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 40);
            this.panel2.TabIndex = 2;
            // 
            // txbTenDV
            // 
            this.txbTenDV.Location = new System.Drawing.Point(95, 7);
            this.txbTenDV.Name = "txbTenDV";
            this.txbTenDV.Size = new System.Drawing.Size(252, 24);
            this.txbTenDV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên DV:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbMaDV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 0;
            // 
            // txbMaDV
            // 
            this.txbMaDV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbMaDV.Location = new System.Drawing.Point(95, 7);
            this.txbMaDV.Name = "txbMaDV";
            this.txbMaDV.Size = new System.Drawing.Size(252, 24);
            this.txbMaDV.TabIndex = 1;
            this.txbMaDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMaDV_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã DV:";
            // 
            // QLDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý dịch vụ";
            this.Load += new System.EventHandler(this.QLDichVu_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDV)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvDV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnTimDV;
        private System.Windows.Forms.TextBox txbTimKiemDV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbGiaDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbDongYDV;
        private System.Windows.Forms.Button btnCancelDV;
        private System.Windows.Forms.Button btnOkDV;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.Button btnSuaDV;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbTenDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbMaDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThoiGianDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaDV;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbThoiGianDV;
        private System.Windows.Forms.Label label4;
    }
}