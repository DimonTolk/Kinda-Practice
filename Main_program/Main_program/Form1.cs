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
        public string[] file = new string[100];
        public string[] fileAFterChanges = new string[100];
        public List<Data> pretenders = new List<Data>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"E:\(1)3 курс\ПРАКТИКА\Program\Main_program\input.txt"))
            {
                int i = 0;
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    file[i] = line;
                    i++;
                }
            }
            textBox9.Lines = file;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"E:\(1)3 курс\ПРАКТИКА\Program\Main_program\input.txt"))
            {
                string[] buf = textBox9.Lines;
                foreach (var t in buf)
                {
                    sw.WriteLine(t);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BinaryFormatter BF = new BinaryFormatter();
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                BF.Serialize(fs, pretenders);
                MessageBox.Show($"Объект сериализован {Data.SerializationDate}");
            }
        }
        
    }
}
