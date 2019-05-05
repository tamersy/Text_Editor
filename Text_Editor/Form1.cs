using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.ForeColor = this.colorDialog1.Color;
            this.richTextBox1.Font = this.fontDialog1.Font;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();
        }
    }
}
