using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Drawing.Imaging;
using System.IO;
using WindowsFormsApplication1.View;

namespace WindowsFormsApplication1
{
    public partial class themsanphamview : UserControl
    {
        public themsanphamview()
        {
            InitializeComponent();
            common.addimagecolumn(danhsachsanphamnhapdgv);
        }

        #region themsanpham

        //gán tên loại vào textbox loaisptxt khi chọn mã loại
        private void maloaicb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loaibus bus = new loaibus();
            loaisptxt.Text = bus.getname(maloaicb.SelectedItem.ToString());
        }

        //đường dẫn tới folder ảnh trong debug
        private string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Images\";

        //button chọn ảnh
        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.jpeg, *.png, *.jpg, *.gif)|*.jpeg;*.png;*.jpg;*.gif|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            ;
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;

            openFileDialog1.Title = "Chọn ảnh sản phẩm";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = common.ResizeImage(Image.FromFile(openFileDialog1.FileName), 100, 100); ;
            }
        }

        //button lưu sản phẩm mới vào database
        private void luusanpham_Click(object sender, EventArgs e)
        {
            //đặt tên ảnh = masanpham + ngaygionhap
            string tenanh = masanphamtxt.Text.Replace(" ", "") + DateTime.Now.ToString("ddmmyyyyhhmmss") + ".jpeg";

            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }
            if (pictureBox1 == null || pictureBox1.Image == null)
            {
                MessageBox.Show("Không có hình");
                tenanh = "default-product-image.jpg";
            }
            else
                pictureBox1.Image.Save(appPath + tenanh, ImageFormat.Jpeg);

            var checkedButton = panel5.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            SANPHAM entity = new SANPHAM();
            entity.MASP = masanphamtxt.Text;
            entity.TENSP = tensanphamtxt.Text;
            entity.HINHANH = tenanh;
            entity.LOAISP = maloaicb.SelectedItem.ToString();
            if (checkedButton == null)
            { }
            else
            { entity.HANSUDUNG = checkedButton.Text; }

            sanphambus bus = new sanphambus();
            bool success = bus.add(entity);
            common.successorerror(success);
            if (success)
            {
                errorProvider1.Clear();
                common.ClearTextBoxes(themsanpham);
                danhsachsanphamnhapdgv.DataSource = bus.find(entity.MASP);
                common.loadimagecolumn(danhsachsanphamnhapdgv, "HINHANH");
                danhsachsanphamnhapdgv.Columns["MASP"].HeaderText="Mã sản phẩm";
                danhsachsanphamnhapdgv.Columns["TENSP"].HeaderText="Tên sản phẩm";
                danhsachsanphamnhapdgv.Columns["LOAISP"].HeaderText="Loại sản phẩm";
                danhsachsanphamnhapdgv.Columns["HANSUDUNG"].HeaderText="Hạn sử dụng";
                danhsachsanphamnhapdgv.Columns["TONKHOes"].Visible = false;
                danhsachsanphamnhapdgv.Columns["LOAI"].Visible = false;
            }
            else
            {
                ViewErrors(bus.validatedictionary);
            }
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
            if (listmaloai(maloaicb))
            {
                loaibus bus = new loaibus();
                loaisptxt.Text = bus.getname(maloaicb.SelectedItem.ToString());
            }
        }
        private void ViewErrors(Dictionary<string, string> Dictionary)
        {
            errorProvider1.Clear();
            foreach (var entry in Dictionary)
            {
                switch (entry.Key)
                {
                    case "MASP":
                        errorProvider1.SetError(masanphamtxt, entry.Value);
                        break;
                    case "TENSP":
                        errorProvider1.SetError(tensanphamtxt, entry.Value);
                        break;
                    case "HSD":
                        errorProvider1.SetError(radioButton2, entry.Value);
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
    }
}
