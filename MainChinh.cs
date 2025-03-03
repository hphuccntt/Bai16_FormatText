using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai16_FormatText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formatTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatText formatText = new FormatText();
            formatText.MdiParent = this;
            formatText.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ten = " Lương Hoàng Phúc";
            lblInfo.Text = " Họ Và Tên Thí Sinh: " + ten + Environment.NewLine;
            lblInfo.Text += " Ngày Viết Chương Trình: " + System.DateTime.Now;
        }
    }
}
