using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace WindowsFormsApplication1.View
{
    public partial class danhsachtonkhoview : UserControl
    {
        public danhsachtonkhoview()
        {
            InitializeComponent();
        }

        //load dữ liệu khi bấm enter
        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tonkhobus bus = new tonkhobus();
                danhsachhangtonkhodgv.DataSource = bus.findhangtonkho(textBox4.Text);
            }
        }

        //button để tìm kiếm theo ngày
        private void btntimkiemtheongay_Click(object sender, EventArgs e)
        {
            tonkhobus bus = new tonkhobus();
            danhsachhangtonkhodgv.DataSource = bus.findhangtonkho(textBox4.Text, dateTimePicker2.Value.Date);

            danhsachhangtonkhodgv.Columns[0].HeaderText = "Số thứ tự";
            danhsachhangtonkhodgv.Columns[1].HeaderText = "Mã nhập hàng";
            danhsachhangtonkhodgv.Columns[2].HeaderText = "Mã sản phẩm";
            danhsachhangtonkhodgv.Columns[3].HeaderText = "Ngày hết hạn";
            danhsachhangtonkhodgv.Columns[4].HeaderText = "Số lượng nhập";
            danhsachhangtonkhodgv.Columns[5].HeaderText = "Số lượng tồn";
            danhsachhangtonkhodgv.Columns[6].HeaderText = "Đơn giá nhập";

            danhsachhangtonkhodgv.Columns["PHIEUNHAPHANG"].Visible = false;
            danhsachhangtonkhodgv.Columns["SANPHAM"].Visible = false;
            danhsachhangtonkhodgv.Columns["XUATKHOes"].Visible = false;
        }

        //tính tổng số lượng + giá bình quân của sản phẩm bị double click
        private void danhsachhangtonkhodgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tonkhobus bus = new tonkhobus();
            danhsachhangtonkhodgv.DataSource = bus.findmothangtonkho(danhsachhangtonkhodgv.SelectedCells[2].Value.ToString());
            danhsachhangtonkhodgv.Columns["PHIEUNHAPHANG"].Visible = false;
            danhsachhangtonkhodgv.Columns["SANPHAM"].Visible = false;
            danhsachhangtonkhodgv.Columns["XUATKHOes"].Visible = false;

            int tongsoluong = 0;
            decimal tonggiatri = 0;
            decimal giabinhquan;
            foreach (DataGridViewRow row in danhsachhangtonkhodgv.Rows)
            {
                int soluongton = Convert.ToInt32(row.Cells["SOLUONGTON"].Value);
                tongsoluong += soluongton;
                tonggiatri += Convert.ToDecimal(row.Cells["DONGIANHAP"].Value) * soluongton;
            }
            giabinhquan = Math.Round(tonggiatri / tongsoluong, 0);

            txtgiabinhquan.Text = giabinhquan.ToString();
            txttongsoluong.Text = tongsoluong.ToString();
            txttonggiatri.Text = tonggiatri.ToString();
        }
    }
}
