using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1.View
{
    public partial class chartview : UserControl
    {
        public chartview()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true; 
        }

        private void btnloadbieudo_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            panel1.Visible = false;
            chart2.Visible = false;
            chart1.Series["Tổng giá nhập"].ChartType = SeriesChartType.Column;
            chart1.Series["Tổng giá xuất"].ChartType = SeriesChartType.Column;
            loaddulieulenchart();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart2.Visible = false;
            panel1.Visible = false;
            chart1.Series["Tổng giá nhập"].ChartType = SeriesChartType.Line;
            chart1.Series["Tổng giá xuất"].ChartType = SeriesChartType.Line;
            loaddulieulenchart();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            panel1.Visible = false;
            chart2.Visible = true;
            clear();
            loaddulieulenpie();
            
        }

        public void loaddulieulenchart()
        {
            tonkhobus bus = new tonkhobus();
            xuatkhobus bus1 = new xuatkhobus();


            Axis XA = chart1.ChartAreas[0].AxisX;

            List<DateTime> dates = new List<DateTime>();
            for (int i = 1; i <= 12; i++)
                dates.Add(new DateTime(dateTimePicker1.Value.Date.Year, i, 1));

            chart1.Series["Tổng giá nhập"].XValueType = ChartValueType.Date;
            chart1.Series["Tổng giá xuất"].XValueType = ChartValueType.Date;


            XA.MajorGrid.Enabled = false;         // no gridlines
            XA.LabelStyle.Format = "MMM";         // show months as names

            XA.IntervalType = DateTimeIntervalType.Months;  // show axis labels.. 
            XA.Interval = 1;

            int y = 1;
            int year = dateTimePicker1.Value.Date.Year;
            foreach (DateTime d in dates)
            {
                chart1.Series["Tổng giá nhập"].Points.AddXY(d, bus.tonggianhaptheothang(y, year));
                chart1.Series["Tổng giá xuất"].Points.AddXY(d, bus1.tonggiaxuattheothang(y, year));
                y++;
            }
            if (y == 12) y = 1;
        }
        public void loaddulieulenpie()
        {
            tonkhobus bus = new tonkhobus();
            xuatkhobus bus1 = new xuatkhobus();
            DateTime dt = DateTime.Now;
            chart2.Series[0].Points.AddXY("Tổng giá nhập", bus.tonggianhaptheonam(dateTimePicker1.Value.Date.Year));
            decimal? a = bus1.tonggiaxuattheonam(dt.Year);
            chart2.Series[0].Points.AddXY("Tổng giá xuất", bus1.tonggiaxuattheonam(dateTimePicker1.Value.Date.Year));
        }

        public void clear()
        {
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            chart1.Visible = false;
            chart2.Visible = false;
            tonkhobus bus = new tonkhobus();
            xuatkhobus bus1 = new xuatkhobus();
            DateTime dt = DateTime.Now;
            lbltonggianhaphomnay.Text = bus.tonggianhaptheongay(dt.Date).ToString();
            lbltonggiaxuathomnay.Text = bus1.tonggiaxuattheongay(dt.Date).ToString();
            lbltonggianhaphomqua.Text = bus.tonggianhaptheongay(dt.AddDays(-1).Date).ToString();
            lbltonggiaxuathomqua.Text = bus1.tonggiaxuattheongay(dt.AddDays(-1).Date).ToString();
        }

    }
}
