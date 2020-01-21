using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Main_program
{
    public partial class Form3 : Form
    {
        public List<Data> pretenders = new List<Data>();
        string filename;
        public Form1 f1;
        public Form3(string filename,Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            this.filename = filename;
            dataGridView1.AllowUserToAddRows = false;
            saveFileDialog1.Filter = "Файл Excel|*.xlsx;*.xls";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            _Workbook ExcelWorkBook;
            Worksheet ExcelWorkSheet;

            ExcelWorkBook = ExcelApp.Workbooks.Open(filename, 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            ExcelWorkSheet = (Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            Range ExcelRange = ExcelWorkSheet.UsedRange;
            for (int i = 0; i < ExcelRange.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(1);
                for (int j = 0; j < 7; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = ExcelApp.Cells[i + 1, j + 1].Value;
                }
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                Data e1 = new Data(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value), dataGridView1.Rows[i].Cells[2].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString(), dataGridView1.Rows[i].Cells[4].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value), dataGridView1.Rows[i].Cells[6].Value.ToString());
                pretenders.Add(e1);
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(1);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.RowCount - 1;
            try
            {
                dataGridView1.Rows.RemoveAt(count);
            }
            catch
            {
                MessageBox.Show("Невозможно удалить строку");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            pretenders.Clear();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                Data e1 = new Data(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value), dataGridView1.Rows[i].Cells[2].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString(), dataGridView1.Rows[i].Cells[4].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value), dataGridView1.Rows[i].Cells[6].Value.ToString());
                pretenders.Add(e1);
            }

            f1.OnTextBoxChanged(pretenders);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string path = saveFileDialog1.FileName;
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            _Workbook ExcelWorkBook = ExcelApp.Workbooks.Add();
            Worksheet ExcelWorkSheet = ExcelWorkBook.ActiveSheet;
            for (int i = 1; i < dataGridView1.RowCount + 1; i++)
            {
                for (int j = 1; j < dataGridView1.ColumnCount + 1; j++)
                {
                    ExcelWorkSheet.Rows[i].Columns[j] = dataGridView1.Rows[i - 1].Cells[j - 1].Value;
                }
            }
            ExcelApp.AlertBeforeOverwriting = false;
            ExcelWorkBook.SaveAs(path);
            ExcelApp.Quit();
        }
    }
}
