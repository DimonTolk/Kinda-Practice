using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_program
{
    public partial class Form2 : Form
    {
        public Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Lines = form1.file.ToArray();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBox1.Clear();
        }
    }
}
