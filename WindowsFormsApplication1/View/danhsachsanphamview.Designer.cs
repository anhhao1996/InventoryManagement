namespace WindowsFormsApplication1.View
{
    partial class danhsachsanphamview
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
            this.tabControl3 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage11 = new MetroFramework.Controls.MetroTabPage();
            this.danhsachsanphampn = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.button9 = new MetroFramework.Controls.MetroButton();
            this.label29 = new System.Windows.Forms.Label();
            this.danhsachsanphamdgv = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage12 = new MetroFramework.Controls.MetroTabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button27 = new MetroFramework.Controls.MetroButton();
            this.txttenanh = new System.Windows.Forms.TextBox();
            this.danhsachsanphamsuadgv = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.radioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.radioButton4 = new MetroFramework.Controls.MetroRadioButton();
            this.button28 = new MetroFramework.Controls.MetroButton();
            this.cbloai1 = new System.Windows.Forms.ComboBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txttenloai = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtsuatensp = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.txtsuamasp = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl3.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.danhsachsanphampn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsanphamdgv)).BeginInit();
            this.tabPage12.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsanphamsuadgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage11);
            this.tabControl3.Controls.Add(this.tabPage12);
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(928, 531);
            this.tabControl3.TabIndex = 9;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.danhsachsanphampn);
            this.tabPage11.HorizontalScrollbarBarColor = true;
            this.tabPage11.Location = new System.Drawing.Point(4, 35);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(920, 492);
            this.tabPage11.TabIndex = 0;
            this.tabPage11.Text = "Danh sách";
            this.tabPage11.VerticalScrollbarBarColor = true;
            // 
            // danhsachsanphampn
            // 
            this.danhsachsanphampn.BackColor = System.Drawing.Color.Transparent;
            this.danhsachsanphampn.Controls.Add(this.metroLabel1);
            this.danhsachsanphampn.Controls.Add(this.button9);
            this.danhsachsanphampn.Controls.Add(this.label29);
            this.danhsachsanphampn.Controls.Add(this.danhsachsanphamdgv);
            this.danhsachsanphampn.Controls.Add(this.textBox2);
            this.danhsachsanphampn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.danhsachsanphampn.Location = new System.Drawing.Point(0, 0);
            this.danhsachsanphampn.Name = "danhsachsanphampn";
            this.danhsachsanphampn.Size = new System.Drawing.Size(920, 492);
            this.danhsachsanphampn.TabIndex = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Tìm kiếm";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(739, 78);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(95, 23);
            this.button9.TabIndex = 6;
            this.button9.Text = "Lấy danh sách";
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(443, 9);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(391, 37);
            this.label29.TabIndex = 3;
            this.label29.Text = "Xem danh sách sản phẩm";
            // 
            // danhsachsanphamdgv
            // 
            this.danhsachsanphamdgv.AllowUserToAddRows = false;
            this.danhsachsanphamdgv.AllowUserToDeleteRows = false;
            this.danhsachsanphamdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhsachsanphamdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachsanphamdgv.Location = new System.Drawing.Point(31, 116);
            this.danhsachsanphamdgv.Name = "danhsachsanphamdgv";
            this.danhsachsanphamdgv.ReadOnly = true;
            this.danhsachsanphamdgv.RowHeadersVisible = false;
            this.danhsachsanphamdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.danhsachsanphamdgv.Size = new System.Drawing.Size(803, 359);
            this.danhsachsanphamdgv.TabIndex = 0;
            this.danhsachsanphamdgv.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.danhsachsanphamdgv_CellMouseUp);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(682, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.panel8);
            this.tabPage12.HorizontalScrollbarBarColor = true;
            this.tabPage12.Location = new System.Drawing.Point(4, 35);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(920, 492);
            this.tabPage12.TabIndex = 2;
            this.tabPage12.Text = "Sửa sản phẩm";
            this.tabPage12.VerticalScrollbarBarColor = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.button27);
            this.panel8.Controls.Add(this.txttenanh);
            this.panel8.Controls.Add(this.danhsachsanphamsuadgv);
            this.panel8.Controls.Add(this.pictureBox2);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(920, 492);
            this.panel8.TabIndex = 8;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(53, 236);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(75, 23);
            this.button27.TabIndex = 8;
            this.button27.Text = "Chọn ảnh";
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // txttenanh
            // 
            this.txttenanh.Location = new System.Drawing.Point(53, 207);
            this.txttenanh.Name = "txttenanh";
            this.txttenanh.Size = new System.Drawing.Size(114, 20);
            this.txttenanh.TabIndex = 7;
            this.txttenanh.Visible = false;
            // 
            // danhsachsanphamsuadgv
            // 
            this.danhsachsanphamsuadgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhsachsanphamsuadgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachsanphamsuadgv.Location = new System.Drawing.Point(53, 281);
            this.danhsachsanphamsuadgv.Name = "danhsachsanphamsuadgv";
            this.danhsachsanphamsuadgv.ReadOnly = true;
            this.danhsachsanphamsuadgv.RowHeadersVisible = false;
            this.danhsachsanphamsuadgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.danhsachsanphamsuadgv.Size = new System.Drawing.Size(798, 194);
            this.danhsachsanphamsuadgv.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(53, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 150);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.radioButton3);
            this.panel9.Controls.Add(this.radioButton4);
            this.panel9.Controls.Add(this.button28);
            this.panel9.Controls.Add(this.cbloai1);
            this.panel9.Controls.Add(this.label44);
            this.panel9.Controls.Add(this.txttenloai);
            this.panel9.Controls.Add(this.label46);
            this.panel9.Controls.Add(this.txtsuatensp);
            this.panel9.Controls.Add(this.label48);
            this.panel9.Controls.Add(this.txtsuamasp);
            this.panel9.Controls.Add(this.label49);
            this.panel9.Location = new System.Drawing.Point(312, 51);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(512, 208);
            this.panel9.TabIndex = 1;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(296, 153);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 15);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.Text = "Không";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(211, 153);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(38, 15);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Có";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(406, 172);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(75, 23);
            this.button28.TabIndex = 11;
            this.button28.Text = "Sửa";
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // cbloai1
            // 
            this.cbloai1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbloai1.FormattingEnabled = true;
            this.cbloai1.Location = new System.Drawing.Point(360, 117);
            this.cbloai1.Name = "cbloai1";
            this.cbloai1.Size = new System.Drawing.Size(121, 21);
            this.cbloai1.TabIndex = 3;
            this.cbloai1.SelectionChangeCommitted += new System.EventHandler(this.cbloai1_SelectionChangeCommitted);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(3, 155);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(171, 13);
            this.label44.TabIndex = 7;
            this.label44.Text = "Sản phẩm có hạn sử dụng không?";
            // 
            // txttenloai
            // 
            this.txttenloai.Enabled = false;
            this.txttenloai.Location = new System.Drawing.Point(157, 117);
            this.txttenloai.Name = "txttenloai";
            this.txttenloai.Size = new System.Drawing.Size(197, 20);
            this.txttenloai.TabIndex = 10;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(69, 42);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(71, 13);
            this.label46.TabIndex = 4;
            this.label46.Text = "Mã sản phẩm";
            // 
            // txtsuatensp
            // 
            this.txtsuatensp.Location = new System.Drawing.Point(157, 77);
            this.txtsuatensp.Name = "txtsuatensp";
            this.txtsuatensp.Size = new System.Drawing.Size(197, 20);
            this.txtsuatensp.TabIndex = 2;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(64, 120);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(76, 13);
            this.label48.TabIndex = 2;
            this.label48.Text = "Loại sản phẩm";
            // 
            // txtsuamasp
            // 
            this.txtsuamasp.Enabled = false;
            this.txtsuamasp.Location = new System.Drawing.Point(157, 39);
            this.txtsuamasp.Name = "txtsuamasp";
            this.txtsuamasp.Size = new System.Drawing.Size(197, 20);
            this.txtsuamasp.TabIndex = 1;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(65, 80);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(75, 13);
            this.label49.TabIndex = 0;
            this.label49.Text = "Tên sản phẩm";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // danhsachsanphamview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tabControl3);
            this.Name = "danhsachsanphamview";
            this.Size = new System.Drawing.Size(928, 531);
            this.tabControl3.ResumeLayout(false);
            this.tabPage11.ResumeLayout(false);
            this.danhsachsanphampn.ResumeLayout(false);
            this.danhsachsanphampn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsanphamdgv)).EndInit();
            this.tabPage12.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsanphamsuadgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl3;
        private MetroFramework.Controls.MetroTabPage tabPage11;
        private System.Windows.Forms.Panel danhsachsanphampn;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridView danhsachsanphamdgv;
        private System.Windows.Forms.TextBox textBox2;
        private MetroFramework.Controls.MetroTabPage tabPage12;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txttenanh;
        private System.Windows.Forms.DataGridView danhsachsanphamsuadgv;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbloai1;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txttenloai;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtsuatensp;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox txtsuamasp;
        private System.Windows.Forms.Label label49;
        private MetroFramework.Controls.MetroButton button9;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton radioButton3;
        private MetroFramework.Controls.MetroRadioButton radioButton4;
        private MetroFramework.Controls.MetroButton button28;
        private MetroFramework.Controls.MetroButton button27;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}
