namespace WindowsFormsApplication1.View
{
    partial class xuatkhoview
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button16 = new MetroFramework.Controls.MetroButton();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.danhsachtonkho1dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblmanv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button19 = new MetroFramework.Controls.MetroButton();
            this.button18 = new MetroFramework.Controls.MetroButton();
            this.button15 = new MetroFramework.Controls.MetroButton();
            this.button14 = new MetroFramework.Controls.MetroButton();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label43 = new System.Windows.Forms.Label();
            this.matonkholbl = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.xuatdgv = new System.Windows.Forms.DataGridView();
            this.label47 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachtonkho1dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuatdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Panel1.Controls.Add(this.button16);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.textBox4);
            this.splitContainer2.Panel1.Controls.Add(this.danhsachtonkho1dgv);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Panel2.Controls.Add(this.lblmanv);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.button19);
            this.splitContainer2.Panel2.Controls.Add(this.button18);
            this.splitContainer2.Panel2.Controls.Add(this.button15);
            this.splitContainer2.Panel2.Controls.Add(this.button14);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.textBox5);
            this.splitContainer2.Panel2.Controls.Add(this.dateTimePicker2);
            this.splitContainer2.Panel2.Controls.Add(this.label43);
            this.splitContainer2.Panel2.Controls.Add(this.matonkholbl);
            this.splitContainer2.Panel2.Controls.Add(this.label45);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDown1);
            this.splitContainer2.Panel2.Controls.Add(this.xuatdgv);
            this.splitContainer2.Panel2.Controls.Add(this.label47);
            this.splitContainer2.Size = new System.Drawing.Size(1000, 570);
            this.splitContainer2.SplitterDistance = 370;
            this.splitContainer2.TabIndex = 11;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(276, 76);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 4;
            this.button16.Text = "Lấy dữ liệu";
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Chọn sản phẩm tồn kho cần xuất";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(15, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(336, 20);
            this.textBox4.TabIndex = 1;
            this.textBox4.Click += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // danhsachtonkho1dgv
            // 
            this.danhsachtonkho1dgv.AllowUserToAddRows = false;
            this.danhsachtonkho1dgv.AllowUserToDeleteRows = false;
            this.danhsachtonkho1dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachtonkho1dgv.Location = new System.Drawing.Point(15, 119);
            this.danhsachtonkho1dgv.Name = "danhsachtonkho1dgv";
            this.danhsachtonkho1dgv.ReadOnly = true;
            this.danhsachtonkho1dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.danhsachtonkho1dgv.Size = new System.Drawing.Size(336, 432);
            this.danhsachtonkho1dgv.TabIndex = 0;
            this.danhsachtonkho1dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhsachtonkho1dgv_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm sản phẩm xuất kho ( theo STT và Mã tồn kho )";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.Location = new System.Drawing.Point(152, 41);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(72, 13);
            this.lblmanv.TabIndex = 24;
            this.lblmanv.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã nhân viên";
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(317, 203);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(115, 23);
            this.button19.TabIndex = 22;
            this.button19.Text = "Hoàn Tất";
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button18
            // 
            this.button18.Enabled = false;
            this.button18.Location = new System.Drawing.Point(175, 203);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(125, 23);
            this.button18.TabIndex = 21;
            this.button18.Text = "Sửa";
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(27, 203);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(128, 23);
            this.button15.TabIndex = 20;
            this.button15.Text = "Thêm";
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(451, 203);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(137, 23);
            this.button14.TabIndex = 19;
            this.button14.Text = "Lấy dữ liệu";
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Đơn giá xuất";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(148, 166);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(130, 20);
            this.textBox5.TabIndex = 2;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(355, 70);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(114, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(285, 76);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(55, 13);
            this.label43.TabIndex = 15;
            this.label43.Text = "Ngày xuất";
            // 
            // matonkholbl
            // 
            this.matonkholbl.AutoSize = true;
            this.matonkholbl.Location = new System.Drawing.Point(152, 76);
            this.matonkholbl.Name = "matonkholbl";
            this.matonkholbl.Size = new System.Drawing.Size(13, 13);
            this.matonkholbl.TabIndex = 14;
            this.matonkholbl.Text = "0";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(47, 76);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(61, 13);
            this.label45.TabIndex = 13;
            this.label45.Text = "Mã tồn kho";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(148, 119);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(130, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // xuatdgv
            // 
            this.xuatdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xuatdgv.Location = new System.Drawing.Point(27, 232);
            this.xuatdgv.Name = "xuatdgv";
            this.xuatdgv.ReadOnly = true;
            this.xuatdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.xuatdgv.Size = new System.Drawing.Size(561, 319);
            this.xuatdgv.TabIndex = 9;
            this.xuatdgv.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.xuatdgv_CellMouseClick);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(36, 119);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(72, 13);
            this.label47.TabIndex = 2;
            this.label47.Text = "Số lượng xuất";
            // 
            // xuatkhoview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.splitContainer2);
            this.Name = "xuatkhoview";
            this.Size = new System.Drawing.Size(1000, 570);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhsachtonkho1dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuatdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MetroFramework.Controls.MetroButton button16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView danhsachtonkho1dgv;
        private MetroFramework.Controls.MetroButton button19;
        private MetroFramework.Controls.MetroButton button18;
        private MetroFramework.Controls.MetroButton button15;
        private MetroFramework.Controls.MetroButton button14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label matonkholbl;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView xuatdgv;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
