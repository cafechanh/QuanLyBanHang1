namespace QuanLyBanHang.GUI
{
    partial class frm_thongke
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
            this.dgv_thongke = new System.Windows.Forms.DataGridView();
            this.dt_timesau = new System.Windows.Forms.DateTimePicker();
            this.btn_load = new System.Windows.Forms.Button();
            this.dt_timetruoc = new System.Windows.Forms.DateTimePicker();
            this.btnTimTheoKhoangtg = new System.Windows.Forms.Button();
            this.txt_tong = new System.Windows.Forms.TextBox();
            this.btn_tinhtong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_thongke
            // 
            this.dgv_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongke.Location = new System.Drawing.Point(12, 207);
            this.dgv_thongke.Name = "dgv_thongke";
            this.dgv_thongke.Size = new System.Drawing.Size(602, 206);
            this.dgv_thongke.TabIndex = 96;
            // 
            // dt_timesau
            // 
            this.dt_timesau.CustomFormat = "MM/dd/yyyy";
            this.dt_timesau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_timesau.Location = new System.Drawing.Point(179, 26);
            this.dt_timesau.Name = "dt_timesau";
            this.dt_timesau.Size = new System.Drawing.Size(149, 27);
            this.dt_timesau.TabIndex = 85;
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Transparent;
            this.btn_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_load.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Image = global::QuanLyBanHang.Properties.Resources.Find;
            this.btn_load.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_load.Location = new System.Drawing.Point(179, 64);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(149, 48);
            this.btn_load.TabIndex = 86;
            this.btn_load.Text = "Tìm tất cả hóa đơn";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // dt_timetruoc
            // 
            this.dt_timetruoc.CustomFormat = "MM/dd/yyyy";
            this.dt_timetruoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_timetruoc.Location = new System.Drawing.Point(6, 26);
            this.dt_timetruoc.Name = "dt_timetruoc";
            this.dt_timetruoc.Size = new System.Drawing.Size(139, 27);
            this.dt_timetruoc.TabIndex = 84;
            // 
            // btnTimTheoKhoangtg
            // 
            this.btnTimTheoKhoangtg.BackColor = System.Drawing.Color.Transparent;
            this.btnTimTheoKhoangtg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimTheoKhoangtg.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTheoKhoangtg.Image = global::QuanLyBanHang.Properties.Resources.Find;
            this.btnTimTheoKhoangtg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimTheoKhoangtg.Location = new System.Drawing.Point(0, 63);
            this.btnTimTheoKhoangtg.Name = "btnTimTheoKhoangtg";
            this.btnTimTheoKhoangtg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnTimTheoKhoangtg.Size = new System.Drawing.Size(145, 48);
            this.btnTimTheoKhoangtg.TabIndex = 4;
            this.btnTimTheoKhoangtg.Text = "Tìm";
            this.btnTimTheoKhoangtg.UseVisualStyleBackColor = false;
            this.btnTimTheoKhoangtg.Click += new System.EventHandler(this.btnTimTheoKhoangtg_Click);
            // 
            // txt_tong
            // 
            this.txt_tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tong.Location = new System.Drawing.Point(405, 143);
            this.txt_tong.Name = "txt_tong";
            this.txt_tong.Size = new System.Drawing.Size(165, 27);
            this.txt_tong.TabIndex = 100;
            // 
            // btn_tinhtong
            // 
            this.btn_tinhtong.BackColor = System.Drawing.Color.Transparent;
            this.btn_tinhtong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tinhtong.Location = new System.Drawing.Point(425, 84);
            this.btn_tinhtong.Name = "btn_tinhtong";
            this.btn_tinhtong.Size = new System.Drawing.Size(136, 33);
            this.btn_tinhtong.TabIndex = 99;
            this.btn_tinhtong.Text = "Tính tổng";
            this.btn_tinhtong.UseVisualStyleBackColor = false;
            this.btn_tinhtong.Click += new System.EventHandler(this.btn_tinhtong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(151, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 36);
            this.label2.TabIndex = 98;
            this.label2.Text = "BÁO CÁO THỐNG KÊ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dt_timesau);
            this.groupBox3.Controls.Add(this.btn_load);
            this.groupBox3.Controls.Add(this.dt_timetruoc);
            this.groupBox3.Controls.Add(this.btnTimTheoKhoangtg);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 120);
            this.groupBox3.TabIndex = 97;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm theo thời gian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(570, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 101;
            this.label1.Text = "VNĐ";
            // 
            // frm_thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_thongke);
            this.Controls.Add(this.txt_tong);
            this.Controls.Add(this.btn_tinhtong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Name = "frm_thongke";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_thongke;
        private System.Windows.Forms.DateTimePicker dt_timesau;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.DateTimePicker dt_timetruoc;
        private System.Windows.Forms.Button btnTimTheoKhoangtg;
        private System.Windows.Forms.TextBox txt_tong;
        private System.Windows.Forms.Button btn_tinhtong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
    }
}