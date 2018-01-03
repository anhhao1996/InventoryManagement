using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using WindowsFormsApplication1.View;
using MetroFramework.Forms;
namespace WindowsFormsApplication1
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();

            lg = new login();
            lg.dangnhap += button24_Click;

            
            tabthongke.Visible = false;
            pndangnhapuser.Controls.Add(lg);

            //add usercontrols
            tabquanlinhapkho.Controls.Add(tp);
            tabquanlinhapkho.Controls.Add(dspn);
            tabquanlinhapkho.Controls.Add(nccv);

            tabquanlixuatkho.Controls.Add(xk);

            tabdanhsachsp.Controls.Add(lv);
            tabdanhsachsp.Controls.Add(tsp);
            tabdanhsachsp.Controls.Add(dssp);

            tabdanhsachnv.Controls.Add(nv);

            tabquanlinhapkho.Controls.Add(dstk);
            tabquanlixuatkho.Controls.Add(tkxk);

            pnthongke.Controls.Add(cv);

            tp.Dock = DockStyle.Fill;
            lv.Dock = DockStyle.Fill;
            dssp.Dock = DockStyle.Fill;
            tsp.Dock = DockStyle.Fill;
            dspn.Dock = DockStyle.Fill;
            xk.Dock = DockStyle.Fill;
            nv.Dock = DockStyle.Fill;
            nccv.Dock = DockStyle.Fill;
            dstk.Dock = DockStyle.Fill;
            tkxk.Dock = DockStyle.Fill;
            cv.Dock = DockStyle.Fill; 
        }

        login lg;
        loaiview lv = new loaiview();
        nhacungcapview nccv = new nhacungcapview();
        danhsachphieunhaphangview dspn = new danhsachphieunhaphangview();
        danhsachsanphamview dssp = new danhsachsanphamview();
        nhanvienview nv = new nhanvienview();
        taophieunhaphangview tp = new taophieunhaphangview();
        themsanphamview tsp = new themsanphamview();
        xuatkhoview xk = new xuatkhoview();
        danhsachtonkhoview dstk = new danhsachtonkhoview();
        thongkexuatkhoview tkxk = new thongkexuatkhoview();
        chartview cv = new chartview();

        //private int madonnhap;

        //id của nhân viên đang đăng nhập
        public string manvdangnhap;
        #region dangnhap
        //đăng nhập
        private void button24_Click(object sender, EventArgs e)
        {
            nhanvienbus bus = new nhanvienbus();
            if (bus.dangnhap(lg.tendangnhap, lg.matkhau))
            {
                currentuser.user = lg.tendangnhap;
                manvdangnhap = currentuser.user;
                tp.nvdangnhap = currentuser.user;
                xk.nvdangnhap = currentuser.user;

                if (bus.phanquyen(currentuser.user) == false)
                {
                    tabthongke.TabPages.Remove(tabdanhsachnv);
                    admin.phanquyen = false;
                }
                else admin.phanquyen = true;

                tabthongke.SelectedTab = tabtrangchinh;
                pndangnhapuser.Visible = false;
                common.ClearOnlyTextBoxes(pndangnhapuser);
                tabthongke.Visible = true;
                lg.Visible = false;
                chaolbl.Text = "Chào bạn vào giao diện chính";
                idnvlbl.Text = "ID nhân viên: " + manvdangnhap;
                tennvlbl.Text = "Tên nhân viên: " + bus.getname(manvdangnhap);
            }
            else
            {
                MessageBox.Show("Sai ID hoặc mật khẩu");
            }
        }

        #endregion
        
        #region menu

        //danh sách nhân viên
        private void btndanhsachnhanvien_Click(object sender, EventArgs e)
        {
            HidePanels(tabdanhsachnv);
            nv.Visible = true;
        }

        //mở panel taodonnhap để tạo phiếu nhập hàng
        private void taodonnhapkho_Click(object sender, EventArgs e)
        {
            if (listnhacungcap())
            {
                HidePanels(tabquanlinhapkho);
                tp.Visible = true;
                tp.loadlistnhacc();
            }
        }

        //mở panel danh sách phiếu nhập hàng
        private void suathongtindonnhap_Click(object sender, EventArgs e)
        {
            HidePanels(tabquanlinhapkho);
            dspn.Visible = true;
            dspn.loadcombobox();
        }

        //mở panel để thêm sản phẩm
        private void themsanphambtn_Click(object sender, EventArgs e)
        {
            //lấy mã loại vào combobox nếu có thì mới mở panel sản phẩm
            if (listmaloai())
            {
                HidePanels(tabdanhsachsp);
                tsp.Visible = true;
                tsp.loadcombobox();
            } 
        }

        //mở panel loại sản phẩm
        private void button21_Click(object sender, EventArgs e)
        {
            HidePanels(tabdanhsachsp);
            lv.Visible = true;
        }

        //mở panel nhà cung cấp
        private void button20_Click(object sender, EventArgs e)
        {
            HidePanels(tabquanlinhapkho);
            nccv.Visible = true;
        }

        //mở panel danh sách sản phẩm
        private void danhsachvasuaspbtn_Click(object sender, EventArgs e)
        {
            HidePanels(tabdanhsachsp);
            dssp.Visible = true;
            dssp.loadcombobox();
        }

        //mở panel xuất kho
        private void button6_Click(object sender, EventArgs e)
        {
            HidePanels(tabquanlixuatkho);
            xk.Visible = true;
        }

        //mở panel danh sách tồn kho
        private void btndanhsachtonkho_Click(object sender, EventArgs e)
        {
            HidePanels(tabquanlinhapkho);
            dstk.Visible = true;
        }
        //mở panel danh sách xuất kho
        private void button2_Click(object sender, EventArgs e)
        {
            HidePanels(tabquanlixuatkho);
            tkxk.Visible = true;
            tkxk.BindAutoCompleteList();
        }

        //nút back tất cả mọi thứ
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switch (tabthongke.SelectedIndex)
            {
                case 0:
                    { }
                    break;
                case 1:
                    {
                        if (tp.Visible == true)
                        {
                            tp.hoantat();
                        }
                        HidePanels(tabquanlinhapkho);
                        qlnhapkho.Visible = true;
                    }
                    break;
                case 2:
                    {
                        HidePanels(tabquanlixuatkho);
                        qlxuatkho.Visible = true;
                    }
                    break;
                case 3:
                    {
                        HidePanels(tabdanhsachsp);
                        danhsachsanpham.Visible = true;
                    }
                    break;
                case 4:
                    {
                        HidePanels(tabthongketimkiem);
                        pnthongke.Visible = true;
                    }
                    break;
                case 5:
                    {
                        nhanvienbus bus = new nhanvienbus();
                        if (bus.phanquyen(currentuser.user) == true)
                        {
                            HidePanels(tabdanhsachnv);
                            pnnhanvien.Visible = true;
                        }
                    }
                    break;
            }
        }
        #endregion

        #region special function


        //ẩn hết panel
        private void HidePanels()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    c.Visible = false;
                }
            }
        }

        //ẩn hết panel trong 1 panel
        //private void HidePanels(Panel pn)
        //{
        //    foreach (Control c in pn.Controls)
        //    {
        //        if (c is Panel)
        //        {
        //            c.Visible = false;
        //        }
        //    }
        //}

        private void HidePanels(TabPage tp)
        {
            foreach (Control c in tp.Controls)
            {
                if (c is UserControl)
                {
                    c.Visible = false;
                }
                if (c is Panel)
                {
                    c.Visible = false;
                }
            }
        }

        //lấy mã loại vào combobox
        private bool listmaloai()
        {
            loaibus bus = new loaibus();
            //nếu có loại sản phẩm
            if (bus.any())
                return true;
            //nếu không có thì hỏi có nhập không
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chưa nhập các loại sản phẩm mà bạn sẽ bán (VD: Nước ngọt, Snack,...)" + "\n" + "Vào thêm loại sản phẩm mới?", "Chưa nhập loại sản phẩm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    button21.PerformClick();

                }
                else if (dialogResult == DialogResult.No)
                {
                    //tabControl1.SelectedTab = tabPage1;
                }
                return false;
            }
        }

        //load mã nhà cung cấp vào combobox
        private bool listnhacungcap()
        {
            nhacungcapbus bus = new nhacungcapbus();
            if (bus.any())
            {
                return true;
            }
            //nếu không có thì hỏi có nhập không
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chưa có nhà cung cấp" + "\n" + "Vào thêm nhà cung cấp mới?", "Chưa có nhà cung cấp", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    button20.PerformClick();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //tabControl1.SelectedTab = tabPage1;
                }
                return false;
            }

        }

        #endregion

        public string madnvangnhap { get; set; }

        private void logout_Click(object sender, EventArgs e)
        {
            currentuser.user = "";
            tabthongke.Visible = false;
            pndangnhapuser.Visible = true;
            lg.Visible = true;
        }
    }
}
