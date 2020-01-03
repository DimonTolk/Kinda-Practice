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

        private void иностранномуЯзыкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> pret = new List<string>();
                textBox2.Clear();
                var find = textBox3.Text;
                foreach (var t in form1.pretenders)
                {
                    if (t.language == find)
                    {
                        pret.Add(t.FIO);
                    }
                }
                if (pret.Count == 0)
                {
                    MessageBox.Show("Ничего не найдено");
                    return;
                }
                textBox2.Text = string.Join(Environment.NewLine, pret);
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }

        private void уровнюЯзыкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> pret = new List<string>();
                textBox2.Clear();
                var find = textBox3.Text;
                foreach (var t in form1.pretenders)
                {
                    if (t.levelOfLanguage == find)
                    {
                        pret.Add(t.FIO);
                    }
                }
                if (pret.Count == 0)
                {
                    MessageBox.Show("Ничего не найдено");
                    return;
                }
                textBox2.Text = string.Join(Environment.NewLine, pret);
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }

        private void уровнюВладенияКомпьютеромToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> pret = new List<string>();
                textBox2.Clear();
                var find = textBox3.Text;
                foreach (var t in form1.pretenders)
                {
                    if (t.computerSkill == Convert.ToInt32(find))
                    {
                        pret.Add(t.FIO);
                    }
                }
                if (pret.Count == 0)
                {
                    MessageBox.Show("Ничего не найдено");
                    return;
                }
                textBox2.Text = string.Join(Environment.NewLine, pret);
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }

        private void образованиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> pret = new List<string>();
                textBox2.Clear();
                var find = textBox3.Text;
                foreach (var t in form1.pretenders)
                {
                    if (t.education == find)
                    {
                        pret.Add(t.FIO);
                    }
                }
                if (pret.Count == 0)
                {
                    MessageBox.Show("Ничего не найдено");
                    return;
                }
                textBox2.Text = string.Join(Environment.NewLine, pret);
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }
    }
}
