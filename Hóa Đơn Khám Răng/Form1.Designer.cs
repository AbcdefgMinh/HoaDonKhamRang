
namespace Hóa_Đơn_Khám_Răng
{
    partial class Form1
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
            this.lblNhaKhoa = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblDichVu = new System.Windows.Forms.Label();
            this.lblTramRang = new System.Windows.Forms.Label();
            this.lblCaoVoi = new System.Windows.Forms.Label();
            this.lblNhoRang = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbTramRang = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNhaKhoa
            // 
            this.lblNhaKhoa.AutoSize = true;
            this.lblNhaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaKhoa.Location = new System.Drawing.Point(243, 9);
            this.lblNhaKhoa.Name = "lblNhaKhoa";
            this.lblNhaKhoa.Size = new System.Drawing.Size(298, 31);
            this.lblNhaKhoa.TabIndex = 0;
            this.lblNhaKhoa.Text = "TÍNH TIỀN NHA KHOA";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(74, 100);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(79, 22);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "HỌ TÊN";
            this.lblHoTen.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDichVu
            // 
            this.lblDichVu.AutoSize = true;
            this.lblDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDichVu.Location = new System.Drawing.Point(73, 164);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(168, 26);
            this.lblDichVu.TabIndex = 0;
            this.lblDichVu.Text = "Dịch vụ sử dụng";
            this.lblDichVu.Click += new System.EventHandler(this.lblDichVu_Click);
            // 
            // lblTramRang
            // 
            this.lblTramRang.AutoSize = true;
            this.lblTramRang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTramRang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramRang.Location = new System.Drawing.Point(74, 221);
            this.lblTramRang.Name = "lblTramRang";
            this.lblTramRang.Size = new System.Drawing.Size(93, 22);
            this.lblTramRang.TabIndex = 0;
            this.lblTramRang.Text = "Trám răng";
            this.lblTramRang.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblCaoVoi
            // 
            this.lblCaoVoi.AutoSize = true;
            this.lblCaoVoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaoVoi.Location = new System.Drawing.Point(74, 274);
            this.lblCaoVoi.Name = "lblCaoVoi";
            this.lblCaoVoi.Size = new System.Drawing.Size(71, 22);
            this.lblCaoVoi.TabIndex = 0;
            this.lblCaoVoi.Text = "Cạo vôi";
            // 
            // lblNhoRang
            // 
            this.lblNhoRang.AutoSize = true;
            this.lblNhoRang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhoRang.Location = new System.Drawing.Point(74, 327);
            this.lblNhoRang.Name = "lblNhoRang";
            this.lblNhoRang.Size = new System.Drawing.Size(84, 22);
            this.lblNhoRang.TabIndex = 0;
            this.lblNhoRang.Text = "Nhổ răng";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(75, 392);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(102, 25);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(203, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 32);
            this.textBox1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(213, 330);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // cbTramRang
            // 
            this.cbTramRang.AutoSize = true;
            this.cbTramRang.Location = new System.Drawing.Point(213, 226);
            this.cbTramRang.Name = "cbTramRang";
            this.cbTramRang.Size = new System.Drawing.Size(80, 17);
            this.cbTramRang.TabIndex = 3;
            this.cbTramRang.Text = "checkBox1";
            this.cbTramRang.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(213, 273);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "checkBox1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.cbTramRang);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblNhoRang);
            this.Controls.Add(this.lblCaoVoi);
            this.Controls.Add(this.lblTramRang);
            this.Controls.Add(this.lblDichVu);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblNhaKhoa);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhaKhoa;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblDichVu;
        private System.Windows.Forms.Label lblTramRang;
        private System.Windows.Forms.Label lblCaoVoi;
        private System.Windows.Forms.Label lblNhoRang;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox cbTramRang;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

