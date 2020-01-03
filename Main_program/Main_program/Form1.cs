using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Main_program
{
    public partial class Form1 : Form
    {
        public List<Data> pretenders = new List<Data>();
        public List<string> file = new List<string>();
        public string filename1 = "lastsave.txt";
        public Form2 form2;
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения перед выходом?", "Выход", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = false;
            }
            else
            {
                File.WriteAllText(filename1, textBox9.Text);
                e.Cancel = false;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            File.WriteAllText(filename, textBox9.Text);
            file = textBox9.Lines.ToList();
            MessageBox.Show("Файл сохранен");
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            textBox9.Clear();
            file.Clear();
            using (StreamReader sr = new StreamReader(filename))
            {
                while (!sr.EndOfStream)
                {
                    pretenders.Add(new Data(sr.ReadLine(), Convert.ToInt32(sr.ReadLine()), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(),Convert.ToInt32(sr.ReadLine()), sr.ReadLine()));
                }
            }
            textBox9.Lines = File.ReadLines(openFileDialog1.FileName).ToArray();
            file = textBox9.Lines.ToList();
        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file = textBox9.Lines.ToList();
            form2 = new Form2(this);
            form2.Show();
        }

        private void сериализацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter BF = new BinaryFormatter();
                using (FileStream fs = new FileStream("res.txt", FileMode.OpenOrCreate))
                {
                    BF.Serialize(fs, pretenders);
                    MessageBox.Show($"Объект сериализован {Data.SerializationDate}");
                }
            }
            catch when (pretenders.Count == 0)
            {
                MessageBox.Show("Нечего сериализовать");
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа <<Помощник нанимателя>> выполнена в качестве задания на практику учащимся 3 курса группы 7к2492 Толкачёвым Дмитрием");
        }

        private void поФИОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pretenders = pretenders.OrderBy(c => c.FIO).ToList();
            textBox9.Text = string.Join(Environment.NewLine, pretenders);
        }

        private void поОбразованиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pretenders = pretenders.OrderBy(c => c.education).ToList();
            textBox9.Text = string.Join(Environment.NewLine, pretenders);
        }

        private void поГодуРожденияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pretenders = pretenders.OrderBy(c => c.year).ToList();
            textBox9.Text = string.Join(Environment.NewLine, pretenders);
        }

        private void поИностранномуЯзыкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pretenders = pretenders.OrderBy(c => c.language).ToList();
            textBox9.Text = string.Join(Environment.NewLine, pretenders);
        }

        private void поУровнюЗнанияЯзыкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pretenders = pretenders.OrderBy(c => c.levelOfLanguage).ToList();
            textBox9.Text = string.Join(Environment.NewLine, pretenders);
        }

        private void поУровнюВладенияКомпьютеромToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pretenders = pretenders.OrderBy(c => c.computerSkill).ToList();
            textBox9.Text = string.Join(Environment.NewLine, pretenders);
        }

        
    }
}
