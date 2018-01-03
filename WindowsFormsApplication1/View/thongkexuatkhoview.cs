using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using System.Threading;

namespace WindowsFormsApplication1.View
{
    public partial class thongkexuatkhoview : UserControl
    {
        public thongkexuatkhoview()
        {
            InitializeComponent();
        }
        //tìm theo mã tồn kho và mã xuất kho
        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                xuatkhobus bus = new xuatkhobus();
                danhsachxuatkhodgv.DataSource = bus.timkiem(textBox4.Text);
            }
        }
        //hàm thống kê
        public void tinhthongketheoky(TextBox txt)
        {
            decimal tonggiaxuat = 0;
            int soluongxuat = 0;
            foreach (DataGridViewRow row in danhsachthongketheokidgv.Rows)
            {
                soluongxuat = Convert.ToInt32(row.Cells["SOLUONGXUAT"].Value);
                Decimal giaxuat = Convert.ToDecimal(row.Cells["DONGIAXUAT"].Value);
                tonggiaxuat += giaxuat * soluongxuat;
            }
            txt.Text = tonggiaxuat.ToString();
        }
        public void tinhthongketheosp(TextBox txt,TextBox txt1)
        {
            decimal tonggiaxuat = 0;
            int soluongxuat = 0;
            int tongsoluongxuat = 0;
            foreach (DataGridViewRow row in danhsachxuatkhodgv.Rows)
            {
                soluongxuat = Convert.ToInt32(row.Cells["SOLUONGXUAT"].Value);
                Decimal giaxuat = Convert.ToDecimal(row.Cells["DONGIAXUAT"].Value);
                tongsoluongxuat += soluongxuat;
                tonggiaxuat += giaxuat * soluongxuat;
            }
            txt.Text = tongsoluongxuat.ToString();
            txt1.Text = tonggiaxuat.ToString();
        }
        //tìm kiếm theo ngày
        private void btntimkiemtheongay_Click(object sender, EventArgs e)
        {
            xuatkhobus bus = new xuatkhobus();
            int ngay = dateTimePicker2.Value.Date.Day;
            int thang = dateTimePicker2.Value.Date.Month;
            int nam = dateTimePicker2.Value.Date.Year;
            var checkedbutton = pnthongkexuatkho.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedbutton == null)//nếu không chọn radio button
            {
                danhsachxuatkhodgv.DataSource = bus.timkiemtheongay(dateTimePicker2.Value.Date);
                
            }
            else// nếu chọn radio button
            {
                if (checkedbutton.Text.Equals("Ngày"))
                {
                    danhsachxuatkhodgv.DataSource = bus.timkiemtheodieukien(ngay, checkedbutton.Text);
                    
                }
                else
                {
                    if (checkedbutton.Text.Equals("Tháng"))
                    {
                        danhsachxuatkhodgv.DataSource = bus.timkiemtheodieukien(thang, checkedbutton.Text);
                        
                    }
                    else
                    {
                        danhsachxuatkhodgv.DataSource = bus.timkiemtheodieukien(nam, checkedbutton.Text);
                    }
                }
            }
        }
        //nút thống kê theo kì
        private void metroButton2_Click(object sender, EventArgs e)
        {
            xuatkhobus bus = new xuatkhobus();
            danhsachthongketheokidgv.DataSource = bus.thongketheongay(dateTimePicker1.Value, dateTimePicker3.Value);
            tinhthongketheoky(textBox1);
        }

        //nút thống kê theo sản phẩm trong kì
        private void metroButton1_Click(object sender, EventArgs e)
        {
            xuatkhobus bus = new xuatkhobus();
            danhsachxuatkhodgv.DataSource = bus.timkiem1(textBox4.Text, dateTimePicker2.Value, dateTimePicker4.Value);
            tinhthongketheosp(txttongsoluong, txttonggiaxuat);
        }

        public void BindAutoCompleteList()
        {
            AutoCompleteStringCollection acDataSource = new AutoCompleteStringCollection();
            xuatkhobus bus = new xuatkhobus();
            acDataSource.AddRange(bus.findsanpham().ToArray());
            
            textBox4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox4.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox4.AutoCompleteCustomSource = acDataSource;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (danhsachxuatkhodgv.Rows.Count > 0)
            {
                common.xuatexcel(danhsachxuatkhodgv);
                danhsachxuatkhodgv.CurrentCell = danhsachxuatkhodgv.Rows[0].Cells[0];
            }
            else MessageBox.Show("Không có dữ liệu");
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (danhsachthongketheokidgv.Rows.Count > 0)
            {
                common.xuatexcel(danhsachthongketheokidgv);
                danhsachthongketheokidgv.CurrentCell = danhsachthongketheokidgv.Rows[0].Cells[0];
            }
            else MessageBox.Show("Không có dữ liệu");
        }
    }
}
