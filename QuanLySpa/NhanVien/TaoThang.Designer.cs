namespace QuanLySpa.NhanVien
{
    partial class fTaoThang
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
            this.btnTaoThang = new System.Windows.Forms.Button();
            this.btnHuyThang = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbTenBang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTaoThang
            // 
            this.btnTaoThang.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTaoThang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTaoThang.FlatAppearance.BorderSize = 0;
            this.btnTaoThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoThang.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoThang.ForeColor = System.Drawing.Color.White;
            this.btnTaoThang.Location = new System.Drawing.Point(180, 97);
            this.btnTaoThang.Name = "btnTaoThang";
            this.btnTaoThang.Size = new System.Drawing.Size(88, 29);
            this.btnTaoThang.TabIndex = 3;
            this.btnTaoThang.Text = "Tạo";
            this.btnTaoThang.UseVisualStyleBackColor = false;
            this.btnTaoThang.Click += new System.EventHandler(this.btnTaoThang_Click);
            // 
            // btnHuyThang
            // 
            this.btnHuyThang.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHuyThang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuyThang.FlatAppearance.BorderSize = 0;
            this.btnHuyThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyThang.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThang.ForeColor = System.Drawing.Color.White;
            this.btnHuyThang.Location = new System.Drawing.Point(303, 97);
            this.btnHuyThang.Name = "btnHuyThang";
            this.btnHuyThang.Size = new System.Drawing.Size(88, 29);
            this.btnHuyThang.TabIndex = 4;
            this.btnHuyThang.Text = "Hủy";
            this.btnHuyThang.UseVisualStyleBackColor = false;
            this.btnHuyThang.Click += new System.EventHandler(this.btnHuyThang_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbTenBang);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(32, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 43);
            this.panel3.TabIndex = 0;
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
            // fTaoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(439, 152);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnHuyThang);
            this.Controls.Add(this.btnTaoThang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTaoThang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo tháng mới";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTaoThang;
        private System.Windows.Forms.Button btnHuyThang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txbTenBang;
    }
}