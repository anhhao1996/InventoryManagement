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
    public partial class nhacungcapview : UserControl
    {
        public nhacungcapview()
        {
            InitializeComponent();
        }

        #region nhacungcap

        //nhập nhà cung cấp mới
        private void button3_Click(object sender, EventArgs e)
        {
            NHACUNGCAP entity = new NHACUNGCAP();
            entity.MANHACUNGCAP = manhacungcaptxt.Text;
            entity.TENNHACUNGCAP = tennhacungcaptxt.Text;
            entity.DIACHI = diachinhacungcaptxt.Text;
            entity.DIENTHOAI = dienthoainhacungcaptxt.Text;
            nhacungcapbus bus = new nhacungcapbus();
            bool success = bus.add(entity);
            common.successorerror(success);
            if (success)
            {
                errorProvider1.Clear();     
            }
            else
            {
                ViewErrors(bus.validatedictionary);
            }
        }

        //lấy danh sách nhà cung cấp
        private void button5_Click(object sender, EventArgs e)
        {
            nhacungcapbus bus = new nhacungcapbus();
            nhacungcapdgv.DataSource = bus.list();
            nhacungcapdgv.Columns["MANHACUNGCAP"].HeaderText = "Mã nhà cung cấp";
            nhacungcapdgv.Columns["TENNHACUNGCAP"].HeaderText = "Tên nhà cung cấp";
            nhacungcapdgv.Columns["DIACHI"].HeaderText = "Địa chỉ";
            nhacungcapdgv.Columns["DIENTHOAI"].HeaderText = "Điện thoại";
            nhacungcapdgv.Columns["PHIEUNHAPHANGs"].Visible = false;

        }

        //tìm kiếm nhà cung cấp
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nhacungcapbus bus = new nhacungcapbus();
            nhacungcapdgv.DataSource = bus.findall(textBox1.Text);
            nhacungcapdgv.Columns["PHIEUNHAPHANGs"].Visible = false;
        }

        //sửa nhà cung cấp
        private void button8_Click(object sender, EventArgs e)
        {
            NHACUNGCAP entity = new NHACUNGCAP();
            entity.MANHACUNGCAP = suamanhacungcaptxt.Text;
            entity.TENNHACUNGCAP = suatennhacungcaptxt.Text;
            entity.DIACHI = suadiachinhacungcaptxt.Text;
            entity.DIENTHOAI = suadienthoainhacungcaptxt.Text;

            nhacungcapbus bus = new nhacungcapbus();

            bool success = bus.update(entity);
            common.successorerror(success);
            if (success)
            {
                errorProvider1.Clear();
                common.ClearTextBoxes(tabPage9);
                nhacungcapdgv.DataSource = bus.findall(textBox1.Text);
                nhacungcapdgv.Columns["PHIEUNHAPHANGs"].Visible = false;
            }
            else
            {
                ViewErrors(bus.validatedictionary);
            }
        }

        //xóa nhà cung cấp
        private void button11_Click(object sender, EventArgs e)
        {
            NHACUNGCAP entity = new NHACUNGCAP();
            entity.MANHACUNGCAP = suamanhacungcaptxt.Text;
            entity.TENNHACUNGCAP = suatennhacungcaptxt.Text;
            entity.DIACHI = suadiachinhacungcaptxt.Text;
            entity.DIENTHOAI = suadienthoainhacungcaptxt.Text;

            nhacungcapbus bus = new nhacungcapbus();

            bool success = bus.delete(entity);
            common.successorerror(success);
            if (success)
            {
                common.ClearTextBoxes(tabPage9);
                nhacungcapdgv.DataSource = bus.findall(textBox1.Text);
                nhacungcapdgv.Columns["PHIEUNHAPHANGs"].Visible = false;
            }
        }

        //load dữ liệu lên textbox nhacungcap khi double_click
        private void nhacungcapdgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.nhacungcapdgv.Rows[e.RowIndex];
                suamanhacungcaptxt.Text = row.Cells["MANHACUNGCAP"].Value.ToString();
                suatennhacungcaptxt.Text = row.Cells["TENNHACUNGCAP"].Value.ToString();
                suadiachinhacungcaptxt.Text = row.Cells["DIACHI"].Value.ToString();
                suadienthoainhacungcaptxt.Text = row.Cells["DIENTHOAI"].Value.ToString();
            }
        }

        private void ViewErrors(Dictionary<string, string> Dictionary)
        {
            errorProvider1.Clear();
            foreach (var entry in Dictionary)
            {
                switch (entry.Key)
                {
                    case "MANHACUNGCAP":
                        errorProvider1.SetError(manhacungcaptxt, entry.Value);
                        break;
                    case "TENNHACUNGCAP":
                        errorProvider1.SetError(tennhacungcaptxt, entry.Value);
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
    }
}
