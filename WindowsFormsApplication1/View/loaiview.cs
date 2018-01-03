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
    public partial class loaiview : UserControl
    {
        public loaiview()
        {
            InitializeComponent();
            maloailbl.Visible = false;
        }

        #region loai

        //thêm vào loại sản phẩm
        private void button2_Click(object sender, EventArgs e)
        {
            LOAI entity = new LOAI();
            entity.MALOAI = maloaitxt.Text;
            entity.TENLOAI = tenloaitxt.Text;

            loaibus bus = new loaibus();
            bool success = bus.add(entity);
            if (success)
            {
                loaidgv.DataSource = bus.find(entity.MALOAI);
            }
            else
            {
                ViewErrors(bus.validatedictionary);
            }

        }
        //lấy danh sách các loại sản phẩm
        private void button12_Click(object sender, EventArgs e)
        {
            loaibus bus = new loaibus();
            loaidgv.DataSource = bus.list();
            loaidgv.Columns["maloai"].HeaderText = "Mã loại";
            loaidgv.Columns["tenloai"].HeaderText = "Tên loại";
            
        }
        //menu ngữ cảnh
        private void loaidgv_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    //Tao menu ngu canh
                    ContextMenuStrip menu = new ContextMenuStrip();
                    menu.Items.Add("Hiển thị dữ liệu để sửa", null, new EventHandler(sualoai));
                    menu.Items.Add("Xóa", null, new EventHandler(xoaloai));
                    //Di chuyen den dong hien hanh
                    loaidgv.CurrentCell = loaidgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //hien thi menu
                    Point pt = loaidgv.PointToClient(Control.MousePosition);
                    menu.Show(loaidgv, pt.X, pt.Y);
                }
            }
        }

        //Load dữ liệu lên form khi bấm sửa trong menucontext
        private void sualoai(object sender, EventArgs args)
        {
            button17.Enabled = true;
            maloailbl.Visible = true;
            maloaitxt.Hide();
            tenloaitxt.Text = loaidgv.SelectedCells[1].Value.ToString();
            maloailbl.Text = loaidgv.SelectedCells[0].Value.ToString();
        }

        //button sửa loại sản phẩm
        private void button17_Click(object sender, EventArgs e)
        {
            button17.Enabled = false;
            LOAI entity = new LOAI();
            entity.TENLOAI = tenloaitxt.Text;
            entity.MALOAI = maloailbl.Text;
            loaibus bus = new loaibus();
            bool update = bus.update(entity);
            common.successorerror(update);
            if (update)
            {
                loaidgv.DataSource = bus.find(loaidgv.SelectedCells[0].Value.ToString());
                maloailbl.Visible = false;
                maloaitxt.Visible = true;
                tenloaitxt.Clear();
            }
            else
            { }
        }

        //xóa loại sản phẩm
        private void xoaloai(object sender, EventArgs args)
        {
            LOAI entity = new LOAI();
            entity.MALOAI = loaidgv.SelectedCells[0].Value.ToString();
            loaibus bus = new loaibus();
            bool delete = bus.delete(entity);
            common.successorerror(delete);
            if (delete)
            { loaidgv.DataSource = bus.list(); }
            else
            { }
        }

        private void ViewErrors(Dictionary<string, string> Dictionary)
        {
            errorProvider1.Clear();
            foreach (var entry in Dictionary)
            {
                switch (entry.Key)
                {
                    case "MALOAI":
                        errorProvider1.SetError(maloaitxt, entry.Value);
                        break;
                    case "TENLOAI":
                        errorProvider1.SetError(tenloaitxt, entry.Value);
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
    }
}
