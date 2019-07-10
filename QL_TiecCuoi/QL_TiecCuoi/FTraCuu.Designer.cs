namespace QL_TiecCuoi
{
    partial class FTraCuu
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
            this.dtgvTraCuu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTraCuu = new System.Windows.Forms.TextBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cbbTK = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTraCuu
            // 
            this.dtgvTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTraCuu.Location = new System.Drawing.Point(12, 157);
            this.dtgvTraCuu.Name = "dtgvTraCuu";
            this.dtgvTraCuu.Size = new System.Drawing.Size(776, 281);
            this.dtgvTraCuu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tra cứu:";
            // 
            // txtTraCuu
            // 
            this.txtTraCuu.Location = new System.Drawing.Point(257, 38);
            this.txtTraCuu.Name = "txtTraCuu";
            this.txtTraCuu.Size = new System.Drawing.Size(361, 20);
            this.txtTraCuu.TabIndex = 2;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(638, 36);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(75, 23);
            this.btnTraCuu.TabIndex = 3;
            this.btnTraCuu.Text = "Tìm";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(713, 128);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cbbTK
            // 
            this.cbbTK.FormattingEnabled = true;
            this.cbbTK.Items.AddRange(new object[] {
            "Tên chú rễ",
            "Tên cô dâu",
            "Số điện thoại"});
            this.cbbTK.Location = new System.Drawing.Point(68, 38);
            this.cbbTK.Name = "cbbTK";
            this.cbbTK.Size = new System.Drawing.Size(79, 21);
            this.cbbTK.TabIndex = 5;
            // 
            // FTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_TiecCuoi.Properties.Resources.top_nhà_hàng_tiệc_cưới_tốt_tại_tphcm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbTK);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.txtTraCuu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvTraCuu);
            this.Name = "FTraCuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTraCuu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTraCuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTraCuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTraCuu;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cbbTK;
    }
}