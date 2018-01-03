using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
namespace WindowsFormsApplication1.View
{
    public partial class taophieunhaphangview : UserControl 
    {
        
        
        public taophieunhaphangview()
        {
            InitializeComponent();
            
            common.addimagecolumn(danhsachsanpham1dgv);

            panel1.Visible = true;
            nhapchitietdon.Visible = false;

        }

        int madonnhap;
        public string nvdangnhap
        {
            set { manvtxt.Text = value; }
        }
        
        #region taodonnhap

        #region taophieunhaphang

        //nhập phiếu nhập hàng
        private void button1_Click(object sender, EventArgs e)
        {
            PHIEUNHAPHANG entity = new PHIEUNHAPHANG();
            entity.MANHACUNGCAP = manhacungcapcb.SelectedItem.ToString();
            entity.NGAYNHAPHANG = dateTimePicker1.Value.Date;
            entity.MANV = manvtxt.Text;

            phieunhaphangbus bus = new phieunhaphangbus();
            bool success = bus.add(entity);
            common.successorerror(success);
            //hiện panel để nhập chi tiết đơn hàng của phiếu nhập hàng
            if (success)
            {
                madonnhap = bus.getcurrentid();
                madonnhaplbl.Text = madonnhap.ToString();
                nhapchitietdon.Visible = true;
                panel1.Visible = false;
            }
        }

        //lấy tên nhà cung cấp vào textbox
        private void manhacungcapcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nhacungcapbus bus = new nhacungcapbus();
            mancctxt.Text = bus.getname(manhacungcapcb.SelectedItem.ToString());
        }
        #endregion

        #region taotonkho(chitietnhaphang)

        //tìm kiếm sản phẩm đã nhập trong database
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            sanphambus bus = new sanphambus();
            danhsachsanpham1dgv.DataSource = bus.findall(textBox3.Text);
            common.loadimagecolumn(danhsachsanpham1dgv, "HINHANH");
            danhsachsanpham1dgv.Columns["MASP"].HeaderText = "Mã sản phẩm";
            danhsachsanpham1dgv.Columns["TENSP"].HeaderText = "Tên sản phẩm";
            danhsachsanpham1dgv.Columns["LOAISP"].HeaderText = "Loại sản phẩm";
            danhsachsanpham1dgv.Columns["HANSUDUNG"].HeaderText = "Hạn sử dụng";
            danhsachsanpham1dgv.Columns["TONKHOes"].Visible = false;
            danhsachsanpham1dgv.Columns["LOAI"].Visible = false;

        }
        //lấy dữ liệu tồn kho
        private void button4_Click(object sender, EventArgs e)
        {
            tonkhobus bus = new tonkhobus();
            thongtindonnhapdgv.DataSource = bus.list();
            thongtindonnhapdgv.Columns[0].Width = 144;
        }
        //nhập tồn kho
        private void luutonkhobtn_Click(object sender, EventArgs e)
        {
            TONKHO entity = new TONKHO();
            entity.MANHAPHANG = madonnhap;
            entity.MASP = masplbl.Text;

            //xem sản phẩm có thuộc loại có hạn sử dụng không
            if (ngayhethan.Enabled == true)
                entity.NGAYHETHAN = ngayhethan.Value.Date;

            entity.SOLUONGNHAP = Convert.ToInt32(soluongnhap.Value);
            entity.SOLUONGTON = entity.SOLUONGNHAP;
            entity.DONGIANHAP = common.ktdecimal(dongianhaptxt.Text);

            tonkhobus bus = new tonkhobus();
            common.successorerror(bus.add(entity));
            thongtindonnhapdgv.DataSource = bus.findall(madonnhap);

            thongtindonnhapdgv.Columns[0].HeaderText = "Số thứ tự";
            thongtindonnhapdgv.Columns[1].HeaderText = "Mã nhập hàng";
            thongtindonnhapdgv.Columns[2].HeaderText = "Mã sản phẩm";
            thongtindonnhapdgv.Columns[3].HeaderText = "Ngày hết hạn";
            thongtindonnhapdgv.Columns[4].HeaderText = "Số lượng nhập";
            thongtindonnhapdgv.Columns[5].HeaderText = "Số lượng tồn";
            thongtindonnhapdgv.Columns[6].HeaderText = "Đơn giá nhập";
                  
            thongtindonnhapdgv.Columns["PHIEUNHAPHANG"].Visible = false;
            thongtindonnhapdgv.Columns["SANPHAM"].Visible = false;
            thongtindonnhapdgv.Columns["XUATKHOes"].Visible = false;
        }
        //menu ngữ cảnh
        private void thongtindonnhapdgv_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    //Tao menu ngu canh
                    ContextMenuStrip menu = new ContextMenuStrip();
                    menu.Items.Add("Hiển thị dữ liệu để sửa", null, new EventHandler(suatonkho));
                    menu.Items.Add("Xóa", null, new EventHandler(xoatonkho));
                    //Di chuyen den dong hien hanh
                    thongtindonnhapdgv.CurrentCell = thongtindonnhapdgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //hien thi menu
                    Point pt = thongtindonnhapdgv.PointToClient(Control.MousePosition);
                    menu.Show(thongtindonnhapdgv, pt.X, pt.Y);
                }
            }
        }
        //Load dữ liệu lên form khi bấm sửa
        private void suatonkho(object sender, EventArgs args)
        {
            ngayhethan.Enabled = true;
            if (thongtindonnhapdgv.SelectedCells[4].Value == null)
            {
                ngayhethan.Enabled = false;
            }
            else
            {
                ngayhethan.Text = thongtindonnhapdgv.SelectedCells[4].Value.ToString();
            }
            soluongnhap.Value = Decimal.Parse(thongtindonnhapdgv.SelectedCells[5].Value.ToString());
            dongianhaptxt.Text = thongtindonnhapdgv.SelectedCells[7].Value.ToString();
            masplbl.Text = thongtindonnhapdgv.SelectedCells[2].Value.ToString();
            madonnhaplbl.Text = thongtindonnhapdgv.SelectedCells[1].Value.ToString();
        }
        //button sửa
        private void button22_Click(object sender, EventArgs e)
        {
            TONKHO entity = new TONKHO();
            tonkhobus bus = new tonkhobus();
            entity.STT = Int32.Parse(thongtindonnhapdgv.SelectedCells[0].Value.ToString());
            entity.MANHAPHANG = Int32.Parse(thongtindonnhapdgv.SelectedCells[1].Value.ToString());
            entity.MASP = masplbl.Text;
            if (ngayhethan.Enabled == false)
            { }
            else
            {
                entity.NGAYHETHAN = ngayhethan.Value.Date;
            }
            entity.SOLUONGNHAP = (int)soluongnhap.Value;
            entity.DONGIANHAP = common.ktdecimal(dongianhaptxt.Text);
            entity.SOLUONGTON = (int)soluongnhap.Value;
            bool update = bus.update(entity);
            common.successorerror(update);
            if (update)
            {
                thongtindonnhapdgv.DataSource = bus.find((int)thongtindonnhapdgv.SelectedCells[0].Value);
                thongtindonnhapdgv.Columns["PHIEUNHAPHANG"].Visible = false;
                thongtindonnhapdgv.Columns["SANPHAM"].Visible = false;
                thongtindonnhapdgv.Columns["XUATKHOes"].Visible = false;
                masplbl.Text = "Mã sản phẩm";
                soluongnhap.Value = 0;
                dongianhaptxt.Clear();
                ngayhethan.ResetText();
            }
            else
            { }
        }
        //xóa tồn kho
        private void xoatonkho(object sender, EventArgs args)
        {
            TONKHO entity = new TONKHO();
            tonkhobus bus = new tonkhobus();
            entity.STT = Int32.Parse(thongtindonnhapdgv.SelectedCells[0].Value.ToString());
            bool delete = bus.delete(entity);
            common.successorerror(delete);
            if (delete)
            { thongtindonnhapdgv.DataSource = bus.list(); }
            else
            { }
        }
        //button hoàn tất
        private void button23_Click(object sender, EventArgs e)
        {
            hoantat();
        }
        //chọn sản phẩm để nhập tồn kho
        private void danhsachsanpham1dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.danhsachsanpham1dgv.Rows[e.RowIndex];
                masplbl.Text = row.Cells[1].Value.ToString();
                if (row.Cells[5].Value.ToString().Equals("Không"))
                    ngayhethan.Enabled = false;
                else ngayhethan.Enabled = true;
            }
        }

        #endregion

        #endregion

        public bool listnhacungcap(ComboBox cb)
        {
            nhacungcapbus bus = new nhacungcapbus();
            if (bus.any())
            {
                cb.DataSource = bus.getids();
                return true;
            }

            return false;

        }

        public void loadlistnhacc()
        {
            if (listnhacungcap(manhacungcapcb))
            {
                nhacungcapbus bus = new nhacungcapbus();
                mancctxt.Text = bus.getname(manhacungcapcb.SelectedItem.ToString());
            }
        }
        //chỉ cho nhập số
        private void dongianhaptxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void hoantat()
        {
            common.ClearTextBoxes(taodonnhap);
            nhapchitietdon.Visible = false;
            panel1.Visible = true;
            manvtxt.Text = currentuser.user;
            thongtindonnhapdgv.DataSource = null;
        }
    }
}
