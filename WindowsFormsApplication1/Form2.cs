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
using WindowsFormsApplication1.View;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            tabPage3.Controls.Add(cv);
        }
        chartview cv = new chartview();

        private void button1_Click(object sender, EventArgs e)
        {
            NHACUNGCAP entity = new NHACUNGCAP();
            entity.MANHACUNGCAP = textBox1.Text;
            entity.TENNHACUNGCAP = textBox2.Text;
            entity.DIACHI = textBox3.Text;
            entity.DIENTHOAI = textBox4.Text;

            nhacungcapbus bus = new nhacungcapbus();
            if (bus.add(entity))
                MessageBox.Show("Nhập thành công");
            else
                MessageBox.Show("Lỗi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nhacungcapbus bus = new nhacungcapbus();
            dataGridView1.DataSource = bus.list();
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //Tao menu ngu canh
                ContextMenuStrip menu = new ContextMenuStrip();
                menu.Items.Add("Edit", null, new EventHandler(Edit_Click));
                menu.Items.Add("Delete", null, new EventHandler(Delete_Click));
                //Di chuyen den dong hien hanh
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                //hien thi menu
                Point pt = dataGridView1.PointToClient(Control.MousePosition);
                menu.Show(dataGridView1, pt.X, pt.Y);
            }
        }
        private void Edit_Click(object sender, EventArgs args)
        {
            textBox5.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textBox6.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textBox7.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textBox8.Text = dataGridView1.SelectedCells[3].Value.ToString();

            tabControl1.SelectedTab = tabPage4;
        }

        private void Delete_Click(object sender, EventArgs args)
        {
            NHACUNGCAP entity = new NHACUNGCAP();
            entity.MANHACUNGCAP = dataGridView1.SelectedCells[0].Value.ToString();
            entity.TENNHACUNGCAP = dataGridView1.SelectedCells[1].Value.ToString();
            entity.DIACHI = dataGridView1.SelectedCells[2].Value.ToString();
            entity.DIENTHOAI = dataGridView1.SelectedCells[3].Value.ToString();

            nhacungcapbus bus = new nhacungcapbus();
            if (bus.delete(entity))
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Lỗi");
            dataGridView1.DataSource = bus.list();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NHACUNGCAP entity = new NHACUNGCAP();
            entity.MANHACUNGCAP = textBox5.Text;
            entity.TENNHACUNGCAP = textBox6.Text;
            entity.DIACHI = textBox7.Text;
            entity.DIENTHOAI = textBox8.Text;

            nhacungcapbus bus = new nhacungcapbus();
            if (bus.update(entity))
                MessageBox.Show("Cập nhật thành công");
            else
                MessageBox.Show("Lỗi");
            dataGridView1.DataSource = bus.list();
        }
    }
}
