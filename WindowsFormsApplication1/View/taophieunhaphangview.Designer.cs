namespace WindowsFormsApplication1.View
{
    partial class taophieunhaphangview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taodonnhap = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.manhacungcapcb = new System.Windows.Forms.ComboBox();
            this.mancctxt = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.manvtxt = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.nhapchitietdon = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.danhsachsanpham1dgv = new System.Windows.Forms.DataGridView();
            this.button23 = new MetroFramework.Controls.MetroButton();
            this.button22 = new MetroFramework.Controls.MetroButton();
            this.luutonkhobtn = new MetroFramework.Controls.MetroButton();
            this.button4 = new MetroFramework.Controls.MetroButton();
            this.label39 = new System.Windows.Forms.Label();
            this.dongianhaptxt = new System.Windows.Forms.TextBox();
            this.ngayhethan = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.masplbl = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.madonnhaplbl = new System.Windows.Forms.Label();
            this.soluongnhap = new System.Windows.Forms.NumericUpDown();
            this.thongtindonnhapdgv = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.taodonnhap.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhapchitietdon)).BeginInit();
            this.nhapchitietdon.Panel1.SuspendLayout();
            this.nhapchitietdon.Panel2.SuspendLayout();
            this.nhapchitietdon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsanpham1dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluongnhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtindonnhapdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // taodonnhap
            // 
            this.taodonnhap.Controls.Add(this.panel6);
            this.taodonnhap.Controls.Add(this.label10);
            this.taodonnhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taodonnhap.Location = new System.Drawing.Point(0, 0);
            this.taodonnhap.Name = "taodonnhap";
            this.taodonnhap.Size = new System.Drawing.Size(927, 580);
            this.taodonnhap.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Location = new System.Drawing.Point(0, 61);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(924, 516);
            this.panel6.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.manhacungcapcb);
            this.panel1.Controls.Add(this.mancctxt);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.manvtxt);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 516);
            this.panel1.TabIndex = 10;
            // 
            // manhacungcapcb
            // 
            this.manhacungcapcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manhacungcapcb.FormattingEnabled = true;
            this.manhacungcapcb.Location = new System.Drawing.Point(584, 117);
            this.manhacungcapcb.Name = "manhacungcapcb";
            this.manhacungcapcb.Size = new System.Drawing.Size(149, 21);
            this.manhacungcapcb.TabIndex = 1;
            this.manhacungcapcb.SelectionChangeCommitted += new System.EventHandler(this.manhacungcapcb_SelectionChangeCommitted);
            // 
            // mancctxt
            // 
            this.mancctxt.Enabled = false;
            this.mancctxt.Location = new System.Drawing.Point(378, 118);
            this.mancctxt.Name = "mancctxt";
            this.mancctxt.Size = new System.Drawing.Size(182, 20);
            this.mancctxt.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(267, 121);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(91, 13);
            this.label24.TabIndex = 10;
            this.label24.Text = "Mã nhà cung cấp";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(380, 183);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lưu và tiếp tục";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(278, 186);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(80, 13);
            this.label31.TabIndex = 2;
            this.label31.Text = "Ngày nhập kho";
            // 
            // manvtxt
            // 
            this.manvtxt.Enabled = false;
            this.manvtxt.Location = new System.Drawing.Point(378, 149);
            this.manvtxt.Name = "manvtxt";
            this.manvtxt.Size = new System.Drawing.Size(182, 20);
            this.manvtxt.TabIndex = 2;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(286, 153);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(72, 13);
            this.label32.TabIndex = 0;
            this.label32.Text = "Mã nhân viên";
            // 
            // nhapchitietdon
            // 
            this.nhapchitietdon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhapchitietdon.Location = new System.Drawing.Point(0, 0);
            this.nhapchitietdon.Name = "nhapchitietdon";
            // 
            // nhapchitietdon.Panel1
            // 
            this.nhapchitietdon.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.nhapchitietdon.Panel1.Controls.Add(this.label4);
            this.nhapchitietdon.Panel1.Controls.Add(this.textBox3);
            this.nhapchitietdon.Panel1.Controls.Add(this.danhsachsanpham1dgv);
            // 
            // nhapchitietdon.Panel2
            // 
            this.nhapchitietdon.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.nhapchitietdon.Panel2.Controls.Add(this.button23);
            this.nhapchitietdon.Panel2.Controls.Add(this.button22);
            this.nhapchitietdon.Panel2.Controls.Add(this.luutonkhobtn);
            this.nhapchitietdon.Panel2.Controls.Add(this.button4);
            this.nhapchitietdon.Panel2.Controls.Add(this.label39);
            this.nhapchitietdon.Panel2.Controls.Add(this.dongianhaptxt);
            this.nhapchitietdon.Panel2.Controls.Add(this.ngayhethan);
            this.nhapchitietdon.Panel2.Controls.Add(this.label26);
            this.nhapchitietdon.Panel2.Controls.Add(this.masplbl);
            this.nhapchitietdon.Panel2.Controls.Add(this.label25);
            this.nhapchitietdon.Panel2.Controls.Add(this.madonnhaplbl);
            this.nhapchitietdon.Panel2.Controls.Add(this.soluongnhap);
            this.nhapchitietdon.Panel2.Controls.Add(this.thongtindonnhapdgv);
            this.nhapchitietdon.Panel2.Controls.Add(this.label7);
            this.nhapchitietdon.Panel2.Controls.Add(this.label11);
            this.nhapchitietdon.Size = new System.Drawing.Size(927, 580);
            this.nhapchitietdon.SplitterDistance = 352;
            this.nhapchitietdon.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chọn sản phẩm nhập về";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(322, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // danhsachsanpham1dgv
            // 
            this.danhsachsanpham1dgv.AllowUserToAddRows = false;
            this.danhsachsanpham1dgv.AllowUserToDeleteRows = false;
            this.danhsachsanpham1dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachsanpham1dgv.Location = new System.Drawing.Point(15, 76);
            this.danhsachsanpham1dgv.Name = "danhsachsanpham1dgv";
            this.danhsachsanpham1dgv.ReadOnly = true;
            this.danhsachsanpham1dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.danhsachsanpham1dgv.Size = new System.Drawing.Size(322, 424);
            this.danhsachsanpham1dgv.TabIndex = 0;
            this.danhsachsanpham1dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhsachsanpham1dgv_CellClick);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(453, 198);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(99, 23);
            this.button23.TabIndex = 26;
            this.button23.Text = "Hoàn tất";
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(304, 198);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(99, 23);
            this.button22.TabIndex = 25;
            this.button22.Text = "Sửa";
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // luutonkhobtn
            // 
            this.luutonkhobtn.Location = new System.Drawing.Point(166, 198);
            this.luutonkhobtn.Name = "luutonkhobtn";
            this.luutonkhobtn.Size = new System.Drawing.Size(101, 23);
            this.luutonkhobtn.TabIndex = 24;
            this.luutonkhobtn.Text = "Thêm";
            this.luutonkhobtn.Click += new System.EventHandler(this.luutonkhobtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Lấy dữ liệu";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(32, 169);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(86, 13);
            this.label39.TabIndex = 18;
            this.label39.Text = "Đơn giá nhập về";
            // 
            // dongianhaptxt
            // 
            this.dongianhaptxt.Location = new System.Drawing.Point(148, 166);
            this.dongianhaptxt.Name = "dongianhaptxt";
            this.dongianhaptxt.Size = new System.Drawing.Size(130, 20);
            this.dongianhaptxt.TabIndex = 17;
            this.dongianhaptxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dongianhaptxt_KeyPress);
            // 
            // ngayhethan
            // 
            this.ngayhethan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayhethan.Location = new System.Drawing.Point(355, 70);
            this.ngayhethan.Name = "ngayhethan";
            this.ngayhethan.Size = new System.Drawing.Size(114, 20);
            this.ngayhethan.TabIndex = 16;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(278, 76);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 13);
            this.label26.TabIndex = 15;
            this.label26.Text = "Ngày hết hạn";
            // 
            // masplbl
            // 
            this.masplbl.AutoSize = true;
            this.masplbl.Location = new System.Drawing.Point(152, 76);
            this.masplbl.Name = "masplbl";
            this.masplbl.Size = new System.Drawing.Size(71, 13);
            this.masplbl.TabIndex = 14;
            this.masplbl.Text = "Mã sản phẩm";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(47, 76);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 13);
            this.label25.TabIndex = 13;
            this.label25.Text = "Mã sản phẩm";
            // 
            // madonnhaplbl
            // 
            this.madonnhaplbl.AutoSize = true;
            this.madonnhaplbl.Location = new System.Drawing.Point(152, 31);
            this.madonnhaplbl.Name = "madonnhaplbl";
            this.madonnhaplbl.Size = new System.Drawing.Size(44, 13);
            this.madonnhaplbl.TabIndex = 11;
            this.madonnhaplbl.Text = "Mã đơn";
            // 
            // soluongnhap
            // 
            this.soluongnhap.Location = new System.Drawing.Point(148, 119);
            this.soluongnhap.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.soluongnhap.Name = "soluongnhap";
            this.soluongnhap.Size = new System.Drawing.Size(130, 20);
            this.soluongnhap.TabIndex = 10;
            // 
            // thongtindonnhapdgv
            // 
            this.thongtindonnhapdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thongtindonnhapdgv.Location = new System.Drawing.Point(23, 244);
            this.thongtindonnhapdgv.Name = "thongtindonnhapdgv";
            this.thongtindonnhapdgv.ReadOnly = true;
            this.thongtindonnhapdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.thongtindonnhapdgv.Size = new System.Drawing.Size(529, 256);
            this.thongtindonnhapdgv.TabIndex = 9;
            this.thongtindonnhapdgv.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.thongtindonnhapdgv_CellMouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số lượng nhập";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(279, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(569, 37);
            this.label10.TabIndex = 2;
            this.label10.Text = "Quản lí nhập kho - Thông tin đơn nhập";
            // 
            // taophieunhaphangview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.nhapchitietdon);
            this.Controls.Add(this.taodonnhap);
            this.Name = "taophieunhaphangview";
            this.Size = new System.Drawing.Size(927, 580);
            this.taodonnhap.ResumeLayout(false);
            this.taodonnhap.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.nhapchitietdon.Panel1.ResumeLayout(false);
            this.nhapchitietdon.Panel1.PerformLayout();
            this.nhapchitietdon.Panel2.ResumeLayout(false);
            this.nhapchitietdon.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhapchitietdon)).EndInit();
            this.nhapchitietdon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsanpham1dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluongnhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtindonnhapdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel taodonnhap;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.SplitContainer nhapchitietdon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView danhsachsanpham1dgv;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox dongianhaptxt;
        private System.Windows.Forms.DateTimePicker ngayhethan;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label masplbl;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label madonnhaplbl;
        private System.Windows.Forms.NumericUpDown soluongnhap;
        private System.Windows.Forms.DataGridView thongtindonnhapdgv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox manhacungcapcb;
        private System.Windows.Forms.TextBox mancctxt;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox manvtxt;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroButton button23;
        private MetroFramework.Controls.MetroButton button22;
        private MetroFramework.Controls.MetroButton luutonkhobtn;
        private MetroFramework.Controls.MetroButton button4;
    }
}
