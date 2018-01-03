namespace WindowsFormsApplication1.View
{
    partial class danhsachtonkhoview
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
            this.pndanhsachtonkho = new System.Windows.Forms.Panel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txttonggiatri = new System.Windows.Forms.TextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtgiabinhquan = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txttongsoluong = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btntimkiemtheongay = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.danhsachhangtonkhodgv = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pndanhsachtonkho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachhangtonkhodgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pndanhsachtonkho
            // 
            this.pndanhsachtonkho.BackColor = System.Drawing.Color.Transparent;
            this.pndanhsachtonkho.Controls.Add(this.metroLabel7);
            this.pndanhsachtonkho.Controls.Add(this.txttonggiatri);
            this.pndanhsachtonkho.Controls.Add(this.metroLabel6);
            this.pndanhsachtonkho.Controls.Add(this.metroLabel5);
            this.pndanhsachtonkho.Controls.Add(this.txtgiabinhquan);
            this.pndanhsachtonkho.Controls.Add(this.metroLabel3);
            this.pndanhsachtonkho.Controls.Add(this.txttongsoluong);
            this.pndanhsachtonkho.Controls.Add(this.dateTimePicker2);
            this.pndanhsachtonkho.Controls.Add(this.metroLabel4);
            this.pndanhsachtonkho.Controls.Add(this.btntimkiemtheongay);
            this.pndanhsachtonkho.Controls.Add(this.label1);
            this.pndanhsachtonkho.Controls.Add(this.danhsachhangtonkhodgv);
            this.pndanhsachtonkho.Controls.Add(this.textBox4);
            this.pndanhsachtonkho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pndanhsachtonkho.Location = new System.Drawing.Point(0, 0);
            this.pndanhsachtonkho.Name = "pndanhsachtonkho";
            this.pndanhsachtonkho.Size = new System.Drawing.Size(922, 525);
            this.pndanhsachtonkho.TabIndex = 12;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(289, 449);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(77, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Tổng giá trị";
            // 
            // txttonggiatri
            // 
            this.txttonggiatri.Enabled = false;
            this.txttonggiatri.Location = new System.Drawing.Point(383, 449);
            this.txttonggiatri.Name = "txttonggiatri";
            this.txttonggiatri.Size = new System.Drawing.Size(161, 20);
            this.txttonggiatri.TabIndex = 13;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(31, 118);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(200, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Chọn hàng tồn kho cần thống kê";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(550, 449);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(90, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Giá bình quân";
            // 
            // txtgiabinhquan
            // 
            this.txtgiabinhquan.Enabled = false;
            this.txtgiabinhquan.Location = new System.Drawing.Point(646, 449);
            this.txtgiabinhquan.Name = "txtgiabinhquan";
            this.txtgiabinhquan.Size = new System.Drawing.Size(188, 20);
            this.txtgiabinhquan.TabIndex = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(31, 449);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Tổng số lượng";
            // 
            // txttongsoluong
            // 
            this.txttongsoluong.Enabled = false;
            this.txttongsoluong.Location = new System.Drawing.Point(128, 449);
            this.txttongsoluong.Name = "txttongsoluong";
            this.txttongsoluong.Size = new System.Drawing.Size(155, 20);
            this.txttongsoluong.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(491, 81);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(31, 50);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Tìm kiếm";
            // 
            // btntimkiemtheongay
            // 
            this.btntimkiemtheongay.Location = new System.Drawing.Point(719, 78);
            this.btntimkiemtheongay.Name = "btntimkiemtheongay";
            this.btntimkiemtheongay.Size = new System.Drawing.Size(115, 23);
            this.btntimkiemtheongay.TabIndex = 6;
            this.btntimkiemtheongay.Text = "Tìm kiếm theo ngày";
            this.btntimkiemtheongay.Click += new System.EventHandler(this.btntimkiemtheongay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách hàng tồn kho";
            // 
            // danhsachhangtonkhodgv
            // 
            this.danhsachhangtonkhodgv.AllowUserToAddRows = false;
            this.danhsachhangtonkhodgv.AllowUserToDeleteRows = false;
            this.danhsachhangtonkhodgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhsachhangtonkhodgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachhangtonkhodgv.Location = new System.Drawing.Point(31, 140);
            this.danhsachhangtonkhodgv.Name = "danhsachhangtonkhodgv";
            this.danhsachhangtonkhodgv.ReadOnly = true;
            this.danhsachhangtonkhodgv.RowHeadersVisible = false;
            this.danhsachhangtonkhodgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.danhsachhangtonkhodgv.Size = new System.Drawing.Size(803, 289);
            this.danhsachhangtonkhodgv.TabIndex = 0;
            this.danhsachhangtonkhodgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhsachhangtonkhodgv_CellDoubleClick);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(31, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(439, 20);
            this.textBox4.TabIndex = 0;
            this.textBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyUp);
            // 
            // danhsachtonkhoview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pndanhsachtonkho);
            this.Name = "danhsachtonkhoview";
            this.Size = new System.Drawing.Size(922, 525);
            this.pndanhsachtonkho.ResumeLayout(false);
            this.pndanhsachtonkho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachhangtonkhodgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pndanhsachtonkho;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox txtgiabinhquan;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox txttongsoluong;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btntimkiemtheongay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView danhsachhangtonkhodgv;
        private System.Windows.Forms.TextBox textBox4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox txttonggiatri;

    }
}
