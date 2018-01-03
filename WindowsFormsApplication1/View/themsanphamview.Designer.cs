namespace WindowsFormsApplication1
{
    partial class themsanphamview
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
            this.themsanpham = new System.Windows.Forms.Panel();
            this.chonanh = new MetroFramework.Controls.MetroButton();
            this.danhsachsanphamnhapdgv = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.radioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.luusanpham = new MetroFramework.Controls.MetroButton();
            this.maloaicb = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.loaisptxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tensanphamtxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.masanphamtxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.themsanpham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsanphamnhapdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // themsanpham
            // 
            this.themsanpham.BackColor = System.Drawing.Color.Transparent;
            this.themsanpham.Controls.Add(this.chonanh);
            this.themsanpham.Controls.Add(this.danhsachsanphamnhapdgv);
            this.themsanpham.Controls.Add(this.pictureBox1);
            this.themsanpham.Controls.Add(this.panel5);
            this.themsanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themsanpham.Location = new System.Drawing.Point(0, 0);
            this.themsanpham.Name = "themsanpham";
            this.themsanpham.Size = new System.Drawing.Size(949, 520);
            this.themsanpham.TabIndex = 8;
            // 
            // chonanh
            // 
            this.chonanh.Location = new System.Drawing.Point(85, 270);
            this.chonanh.Name = "chonanh";
            this.chonanh.Size = new System.Drawing.Size(133, 23);
            this.chonanh.TabIndex = 7;
            this.chonanh.Text = "Chọn ảnh";
            this.chonanh.Click += new System.EventHandler(this.button9_Click);
            // 
            // danhsachsanphamnhapdgv
            // 
            this.danhsachsanphamnhapdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhsachsanphamnhapdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachsanphamnhapdgv.Location = new System.Drawing.Point(15, 314);
            this.danhsachsanphamnhapdgv.Name = "danhsachsanphamnhapdgv";
            this.danhsachsanphamnhapdgv.ReadOnly = true;
            this.danhsachsanphamnhapdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.danhsachsanphamnhapdgv.Size = new System.Drawing.Size(931, 203);
            this.danhsachsanphamnhapdgv.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(71, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 168);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radioButton2);
            this.panel5.Controls.Add(this.radioButton1);
            this.panel5.Controls.Add(this.luusanpham);
            this.panel5.Controls.Add(this.maloaicb);
            this.panel5.Controls.Add(this.label27);
            this.panel5.Controls.Add(this.loaisptxt);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.tensanphamtxt);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.masanphamtxt);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Location = new System.Drawing.Point(394, 88);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(522, 220);
            this.panel5.TabIndex = 1;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(296, 155);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 15);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Không";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(199, 155);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(38, 15);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Có";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // luusanpham
            // 
            this.luusanpham.Location = new System.Drawing.Point(406, 182);
            this.luusanpham.Name = "luusanpham";
            this.luusanpham.Size = new System.Drawing.Size(75, 23);
            this.luusanpham.TabIndex = 11;
            this.luusanpham.Text = "Lưu";
            this.luusanpham.Click += new System.EventHandler(this.luusanpham_Click);
            // 
            // maloaicb
            // 
            this.maloaicb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maloaicb.FormattingEnabled = true;
            this.maloaicb.Location = new System.Drawing.Point(360, 117);
            this.maloaicb.Name = "maloaicb";
            this.maloaicb.Size = new System.Drawing.Size(121, 21);
            this.maloaicb.TabIndex = 3;
            this.maloaicb.SelectionChangeCommitted += new System.EventHandler(this.maloaicb_SelectionChangeCommitted);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 155);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(171, 13);
            this.label27.TabIndex = 7;
            this.label27.Text = "Sản phẩm có hạn sử dụng không?";
            // 
            // loaisptxt
            // 
            this.loaisptxt.Enabled = false;
            this.loaisptxt.Location = new System.Drawing.Point(157, 117);
            this.loaisptxt.Name = "loaisptxt";
            this.loaisptxt.Size = new System.Drawing.Size(197, 20);
            this.loaisptxt.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(69, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Mã sản phẩm";
            // 
            // tensanphamtxt
            // 
            this.tensanphamtxt.Location = new System.Drawing.Point(157, 77);
            this.tensanphamtxt.Name = "tensanphamtxt";
            this.tensanphamtxt.Size = new System.Drawing.Size(197, 20);
            this.tensanphamtxt.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(64, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Loại sản phẩm";
            // 
            // masanphamtxt
            // 
            this.masanphamtxt.Location = new System.Drawing.Point(157, 39);
            this.masanphamtxt.Name = "masanphamtxt";
            this.masanphamtxt.Size = new System.Drawing.Size(197, 20);
            this.masanphamtxt.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(65, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Tên sản phẩm";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // themsanphamview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.themsanpham);
            this.Name = "themsanphamview";
            this.Size = new System.Drawing.Size(949, 520);
            this.themsanpham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsanphamnhapdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel themsanpham;
        private System.Windows.Forms.DataGridView danhsachsanphamnhapdgv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox maloaicb;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox loaisptxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tensanphamtxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox masanphamtxt;
        private System.Windows.Forms.Label label15;
        private MetroFramework.Controls.MetroRadioButton radioButton2;
        private MetroFramework.Controls.MetroRadioButton radioButton1;
        private MetroFramework.Controls.MetroButton luusanpham;
        private MetroFramework.Controls.MetroButton chonanh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
