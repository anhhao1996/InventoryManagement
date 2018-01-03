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
    public partial class danhsachphieunhaphangview : UserControl
    {
        public danhsachphieunhaphangview()
        {
            InitializeComponent();

            common.addimagecolumn(dataGridView1);
        }

        int madonnhap;
        
        #region danhsachphieunhaphang

        //tìm kiếm đơn nhập theo manhacungcap, tennhacungcap, manhanvien, tennhanvien
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            phieunhaphangbus bus = new phieunhaphangbus();
            danhsachdonnhapdgv.DataSource = bus.findall(textBox8.Text);
            danhsachdonnhapdgv.Columns["TONKHOes"].Visible = false;
            danhsachdonnhapdgv.Columns["NHACUNGCAP"].Visible = false;
            danhsachdonnhapdgv.Columns["NHANVIEN"].Visible = false;
        }

        //lấy danh sách phiếu nhập hàng
        private void button13_Click(object sender, EventArgs e)
        {
            phieunhaphangbus bus = new phieunhaphangbus();
            if (bus.any())
            {
                danhsachdonnhapdgv.DataSource = bus.list();
                danhsachdonnhapdgv.Columns["MANHAPHANG"].HeaderText = "Mã nhập hàng";
                danhsachdonnhapdgv.Columns["NGAYNHAPHANG"].HeaderText = "Ngày nhập hàng";
                danhsachdonnhapdgv.Columns["MANHACUNGCAP"].HeaderText = "Mã nhà cung cấp";
                danhsachdonnhapdgv.Columns["MANV"].HeaderText = "Mã nhân viên";
                danhsachdonnhapdgv.Columns["TONKHOes"].Visible = false;
                danhsachdonnhapdgv.Columns["NHACUNGCAP"].Visible = false;
                danhsachdonnhapdgv.Columns["NHANVIEN"].Visible = false;
                label1.Text = "";
            }
            else
                label1.Text = "Chưa có phiếu nhập hàng nào";
        }

        //sửa phiếu nhập hàng khi double_click
        private void danhsachdonnhapdgv_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    //Tao menu ngu canh
                    ContextMenuStrip menu = new ContextMenuStrip();
                    menu.Items.Add("Hiển thị dữ liệu để sửa", null, new EventHandler(suaphieu));
                    menu.Items.Add("Xóa", null, new EventHandler(xoaphieu));
                    //Di chuyen den dong hien hanh
                    danhsachdonnhapdgv.CurrentCell = danhsachdonnhapdgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //hien thi menu
                    Point pt = danhsachdonnhapdgv.PointToClient(Control.MousePosition);
                    menu.Show(danhsachdonnhapdgv, pt.X, pt.Y);
                }
            }
        }

        //load dữ liệu lên sửa phiếu
        private void suaphieu(object sender, EventArgs args)
        {
            tabControl4.SelectedTab = tabPage13;
            panel12.Visible = true;
            splitContainer3.Visible = false;
            madonnhap = (int)danhsachdonnhapdgv.SelectedCells[0].Value;
            maphieunhaplbl.Text = madonnhap.ToString();

            dateTimePicker4.Text = danhsachdonnhapdgv.SelectedCells[1].Value.ToString();
            if (listnhacungcap(cbmancc))
            {
                //load thông tin nhân viên đang đăng nhập
                txtsuamanvhientai.Text = currentuser.user;
                //load dữ liệu vào combobox manhacungcapcb
                nhacungcapbus bus = new nhacungcapbus();
                txtsuatenncc.Text = bus.getname(cbmancc.SelectedItem.ToString());
            }

            txtsuamanv.Text = danhsachdonnhapdgv.SelectedCells[3].Value.ToString();
        }

        //load tên nhà cung cấp
        private void cbmancc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nhacungcapbus bus = new nhacungcapbus();
            txtsuatenncc.Text = bus.getname(cbmancc.SelectedItem.ToString());
        }

        //hoàn tất trở về không sửa chi tiết phiếu nhập
        private void button33_Click(object sender, EventArgs e)
        {
            if (suaphieunhap())
            {
                tabControl4.SelectedTab = tabPage13;
                common.ClearTextBoxes(panel12);
            }
        }

        //sửa thông tin phiếu nhập và tiếp tục sửa chi tiết của phiếu nhập(tồn kho)
        private void button34_Click(object sender, EventArgs e)
        {
            if (suaphieunhap())
            {
                splitContainer3.Visible = true;
                panel12.Visible = false;
                tonkhobus bus = new tonkhobus();
                thongtindonnhap1dgv.DataSource = bus.findall(madonnhap);
                thongtindonnhap1dgv.Columns["MANHAPHANG"].HeaderText = "Mã nhập hàng";
                thongtindonnhap1dgv.Columns["MASP"].HeaderText = "Mã sản phẩm";
                thongtindonnhap1dgv.Columns["NGAYHETHAN"].HeaderText = "Ngày hết hạn";
                thongtindonnhap1dgv.Columns["SOLUONGNHAP"].HeaderText = "Số lượng nhập";
                thongtindonnhap1dgv.Columns["SOLUONGTON"].HeaderText = "Số lượng tồn";
                thongtindonnhap1dgv.Columns["DONGIANHAP"].HeaderText = "Đơn giá nhập";
                thongtindonnhap1dgv.Columns["PHIEUNHAPHANG"].Visible = false;
                thongtindonnhap1dgv.Columns["SANPHAM"].Visible = false;
                thongtindonnhap1dgv.Columns["XUATKHOes"].Visible = false;
            }
            label55.Text = madonnhap.ToString();
        }

        //sửa phiếu nhập hàng
        private bool suaphieunhap()
        {
            PHIEUNHAPHANG entity = new PHIEUNHAPHANG();
            if (txtsuamanv.Text.Trim().Length == 0 || txtsuamanvhientai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa chọn phiếu nhập hàng để sửa!", "Thông báo");
                return false;
            }
            else
            {
                if (maphieunhaplbl.Text == madonnhap.ToString())
                    entity.MANHAPHANG = madonnhap;
                else entity.MANHAPHANG = Convert.ToInt32(maphieunhaplbl.Text);
                entity.MANV = txtsuamanvhientai.Text;
                entity.NGAYNHAPHANG = dateTimePicker4.Value.Date;
                entity.MANHACUNGCAP = cbmancc.SelectedItem.ToString();
                phieunhaphangbus bus = new phieunhaphangbus();
                bool success = bus.update(entity);
                common.successorerror(success);
                return success;
            }
        }

        //xóa phiếu nhập
        private void xoaphieu(object sender, EventArgs args)
        {
                DialogResult dialogResult = MessageBox.Show("Xóa phiếu nhập hàng sẽ xóa tất cả các tồn kho thuộc về nó" + "\n" + "Bạn chắc chắn chứ", "Xóa phiếu nhập hàng", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    xoaphieunhaphang((int)danhsachdonnhapdgv.SelectedCells[0].Value);
                }
        }

        //xóa phiếu nhập hàng
        private void xoaphieunhaphang(int manhaphang)
        {
            phieunhaphangbus bus = new phieunhaphangbus();
            PHIEUNHAPHANG entity = new PHIEUNHAPHANG();
            entity.MANHAPHANG = manhaphang;
            common.successorerror(bus.delete(entity));
        }

        //load danh sách tồn kho của phiếu nhập hàng
        private void danhsachdonnhapdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tonkhobus bus = new tonkhobus();
                DataGridViewRow row = this.danhsachdonnhapdgv.Rows[e.RowIndex];
                danhsachtonkhotheophieunhapdgv.DataSource = bus.findall((int)row.Cells["MANHAPHANG"].Value);
                danhsachtonkhotheophieunhapdgv.Columns["MANHAPHANG"].HeaderText = "Mã nhập hàng";
                danhsachtonkhotheophieunhapdgv.Columns["MASP"].HeaderText = "Mã sản phẩm";
                danhsachtonkhotheophieunhapdgv.Columns["NGAYHETHAN"].HeaderText = "Ngày hết hạn";
                danhsachtonkhotheophieunhapdgv.Columns["SOLUONGNHAP"].HeaderText = "Số lượng nhập";
                danhsachtonkhotheophieunhapdgv.Columns["SOLUONGTON"].HeaderText = "Số lượng tồn";
                danhsachtonkhotheophieunhapdgv.Columns["DONGIANHAP"].HeaderText = "Đơn giá nhập";
                danhsachtonkhotheophieunhapdgv.Columns["PHIEUNHAPHANG"].Visible = false;
                danhsachtonkhotheophieunhapdgv.Columns["SANPHAM"].Visible = false;
                danhsachtonkhotheophieunhapdgv.Columns["XUATKHOes"].Visible = false;

                int soluongnhap = 0;
                int tongsoluongnhap = 0;
                decimal tonggianhap = 0;
                //tính tổng tiền của phiếu nhập hàng
                foreach (DataGridViewRow row1 in danhsachtonkhotheophieunhapdgv.Rows)
                {
                    soluongnhap = Convert.ToInt32(row1.Cells["SOLUONGNHAP"].Value);
                    Decimal giaxuat = Convert.ToDecimal(row1.Cells["DONGIANHAP"].Value);
                    tongsoluongnhap += soluongnhap;
                    tonggianhap += giaxuat * soluongnhap;
                }
                txttonggianhap.Text = tonggianhap.ToString();
            }
        }

        //tìm kiếm sản phẩm (sửa chi tiết phiếu nhập)
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            sanphambus bus = new sanphambus();
            dataGridView1.DataSource = bus.findall(textBox9.Text);
            common.loadimagecolumn(dataGridView1, "HINHANH");
            dataGridView1.Columns["MASP"].HeaderText = "Mã sản phẩm";
            dataGridView1.Columns["TENSP"].HeaderText = "Tên sản phẩm";
            dataGridView1.Columns["LOAISP"].HeaderText = "Loại sản phẩm";
            dataGridView1.Columns["HANSUDUNG"].HeaderText = "Hạn sử dụng";
            dataGridView1.Columns["TONKHOes"].Visible = false;
            dataGridView1.Columns["LOAI"].Visible = false;
        }
        //load danh sách sản phẩm (sửa chi tiết phiếu nhập)
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                label53.Text = row.Cells["MASP"].Value.ToString();
                if (row.Cells["HANSUDUNG"].Value.ToString().Equals("Không"))
                    dateTimePicker3.Enabled = false;
                else dateTimePicker3.Enabled = true;
            }
        }
        //nút thêm (sửa chi tiết phiếu nhập)
        private void button32_Click(object sender, EventArgs e)
        {
            TONKHO entity = new TONKHO();
            entity.MANHAPHANG = madonnhap;
            entity.MASP = label53.Text;

            //xem sản phẩm có thuộc loại có hạn sử dụng không
            if (dateTimePicker3.Enabled == true)
                entity.NGAYHETHAN = dateTimePicker3.Value.Date;

            entity.SOLUONGNHAP = Convert.ToInt32(numericUpDown2.Value);
            entity.SOLUONGTON = entity.SOLUONGNHAP;
            entity.DONGIANHAP = common.ktdecimal(textBox10.Text);

            tonkhobus bus = new tonkhobus();
            common.successorerror(bus.add(entity));
            thongtindonnhap1dgv.DataSource = bus.findall(madonnhap);
            thongtindonnhap1dgv.Columns["PHIEUNHAPHANG"].Visible = false;
            thongtindonnhap1dgv.Columns["SANPHAM"].Visible = false;
            thongtindonnhap1dgv.Columns["XUATKHOes"].Visible = false;
        }
        //button hoàn tất (sửa chi tiết phiếu)
        private void button30_Click(object sender, EventArgs e)
        {
            tabControl4.SelectedTab = tabPage13;
            common.ClearTextBoxes(panel11);
            panel12.Visible = true;
            splitContainer3.Visible = false;
        }
        //menu ngữ cảnh
        private void thongtindonnhap1dgv_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    //Tao menu ngu canh
                    ContextMenuStrip menu = new ContextMenuStrip();
                    menu.Items.Add("Hiển thị dữ liệu để sửa", null, new EventHandler(suachitietphieu));
                    menu.Items.Add("Xóa", null, new EventHandler(xoachitietphieu));
                    //Di chuyen den dong hien hanh
                    thongtindonnhap1dgv.CurrentCell = thongtindonnhap1dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //hien thi menu
                    Point pt = thongtindonnhap1dgv.PointToClient(Control.MousePosition);
                    menu.Show(thongtindonnhap1dgv, pt.X, pt.Y);
                }
            }
        }
        //load thông tin để sửa (sửa chi tiết phiếu)
        private void suachitietphieu(object sender, EventArgs args)
        {
            button29.Enabled = true;
            dateTimePicker3.Enabled = true;
            if (thongtindonnhap1dgv.SelectedCells[3].Value == null)
            {
                dateTimePicker3.Enabled = false;
            }
            else
            {
                dateTimePicker3.Text = thongtindonnhap1dgv.SelectedCells[3].Value.ToString();
            }
            numericUpDown2.Value = Int32.Parse(thongtindonnhap1dgv.SelectedCells[4].Value.ToString());

            //tính số lượng đã xuất
            int slnhapcu = Int32.Parse(thongtindonnhap1dgv.SelectedCells[4].Value.ToString());
            int soluongxuat =  slnhapcu - (int)thongtindonnhap1dgv.SelectedCells[5].Value;
            lblslxuat.Text = soluongxuat.ToString();

            textBox10.Text = thongtindonnhap1dgv.SelectedCells[6].Value.ToString();
            label53.Text = thongtindonnhap1dgv.SelectedCells[2].Value.ToString();
            label55.Text = thongtindonnhap1dgv.SelectedCells[1].Value.ToString();
            lblmatonkho.Text = thongtindonnhap1dgv.SelectedCells[0].Value.ToString();
        }
        //nút sửa (sửa chi tiết phiếu nhập)
        private void button29_Click(object sender, EventArgs e)
        {
            button29.Enabled = false;
            TONKHO entity = new TONKHO();
            tonkhobus bus = new tonkhobus();
            entity.STT = Int32.Parse(lblmatonkho.Text);
            entity.MANHAPHANG = madonnhap;
            entity.MASP = label53.Text;
            if (dateTimePicker3.Enabled == false)
            { }
            else
            {
                entity.NGAYHETHAN = dateTimePicker3.Value.Date;
            }
            entity.SOLUONGNHAP = (int)numericUpDown2.Value;
            entity.DONGIANHAP = common.ktdecimal(textBox10.Text);
            entity.SOLUONGTON = entity.SOLUONGNHAP - Int32.Parse(lblslxuat.Text);
            bool update = bus.update(entity);
            common.successorerror(update);
            if (update)
            {
                thongtindonnhap1dgv.DataSource = bus.findall(madonnhap);
                thongtindonnhap1dgv.Columns["PHIEUNHAPHANG"].Visible = false;
                thongtindonnhap1dgv.Columns["SANPHAM"].Visible = false;
                thongtindonnhap1dgv.Columns["XUATKHOes"].Visible = false;
                label53.Text = "Mã sản phẩm";
                numericUpDown2.Value = 0;
                textBox10.Clear();
                dateTimePicker3.ResetText();
                lblmatonkho.Text = "0";
            }
            else
            { }
        }
        //xóa (sửa chi tiết phiếu)
        private void xoachitietphieu(object sender, EventArgs args)
        {
            TONKHO entity = new TONKHO();
            tonkhobus bus = new tonkhobus();
            entity.STT = Int32.Parse(thongtindonnhap1dgv.SelectedCells[0].Value.ToString());
            bool delete = bus.delete(entity);
            common.successorerror(delete);
            if (delete)
            { thongtindonnhap1dgv.DataSource = bus.list(); }
            else
            { }
        }

        private bool listnhacungcap(ComboBox cb)
        {
            nhacungcapbus bus = new nhacungcapbus();
            if (bus.any())
            {
                cb.DataSource = bus.getids();
                return true;
            }
            return false;
        }

        public void loadcombobox()
        {
            if (listnhacungcap(cbmancc))
            {
                nhacungcapbus bus = new nhacungcapbus();
                txtsuatenncc.Text = bus.getname(cbmancc.SelectedItem.ToString());
            }
        }
        #endregion
        
        //chỉ cho nhập số
        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
