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
        public string filename = "lastsave.txt";
        public Form2 form2;
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filename = openFileDialog1.FileName;
            textBox9.Clear();
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    file.Add(line);
                }
            }
            textBox9.Lines = file.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            BinaryFormatter BF = new BinaryFormatter();
            using (FileStream fs = new FileStream("res.txt", FileMode.OpenOrCreate))
            {
                BF.Serialize(fs, pretenders);
                MessageBox.Show($"Объект сериализован {Data.SerializationDate}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            file = textBox9.Lines.ToList();
            form2 = new Form2(this);
            form2.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения перед выходом?", "Выход", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = false;
            }
            else
            {
                File.WriteAllText(filename, textBox9.Text);
                e.Cancel = false;
            }
        }
    }
}
