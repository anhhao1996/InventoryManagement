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
    public partial class nhanvienview : UserControl
    {
        public nhanvienview()
        {
            InitializeComponent();

            tabControl5.SelectedTab = tabPage16;
            //suarepass.PasswordChar = '*';
            suatxtmatkhau.PasswordChar = '*';

            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("User");

            comboBox1.SelectedItem = "User";

            comboBox2.Items.Add("Admin");
            comboBox2.Items.Add("User");

            comboBox2.SelectedItem = "User";
        }

        #region nhanvien
        //thêm nhân viên
        private void button35_Click(object sender, EventArgs e)
        {

            NHANVIEN entity = new NHANVIEN();
            nhanvienbus bus = new nhanvienbus();
            entity.MANV = textBox11.Text;
            entity.TENNV = textBox16.Text;
            entity.DIACHI = textBox17.Text;
            entity.DIENTHOAI = textBox18.Text;
            entity.NGAYSINH = dateTimePicker5.Value.Date;
            entity.MATKHAU = txtpass.Text;

            //   var item = this.comboBox1.GetItemText(this.comboBox1.FindStringExact("Admin"));
            // entity.PHANQUYEN = Convert.ToString(item);
            if (comboBox1.SelectedItem.Equals("Admin"))
            {
                entity.PHANQUYEN = true;
            }
            else if (comboBox1.SelectedItem.Equals("User"))
            {
                entity.PHANQUYEN = false;
            }

            if (txtpass.Text != txtrepass.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool success = bus.add(entity);
                if (success)
                {
                    common.successorerror(success);
                }
                else
                {
                    ViewErrors(bus.validatedictionary);
                }
            }
        }
        //load list nhan vien
        private void button38_Click(object sender, EventArgs e)
        {

            nhanvienbus bus = new nhanvienbus();
            thanhviendgv.DataSource = bus.list();
            thanhviendgv.Columns["MANV"].HeaderText = "Mã nhân viên";
            thanhviendgv.Columns["TENNV"].HeaderText = "Tên nhân viên";
            thanhviendgv.Columns["DIACHI"].HeaderText = "Địa chỉ";
            thanhviendgv.Columns["DIENTHOAI"].HeaderText = "Điện thoại";
            thanhviendgv.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            thanhviendgv.Columns["NHANVIENs"].Visible = false;
            thanhviendgv.Columns["MATKHAU"].Visible = false;
            thanhviendgv.Columns["PHANQUYEN"].Visible = false;
            thanhviendgv.Columns["XUATKHOes"].Visible = false;
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

            nhanvienbus bus = new nhanvienbus();
            thanhviendgv.DataSource = bus.findall(textBox19.Text);
            thanhviendgv.Columns["MANV"].HeaderText = "Mã nhân viên";
            thanhviendgv.Columns["TENNV"].HeaderText = "Tên nhân viên";
            thanhviendgv.Columns["DIACHI"].HeaderText = "Địa chỉ";
            thanhviendgv.Columns["DIENTHOAI"].HeaderText = "Điện thoại";
            thanhviendgv.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            thanhviendgv.Columns["NHANVIENs"].Visible = false;
            thanhviendgv.Columns["MATKHAU"].Visible = false;
            thanhviendgv.Columns["PHANQUYEN"].Visible = false;
            thanhviendgv.Columns["XUATKHOes"].Visible = false;
        }

        //nut cap nhap nhan vien
        private void button37_Click(object sender, EventArgs e)
        {
            NHANVIEN entity = new NHANVIEN();
            entity.MANV = suatxtidnhanvien.Text;
            entity.TENNV = suatxtten.Text;
            entity.MATKHAU = suatxtmatkhau.Text;
            entity.NGAYSINH = dateTimePicker6.Value.Date;
            entity.DIACHI = suatxtdiachi.Text;
            entity.DIENTHOAI = suatxtsdt.Text;
            // entity.PHANQUYEN = suatxtphanquyen.Text;
            if (comboBox2.SelectedItem.Equals("Admin"))
            {
                entity.PHANQUYEN = true;
            }
            else if (comboBox2.SelectedItem.Equals("User"))
            {
                entity.PHANQUYEN = false;
            }
            nhanvienbus bus = new nhanvienbus();

            bool success = bus.update(entity);
            common.successorerror(success);
            if (success)
            {
                common.ClearTextBoxes(tabPage17);
                thanhviendgv.DataSource = bus.findall(textBox19.Text);
                thanhviendgv.Columns["NHANVIENs"].Visible = false;
            }
            else
            {
                ViewErrors(bus.validatedictionary);
            }
        }
        //double lick de sua thong tin nhan vien
        private void nhanviendgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.thanhviendgv.Rows[e.RowIndex];
                suatxtidnhanvien.Text = row.Cells["MANV"].Value.ToString();
                suatxtten.Text = row.Cells["TENNV"].Value.ToString();
                suatxtdiachi.Text = row.Cells["DIACHI"].Value.ToString();
                suatxtsdt.Text = row.Cells["DIENTHOAI"].Value.ToString();
                suatxtmatkhau.Text = row.Cells["MATKHAU"].Value.ToString();
                if (row.Cells["PHANQUYEN"].Value.ToString().Equals("True"))
                {
                    comboBox2.Text = "Admin";
                }
                else
                {
                    comboBox2.Text = "User";
                }
            }
        }
        //xoa user
        private void button36_Click(object sender, EventArgs e)
        {
            NHANVIEN entity = new NHANVIEN();
            entity.MANV = suatxtidnhanvien.Text;
            entity.TENNV = suatxtten.Text;
            entity.MATKHAU = suatxtmatkhau.Text;
            entity.DIACHI = suatxtdiachi.Text;
            entity.DIENTHOAI = suatxtsdt.Text;


            nhanvienbus bus = new nhanvienbus();

            bool success = bus.delete(entity);
            common.successorerror(success);
            if (success)
            {
                common.ClearTextBoxes(tabPage17);
                thanhviendgv.DataSource = bus.findall(textBox19.Text);
                thanhviendgv.Columns["NHANVIENs"].Visible = false;
            }
        }
        private void camsuabox2(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void camsuabox1(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;

        }

        private void ViewErrors(Dictionary<string, string> Dictionary)
        {
            errorProvider1.Clear();
            foreach (var entry in Dictionary)
            {
                switch (entry.Key)
                {
                    case "MANV":
                        errorProvider1.SetError(textBox11, entry.Value);
                        break;
                    case "TENNV":
                        if (tabControl5.SelectedTab == tabPage16)
                            errorProvider1.SetError(textBox16, entry.Value);
                        else
                            errorProvider2.SetError(suatxtten, entry.Value);
                        break;
                    case "MATKHAU":
                        if (tabControl5.SelectedTab == tabPage16)
                            errorProvider1.SetError(txtpass, entry.Value);
                        else
                            errorProvider2.SetError(suatxtmatkhau, entry.Value);
                        break;
                    case "DIACHI":
                        if (tabControl5.SelectedTab == tabPage16)
                            errorProvider1.SetError(textBox17, entry.Value);
                        else
                            errorProvider2.SetError(suatxtdiachi, entry.Value);
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
    }
}
