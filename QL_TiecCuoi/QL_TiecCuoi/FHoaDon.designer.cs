namespace QL_TiecCuoi
{
    partial class FHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvHD = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTT = new System.Windows.Forms.Button();
            this.btnThemhd = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbbMaTiec = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNgaytt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTCR = new System.Windows.Forms.TextBox();
            this.txtTenCD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHD)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 61);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN THANH TOÁN";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtgvHD);
            this.panel2.Location = new System.Drawing.Point(390, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 251);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông tin thanh toán";
            // 
            // dtgvHD
            // 
            this.dtgvHD.AllowUserToAddRows = false;
            this.dtgvHD.AllowUserToDeleteRows = false;
            this.dtgvHD.AllowUserToResizeColumns = false;
            this.dtgvHD.AllowUserToResizeRows = false;
            this.dtgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHD.Location = new System.Drawing.Point(3, 3);
            this.dtgvHD.Name = "dtgvHD";
            this.dtgvHD.Size = new System.Drawing.Size(381, 243);
            this.dtgvHD.TabIndex = 0;
            this.dtgvHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHD_CellClick);
            this.dtgvHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHD_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng tiền:";
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(434, 12);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(194, 20);
            this.txtTT.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtTinhTrang);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtTenCD);
            this.panel3.Controls.Add(this.txtTCR);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtNgaytt);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtNL);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cbbMaTiec);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(12, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 251);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thông tin hóa đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã tiệc cưới:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.btnThemhd);
            this.panel4.Controls.Add(this.btnTT);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtTT);
            this.panel4.Location = new System.Drawing.Point(12, 347);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(767, 48);
            this.panel4.TabIndex = 7;
            // 
            // btnTT
            // 
            this.btnTT.Location = new System.Drawing.Point(643, 9);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(106, 29);
            this.btnTT.TabIndex = 5;
            this.btnTT.Text = "Thanh toán";
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // btnThemhd
            // 
            this.btnThemhd.Location = new System.Drawing.Point(15, 9);
            this.btnThemhd.Name = "btnThemhd";
            this.btnThemhd.Size = new System.Drawing.Size(106, 29);
            this.btnThemhd.TabIndex = 6;
            this.btnThemhd.Text = "Thêm HD";
            this.btnThemhd.UseVisualStyleBackColor = true;
            this.btnThemhd.Click += new System.EventHandler(this.btnThemhd_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(149, 9);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 29);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa HD";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbbMaTiec
            // 
            this.cbbMaTiec.FormattingEnabled = true;
            this.cbbMaTiec.Location = new System.Drawing.Point(99, 10);
            this.cbbMaTiec.Name = "cbbMaTiec";
            this.cbbMaTiec.Size = new System.Drawing.Size(50, 21);
            this.cbbMaTiec.TabIndex = 1;
            this.cbbMaTiec.SelectedIndexChanged += new System.EventHandler(this.cbbMaTiec_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Người lập:";
            // 
            // txtNL
            // 
            this.txtNL.Location = new System.Drawing.Point(99, 58);
            this.txtNL.Name = "txtNL";
            this.txtNL.Size = new System.Drawing.Size(105, 20);
            this.txtNL.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ngày TT:";
            // 
            // txtNgaytt
            // 
            this.txtNgaytt.Enabled = false;
            this.txtNgaytt.Location = new System.Drawing.Point(99, 102);
            this.txtNgaytt.Name = "txtNgaytt";
            this.txtNgaytt.Size = new System.Drawing.Size(105, 20);
            this.txtNgaytt.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tên cô dâu - chú rễ:";
            // 
            // txtTCR
            // 
            this.txtTCR.Enabled = false;
            this.txtTCR.Location = new System.Drawing.Point(68, 177);
            this.txtTCR.Name = "txtTCR";
            this.txtTCR.Size = new System.Drawing.Size(249, 20);
            this.txtTCR.TabIndex = 12;
            // 
            // txtTenCD
            // 
            this.txtTenCD.Enabled = false;
            this.txtTenCD.Location = new System.Drawing.Point(68, 203);
            this.txtTenCD.Name = "txtTenCD";
            this.txtTenCD.Size = new System.Drawing.Size(249, 20);
            this.txtTenCD.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(173, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tình trạng:";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Enabled = false;
            this.txtTinhTrang.Location = new System.Drawing.Point(248, 11);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(105, 20);
            this.txtTinhTrang.TabIndex = 15;
            // 
            // FHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(791, 397);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHD)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbMaTiec;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemhd;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.TextBox txtTenCD;
        private System.Windows.Forms.TextBox txtTCR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNgaytt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label9;
    }
}