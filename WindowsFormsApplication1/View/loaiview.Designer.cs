namespace WindowsFormsApplication1.View
{
    partial class loaiview
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
            this.loaipn = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.button17 = new MetroFramework.Controls.MetroButton();
            this.button2 = new MetroFramework.Controls.MetroButton();
            this.button12 = new MetroFramework.Controls.MetroButton();
            this.loaidgv = new System.Windows.Forms.DataGridView();
            this.maloailbl = new System.Windows.Forms.Label();
            this.tenloaitxt = new System.Windows.Forms.TextBox();
            this.maloaitxt = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.loaipn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaidgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // loaipn
            // 
            this.loaipn.BackColor = System.Drawing.Color.Transparent;
            this.loaipn.Controls.Add(this.metroLabel2);
            this.loaipn.Controls.Add(this.metroLabel1);
            this.loaipn.Controls.Add(this.button17);
            this.loaipn.Controls.Add(this.button2);
            this.loaipn.Controls.Add(this.button12);
            this.loaipn.Controls.Add(this.loaidgv);
            this.loaipn.Controls.Add(this.maloailbl);
            this.loaipn.Controls.Add(this.tenloaitxt);
            this.loaipn.Controls.Add(this.maloaitxt);
            this.loaipn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loaipn.Location = new System.Drawing.Point(0, 0);
            this.loaipn.Name = "loaipn";
            this.loaipn.Size = new System.Drawing.Size(846, 512);
            this.loaipn.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(265, 124);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Tên loại";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(265, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Mã loại";
            // 
            // button17
            // 
            this.button17.Enabled = false;
            this.button17.Location = new System.Drawing.Point(498, 192);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(102, 23);
            this.button17.TabIndex = 12;
            this.button17.Text = "Sửa";
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Thêm";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(252, 192);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(102, 23);
            this.button12.TabIndex = 10;
            this.button12.Text = "Lấy dữ liệu";
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // loaidgv
            // 
            this.loaidgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loaidgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loaidgv.Location = new System.Drawing.Point(252, 243);
            this.loaidgv.Name = "loaidgv";
            this.loaidgv.ReadOnly = true;
            this.loaidgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loaidgv.Size = new System.Drawing.Size(362, 224);
            this.loaidgv.TabIndex = 6;
            this.loaidgv.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.loaidgv_CellMouseUp);
            // 
            // maloailbl
            // 
            this.maloailbl.AutoSize = true;
            this.maloailbl.Location = new System.Drawing.Point(333, 78);
            this.maloailbl.Name = "maloailbl";
            this.maloailbl.Size = new System.Drawing.Size(22, 13);
            this.maloailbl.TabIndex = 8;
            this.maloailbl.Text = "Mã";
            // 
            // tenloaitxt
            // 
            this.tenloaitxt.Location = new System.Drawing.Point(336, 123);
            this.tenloaitxt.Name = "tenloaitxt";
            this.tenloaitxt.Size = new System.Drawing.Size(237, 20);
            this.tenloaitxt.TabIndex = 1;
            // 
            // maloaitxt
            // 
            this.maloaitxt.Location = new System.Drawing.Point(336, 74);
            this.maloaitxt.Name = "maloaitxt";
            this.maloaitxt.Size = new System.Drawing.Size(237, 20);
            this.maloaitxt.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // loaiview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.loaipn);
            this.Name = "loaiview";
            this.Size = new System.Drawing.Size(846, 512);
            this.loaipn.ResumeLayout(false);
            this.loaipn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaidgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loaipn;
        private System.Windows.Forms.DataGridView loaidgv;
        private System.Windows.Forms.Label maloailbl;
        private System.Windows.Forms.TextBox tenloaitxt;
        private System.Windows.Forms.TextBox maloaitxt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton button17;
        private MetroFramework.Controls.MetroButton button2;
        private MetroFramework.Controls.MetroButton button12;
    }
}
