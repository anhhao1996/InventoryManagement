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
using System.Globalization;

namespace WindowsFormsApplication1.View
{
    public partial class xuatkhoview : UserControl
    {
        public xuatkhoview()
        {
            InitializeComponent();
        }

        #region xuatkho

        public string nvdangnhap
        {
            set { lblmanv.Text = value; }
        }
        int soluongxuathientai;
        //tìm sản phẩm tồn kho cần xuất
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            tonkhobus bus = new tonkhobus();
            danhsachtonkho1dgv.DataSource = bus.findall(textBox4.Text);

            danhsachtonkho1dgv.Columns[0].HeaderText = "Số thứ tự";
            danhsachtonkho1dgv.Columns[1].HeaderText = "Mã nhập hàng";
            danhsachtonkho1dgv.Columns[2].HeaderText = "Mã sản phẩm";
            danhsachtonkho1dgv.Columns[3].HeaderText = "Ngày hết hạn";
            danhsachtonkho1dgv.Columns[4].HeaderText = "Số lượng nhập";
            danhsachtonkho1dgv.Columns[5].HeaderText = "Số lượng tồn";
            danhsachtonkho1dgv.Columns[6].HeaderText = "Đơn giá nhập";

            danhsachtonkho1dgv.Columns["PHIEUNHAPHANG"].Visible = false;
            danhsachtonkho1dgv.Columns["SANPHAM"].Visible = false;
            danhsachtonkho1dgv.Columns["XUATKHOes"].Visible = false;

        }

        //lấy danh sách tồn kho
        private void button16_Click(object sender, EventArgs e)
        {
            tonkhobus bus = new tonkhobus();
            danhsachtonkho1dgv.DataSource = bus.list();
            danhsachtonkho1dgv.Columns[8].Visible = false;
        }

        //chọn sản phẩm tồn kho cần xuất
        private void danhsachtonkho1dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.danhsachtonkho1dgv.Rows[e.RowIndex];
                matonkholbl.Text = row.Cells["STT"].Value.ToString();
            }
        }
        //nhập vào xuất kho
        private void button15_Click(object sender, EventArgs e)
        {
            XUATKHO entity = new XUATKHO();
            entity.MATONKHO = Int32.Parse(matonkholbl.Text);
            entity.SOLUONGXUAT = (int)numericUpDown1.Value;
            entity.NGAYXUAT = dateTimePicker2.Value.Date;
            entity.DONGIAXUAT = common.ktdecimal(textBox5.Text);
            entity.MANV = currentuser.user;
            xuatkhobus bus = new xuatkhobus();
            bool success = bus.add(entity);
            if (success)
            {
                errorProvider1.Clear();
                common.successorerror(success);
                xuatdgv.DataSource = bus.list();
                
                xuatdgv.Columns[0].HeaderText = "Số thứ tự";
                xuatdgv.Columns[1].HeaderText = "Mã tồn kho";
                xuatdgv.Columns[2].HeaderText = "Số lượng xuất";
                xuatdgv.Columns[3].HeaderText = "Ngày xuất";
                xuatdgv.Columns[4].HeaderText = "Đơn giá xuất";
                xuatdgv.Columns[5].HeaderText = "Mã nhân viên";

                xuatdgv.Columns["NHANVIEN"].Visible = false;
                xuatdgv.Columns["TONKHO"].Visible = false;
            }
            else
            {
                ViewErrors(bus.validatedictionary);
            }

        }
        //button lấy dữ liệu xuất kho
        private void button14_Click(object sender, EventArgs e)
        {
            xuatkhobus bus = new xuatkhobus();
            xuatdgv.DataSource = bus.list();
            xuatdgv.Columns["STT"].HeaderText = "Số thứ tự";
            xuatdgv.Columns["MATONKHO"].HeaderText = "Mã tồn kho";
            xuatdgv.Columns["SOLUONGXUAT"].HeaderText = "Số lượng xuất";
            xuatdgv.Columns["NGAYXUAT"].HeaderText = "Ngày xuất";
            xuatdgv.Columns["DONGIAXUAT"].HeaderText = "Đơn giá xuất";
            xuatdgv.Columns["MANV"].HeaderText = "Mã nhân viên";
            xuatdgv.Columns["NHANVIEN"].Visible = false;
            xuatdgv.Columns["TONKHO"].Visible = false;
        }
        //menu ngữ cảnh
        private void xuatdgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    //Tao menu ngu canh
                    ContextMenuStrip menu = new ContextMenuStrip();
                    menu.Items.Add("Hiển thị dữ liệu để sửa", null, new EventHandler(suaxuatkho));
                    menu.Items.Add("Xóa", null, new EventHandler(xoaxuatkho));
                    //Di chuyen den dong hien hanh
                    xuatdgv.CurrentCell = xuatdgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //hien thi menu
                    Point pt = xuatdgv.PointToClient(Control.MousePosition);
                    menu.Show(xuatdgv, pt.X, pt.Y);
                }
            }
        }
        //Load dữ liệu lên form khi bấm sửa
        private void suaxuatkho(object sender, EventArgs args)
        {
            button18.Enabled = true;
            matonkholbl.Text = xuatdgv.SelectedCells[1].Value.ToString();
            soluongxuathientai = Int32.Parse(xuatdgv.SelectedCells[2].Value.ToString());
            numericUpDown1.Value = soluongxuathientai;
            dateTimePicker2.Text = xuatdgv.SelectedCells[3].Value.ToString();
            textBox5.Text = xuatdgv.SelectedCells[4].Value.ToString();
        }
        //button sửa xuất kho
        private void button18_Click(object sender, EventArgs e)
        {
            button18.Enabled = false;
            XUATKHO entity = new XUATKHO();
            entity.STT = (int)xuatdgv.SelectedCells[0].Value;
            entity.MATONKHO = Int32.Parse(matonkholbl.Text);
            entity.SOLUONGXUAT = (int)numericUpDown1.Value - soluongxuathientai;

            entity.NGAYXUAT = dateTimePicker2.Value.Date;
            entity.DONGIAXUAT = common.ktdecimal(textBox5.Text);
            entity.MANV = currentuser.user;
            xuatkhobus bus = new xuatkhobus();
            bool update = bus.update(entity, soluongxuathientai);
            common.successorerror(update);
            if (update)
            {
                errorProvider1.Clear();
                xuatdgv.DataSource = bus.find((int)xuatdgv.SelectedCells[0].Value);

                xuatdgv.Columns[0].HeaderText = "Số thứ tự";
                xuatdgv.Columns[1].HeaderText = "Mã tồn kho";
                xuatdgv.Columns[2].HeaderText = "Số lượng xuất";
                xuatdgv.Columns[3].HeaderText = "Ngày xuất";
                xuatdgv.Columns[4].HeaderText = "Đơn giá xuất";
                xuatdgv.Columns[5].HeaderText = "Mã nhân viên";

                xuatdgv.Columns["NHANVIEN"].Visible = false;
                xuatdgv.Columns["TONKHO"].Visible = false;

                matonkholbl.Text = "Mã tồn kho";
                numericUpDown1.Value = 0;
                textBox5.Clear();
                dateTimePicker2.ResetText();
            }
            else
            {
                ViewErrors(bus.validatedictionary);
            }
        }
        //xóa xuất kho
        private void xoaxuatkho(object sender, EventArgs args)
        {
            XUATKHO entity = new XUATKHO();
            entity.STT = (int)xuatdgv.SelectedCells[0].Value;
            entity.SOLUONGXUAT = (int)xuatdgv.SelectedCells[2].Value;
            entity.MATONKHO = (int)xuatdgv.SelectedCells[1].Value;
            xuatkhobus bus = new xuatkhobus();
            bool delete = bus.delete(entity);
            common.successorerror(delete);
            if (delete)
            { xuatdgv.DataSource = bus.list(); }
            else
            { }
        }
        //button hoàn tất
        private void button19_Click(object sender, EventArgs e)
        {
            //tabControl1.SelectedTab = tabPage1;
        }

        private void ViewErrors(Dictionary<string, string> Dictionary)
        {
            errorProvider1.Clear();
            foreach (var entry in Dictionary)
            {
                switch (entry.Key)
                {
                    case "DONGIAXUAT":
                        errorProvider1.SetError(textBox5, entry.Value);
                        break;
                    case "SOLUONGXUAT":
                        errorProvider1.SetError(numericUpDown1, entry.Value);
                        break;
                    //case "SOLUONGXUAT":
                    //    errorProvider1.SetError(numericUpDown1, entry.Value);
                    //    break;
                    default:
                        break;

                }
            }
        }
        #endregion

        //chỉ cho nhập số
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            xuatkhobus bus = new xuatkhobus();
            if (textBox1.Text.Equals(""))
            { }
            else
            {
                xuatdgv.DataSource = bus.timxuatkho(textBox1.Text);
                xuatdgv.Columns["STT"].HeaderText = "Số thứ tự";
                xuatdgv.Columns["MATONKHO"].HeaderText = "Mã tồn kho";
                xuatdgv.Columns["SOLUONGXUAT"].HeaderText = "Số lượng xuất";
                xuatdgv.Columns["NGAYXUAT"].HeaderText = "Ngày xuất";
                xuatdgv.Columns["DONGIAXUAT"].HeaderText = "Đơn giá xuất";
                xuatdgv.Columns["MANV"].HeaderText = "Mã nhân viên";
                xuatdgv.Columns["NHANVIEN"].Visible = false;
                xuatdgv.Columns["TONKHO"].Visible = false;
            }

        }
    }
}
