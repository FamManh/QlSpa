namespace QuanLySpa.NhanVien
{
    partial class fXoaThang
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbTenBang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuyThang = new System.Windows.Forms.Button();
            this.btnXoaThang = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbTenBang);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(24, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 43);
            this.panel3.TabIndex = 5;
            // 
            // txbTenBang
            // 
            this.txbTenBang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbTenBang.Location = new System.Drawing.Point(95, 8);
            this.txbTenBang.Name = "txbTenBang";
            this.txbTenBang.Size = new System.Drawing.Size(280, 24);
            this.txbTenBang.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Bảng:";
            // 
            // btnHuyThang
            // 
            this.btnHuyThang.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHuyThang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuyThang.FlatAppearance.BorderSize = 0;
            this.btnHuyThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyThang.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThang.ForeColor = System.Drawing.Color.White;
            this.btnHuyThang.Location = new System.Drawing.Point(295, 95);
            this.btnHuyThang.Name = "btnHuyThang";
            this.btnHuyThang.Size = new System.Drawing.Size(88, 29);
            this.btnHuyThang.TabIndex = 7;
            this.btnHuyThang.Text = "Hủy";
            this.btnHuyThang.UseVisualStyleBackColor = false;
            this.btnHuyThang.Click += new System.EventHandler(this.btnHuyThang_Click);
            // 
            // btnXoaThang
            // 
            this.btnXoaThang.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXoaThang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaThang.FlatAppearance.BorderSize = 0;
            this.btnXoaThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaThang.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThang.ForeColor = System.Drawing.Color.White;
            this.btnXoaThang.Location = new System.Drawing.Point(172, 95);
            this.btnXoaThang.Name = "btnXoaThang";
            this.btnXoaThang.Size = new System.Drawing.Size(88, 29);
            this.btnXoaThang.TabIndex = 6;
            this.btnXoaThang.Text = "Xóa";
            this.btnXoaThang.UseVisualStyleBackColor = false;
            this.btnXoaThang.Click += new System.EventHandler(this.btnXoaThang_Click);
            // 
            // fXoaThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 152);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnHuyThang);
            this.Controls.Add(this.btnXoaThang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fXoaThang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xóa tháng";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txbTenBang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHuyThang;
        private System.Windows.Forms.Button btnXoaThang;
    }
}