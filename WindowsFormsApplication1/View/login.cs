using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace WindowsFormsApplication1.View
{
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
            

        }
        public string tendangnhap
        {
            get { return textBox6.Text; }

        }

        public string matkhau
        {
            get { return textBox7.Text; }
        }

        public EventHandler dangnhap;
        private void button24_Click(object sender, EventArgs e)
        {
            dangnhap(sender, e);
        }

        private void textBox7_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button24.PerformClick();
            }
        }

       
    }
}
