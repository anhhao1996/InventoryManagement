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
using System.IO;
using System.Drawing.Imaging;

namespace WindowsFormsApplication1.View
{
    public partial class danhsachsanphamview : UserControl
    {
        public danhsachsanphamview()
        {
            InitializeComponent();
            common.addimagecolumn(danhsachsanphamdgv);
            common.addimagecolumn(danhsachsanphamsuadgv);
            tabControl3.SelectedTab = tabPage11;
        }

        //đường dẫn tới folder ảnh trong debug
        private string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Images\";

        #region danhsachsanpham

        //tìm kiếm sản phẩm
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sanphambus bus = new sanphambus();
            danhsachsanphamdgv.DataSource = bus.findall(textBox2.Text);
            common.loadimagecolumn(danhsachsanphamdgv, "HINHANH");
            danhsachsanphamdgv.Columns["MASP"].HeaderText = "Mã sản phẩm";
            danhsachsanphamdgv.Columns["TENSP"].HeaderText = "Tên sản phẩm";
            danhsachsanphamdgv.Columns["LOAISP"].HeaderText = "Loại sản phẩm";
            danhsachsanphamdgv.Columns["HANSUDUNG"].HeaderText = "Hạn sử dụng";
            danhsachsanphamdgv.Columns["TONKHOes"].Visible = false;
            danhsachsanphamdgv.Columns["LOAI"].Visible = false;
        }

        //button lấy danh sách sản phẩm trong database
        private void button9_Click_1(object sender, EventArgs e)
        {
            sanphambus bus = new sanphambus();
            danhsachsanphamdgv.DataSource = bus.list();
            common.loadimagecolumn(danhsachsanphamdgv, "HINHANH");
            danhsachsanphamdgv.Columns["MASP"].HeaderText = "Mã sản phẩm";
            danhsachsanphamdgv.Columns["TENSP"].HeaderText = "Tên sản phẩm";
            danhsachsanphamdgv.Columns["LOAISP"].HeaderText = "Loại sản phẩm";
            danhsachsanphamdgv.Columns["HANSUDUNG"].HeaderText = "Hạn sử dụng";
            danhsachsanphamdgv.Columns["LOAI"].Visible = false;
            danhsachsanphamdgv.Columns["TONKHOes"].Visible = false;
        }

        //menu chọn xóa sửa sản phẩm
        private void danhsachsanphamdgv_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    //Tao menu ngu canh
                    ContextMenuStrip menu = new ContextMenuStrip();
                    menu.Items.Add("Hiển thị dữ liệu để sửa", null, new EventHandler(suasanpham));
                    menu.Items.Add("Xóa", null, new EventHandler(xoasanpham));
                    //Di chuyen den dong hien hanh
                    danhsachsanphamdgv.CurrentCell = danhsachsanphamdgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //hien thi menu
                    Point pt = danhsachsanphamdgv.PointToClient(Control.MousePosition);
                    menu.Show(danhsachsanphamdgv, pt.X, pt.Y);
                }
            }
        }

        //load dữ liệu từ danhsachsanphamdgv lên textbox và picturebox
        private void suasanpham(object sender, EventArgs args)
        {
            tabControl3.SelectedTab = tabPage12;
            listmaloai(cbloai1);
            txtsuamasp.Text = danhsachsanphamdgv.SelectedCells[1].Value.ToString();

            if (checkfiletontai(appPath + danhsachsanphamdgv.SelectedCells[2].Value.ToString()))
            {
                //tiêu hủy sau khi sử dụng xong
                using (var bmp = new Bitmap(appPath + danhsachsanphamdgv.SelectedCells[2].Value.ToString()))
                {
                    pictureBox2.Image = new Bitmap(bmp);
                }
            }

            txttenanh.Text = danhsachsanphamdgv.SelectedCells[2].Value.ToString();
            txtsuatensp.Text = danhsachsanphamdgv.SelectedCells[3].Value.ToString();

            //tìm giá trị của mã loại vào combobox
            cbloai1.SelectedIndex = cbloai1.FindStringExact(danhsachsanphamdgv.SelectedCells[4].Value.ToString());
            loaibus bus = new loaibus();
            txttenloai.Text = bus.getname(cbloai1.SelectedItem.ToString());
            if (danhsachsanphamdgv.SelectedCells[5].Value.ToString() == "Có")
            {
                radioButton4.Checked = true;
            }
            else radioButton3.Checked = true;
        }

        //lấy tên loại vào textbox
        private void cbloai1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loaibus bus = new loaibus();
            txttenloai.Text = bus.getname(cbloai1.SelectedItem.ToString());
        }

        //chọn ảnh sửa
        private void button27_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.jpeg, *.png, *.jpg, *.gif)|*.jpeg;*.png;*.jpg;*.gif|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            ;
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;

            openFileDialog1.Title = "Chọn ảnh sản phẩm";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = common.ResizeImage(Image.FromFile(openFileDialog1.FileName), 100, 100); ;
            }
        }

        //sửa sản phẩm
        private void button28_Click(object sender, EventArgs e)
        {
            //lấy tên ảnh của file ảnh cũ
            string tenanh = txtsuamasp.Text.Replace(" ", "") + DateTime.Now.ToString("ddmmyyyyhhmmss") + ".jpeg";

            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }
            if (pictureBox2 == null || pictureBox2.Image == null)
            {
                MessageBox.Show("Không có hình");
                tenanh = "default-product-image.jpg";
            }
            else
                pictureBox2.Image.Save(appPath + tenanh, ImageFormat.Jpeg);

            var checkedButton = panel9.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            SANPHAM entity = new SANPHAM();
            entity.MASP = txtsuamasp.Text;
            entity.TENSP = txtsuatensp.Text;
            entity.HINHANH = tenanh;
            entity.LOAISP = cbloai1.SelectedItem.ToString();
            if (checkedButton == null)
            { }
            else
            { entity.HANSUDUNG = checkedButton.Text; }

            sanphambus bus = new sanphambus();
            bool success = bus.update(entity);
            common.successorerror(success);
            if (success)
            {
                errorProvider1.Clear();
                danhsachsanphamdgv.DataSource = bus.findall(textBox2.Text);
                common.loadimagecolumn(danhsachsanphamdgv, "HINHANH");
                danhsachsanphamdgv.Columns["LOAI"].Visible = false;
                danhsachsanphamdgv.Columns["TONKHOes"].Visible = false;

                deleteimage(txttenanh.Text);

                common.ClearTextBoxes(panel8);

                danhsachsanphamsuadgv.DataSource = bus.find(entity.MASP);
                common.loadimagecolumn(danhsachsanphamsuadgv, "HINHANH");

                danhsachsanphamsuadgv.Columns["MASP"].HeaderText = "Mã sản phẩm";
                danhsachsanphamsuadgv.Columns["TENSP"].HeaderText = "Tên sản phẩm";
                danhsachsanphamsuadgv.Columns["LOAISP"].HeaderText = "Loại sản phẩm";
                danhsachsanphamsuadgv.Columns["HANSUDUNG"].HeaderText = "Hạn sử dụng";

                danhsachsanphamsuadgv.Columns["TONKHOes"].Visible = false;
                danhsachsanphamsuadgv.Columns["LOAI"].Visible = false;
            }
            else
            {
                ViewErrors(bus.validatedictionary);
            }
        }

        //xóa sản phẩm
        private void xoasanpham(object sender, EventArgs args)
        {
            SANPHAM entity = new SANPHAM();
            entity.MASP = danhsachsanphamdgv.SelectedCells[1].Value.ToString();
            sanphambus bus = new sanphambus();
            bool success = bus.delete(entity);
            common.successorerror(success);
            if (success)
            {
                deleteimage(danhsachsanphamdgv.SelectedCells[2].Value.ToString());

                danhsachsanphamdgv.DataSource = bus.findall(textBox2.Text);
                common.loadimagecolumn(danhsachsanphamdgv, "HINHANH");
                danhsachsanphamdgv.Columns["LOAI"].Visible = false;
                danhsachsanphamdgv.Columns["TONKHOes"].Visible = false;
            }
        }

        //xóa ảnh
        private bool deleteimage(string path)
        {
            if (path == "default-product-image.jpg")
                return true;
            else
            {
                path = appPath + path;
                try
                {
                    FileInfo file = new FileInfo(path);
                    if (file.Exists)
                    {
                        file.Delete();
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        private bool checkfiletontai(string path)
        {
            FileInfo file = new FileInfo(path);
            if (file.Exists)
                return true;
            return false;
        }
        private bool listmaloai(ComboBox cb)
        {
            loaibus bus = new loaibus();
            //nếu có loại sản phẩm
            if (bus.any())
            {
                cb.DataSource = bus.getids();
                return true;
            }
            return false;
        }
        public void loadcombobox()
        {
            if (listmaloai(cbloai1))
            {
                loaibus bus = new loaibus();
                txttenloai.Text = bus.getname(cbloai1.SelectedItem.ToString());
            }
        }

        private void ViewErrors(Dictionary<string, string> Dictionary)
        {
            errorProvider1.Clear();
            foreach (var entry in Dictionary)
            {
                switch (entry.Key)
                {
                    case "TENSP":
                        errorProvider1.SetError(txtsuatensp, entry.Value);
                        break;
                    case "HSD":
                        errorProvider1.SetError(radioButton3, entry.Value);
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
    }
}
