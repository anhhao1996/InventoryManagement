namespace WindowsFormsApplication1.View
{
    partial class chartview
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnloadbieudo = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lbltonggianhaphomqua = new MetroFramework.Controls.MetroLabel();
            this.lbltonggiaxuathomqua = new MetroFramework.Controls.MetroLabel();
            this.lbltonggianhaphomnay = new MetroFramework.Controls.MetroLabel();
            this.lbltonggiaxuathomnay = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 112);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tổng giá nhập";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Tổng giá xuất";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(769, 373);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnloadbieudo
            // 
            this.btnloadbieudo.Location = new System.Drawing.Point(3, 83);
            this.btnloadbieudo.Name = "btnloadbieudo";
            this.btnloadbieudo.Size = new System.Drawing.Size(115, 23);
            this.btnloadbieudo.TabIndex = 7;
            this.btnloadbieudo.Text = "Vẽ biểu đồ cột";
            this.btnloadbieudo.Click += new System.EventHandler(this.btnloadbieudo_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(171, 83);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(115, 23);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Vẽ biểu đồ đường";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(334, 83);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(115, 23);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "Vẽ biểu đồ tròn";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(128, 133);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(416, 315);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "chart2";
            this.chart2.Visible = false;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(503, 83);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(218, 23);
            this.metroButton3.TabIndex = 11;
            this.metroButton3.Text = "Thống kê hôm qua và hôm nay";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 57);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Chọn năm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbltonggiaxuathomnay);
            this.panel1.Controls.Add(this.lbltonggianhaphomnay);
            this.panel1.Controls.Add(this.lbltonggiaxuathomqua);
            this.panel1.Controls.Add(this.lbltonggianhaphomqua);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Location = new System.Drawing.Point(43, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 340);
            this.panel1.TabIndex = 15;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(61, 261);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(160, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Tổng giá trị xuất hôm nay";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(61, 191);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(165, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Tổng giá trị nhập hôm nay";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(61, 55);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(167, 19);
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "Tổng giá trị nhập hôm qua";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(61, 119);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(162, 19);
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Tổng giá trị xuất hôm qua";
            // 
            // lbltonggianhaphomqua
            // 
            this.lbltonggianhaphomqua.AutoSize = true;
            this.lbltonggianhaphomqua.Location = new System.Drawing.Point(276, 55);
            this.lbltonggianhaphomqua.Name = "lbltonggianhaphomqua";
            this.lbltonggianhaphomqua.Size = new System.Drawing.Size(16, 19);
            this.lbltonggianhaphomqua.TabIndex = 19;
            this.lbltonggianhaphomqua.Text = "0";
            // 
            // lbltonggiaxuathomqua
            // 
            this.lbltonggiaxuathomqua.AutoSize = true;
            this.lbltonggiaxuathomqua.Location = new System.Drawing.Point(276, 119);
            this.lbltonggiaxuathomqua.Name = "lbltonggiaxuathomqua";
            this.lbltonggiaxuathomqua.Size = new System.Drawing.Size(16, 19);
            this.lbltonggiaxuathomqua.TabIndex = 20;
            this.lbltonggiaxuathomqua.Text = "0";
            // 
            // lbltonggianhaphomnay
            // 
            this.lbltonggianhaphomnay.AutoSize = true;
            this.lbltonggianhaphomnay.Location = new System.Drawing.Point(276, 191);
            this.lbltonggianhaphomnay.Name = "lbltonggianhaphomnay";
            this.lbltonggianhaphomnay.Size = new System.Drawing.Size(16, 19);
            this.lbltonggianhaphomnay.TabIndex = 21;
            this.lbltonggianhaphomnay.Text = "0";
            // 
            // lbltonggiaxuathomnay
            // 
            this.lbltonggiaxuathomnay.AutoSize = true;
            this.lbltonggiaxuathomnay.Location = new System.Drawing.Point(276, 261);
            this.lbltonggiaxuathomnay.Name = "lbltonggiaxuathomnay";
            this.lbltonggiaxuathomnay.Size = new System.Drawing.Size(16, 19);
            this.lbltonggiaxuathomnay.TabIndex = 22;
            this.lbltonggiaxuathomnay.Text = "0";
            // 
            // chartview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnloadbieudo);
            this.Controls.Add(this.chart1);
            this.Name = "chartview";
            this.Size = new System.Drawing.Size(900, 509);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroButton btnloadbieudo;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel lbltonggiaxuathomnay;
        private MetroFramework.Controls.MetroLabel lbltonggianhaphomnay;
        private MetroFramework.Controls.MetroLabel lbltonggiaxuathomqua;
        private MetroFramework.Controls.MetroLabel lbltonggianhaphomqua;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}
