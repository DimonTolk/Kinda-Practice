namespace Main_program
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сериализацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.десериализацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортироватьЛистExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поФИОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поГодуРожденияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поОбразованиюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поИностранномуЯзыкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУровнюЗнанияЯзыкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУровнюВладенияКомпьютеромToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(12, 27);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(878, 567);
            this.textBox9.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.найтиToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.справкаToolStripMenuItem1,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.сериализацияToolStripMenuItem,
            this.десериализацияToolStripMenuItem,
            this.импортироватьЛистExcelToolStripMenuItem,
            this.toolStripSeparator1,
            this.печатьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить текстовый файл";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сериализацияToolStripMenuItem
            // 
            this.сериализацияToolStripMenuItem.Name = "сериализацияToolStripMenuItem";
            this.сериализацияToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.сериализацияToolStripMenuItem.Text = "Сериализация";
            this.сериализацияToolStripMenuItem.Click += new System.EventHandler(this.сериализацияToolStripMenuItem_Click);
            // 
            // десериализацияToolStripMenuItem
            // 
            this.десериализацияToolStripMenuItem.Name = "десериализацияToolStripMenuItem";
            this.десериализацияToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.десериализацияToolStripMenuItem.Text = "Десериализация";
            this.десериализацияToolStripMenuItem.Click += new System.EventHandler(this.десериализацияToolStripMenuItem_Click);
            // 
            // импортироватьЛистExcelToolStripMenuItem
            // 
            this.импортироватьЛистExcelToolStripMenuItem.Name = "импортироватьЛистExcelToolStripMenuItem";
            this.импортироватьЛистExcelToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.импортироватьЛистExcelToolStripMenuItem.Text = "Импортировать лист Excel";
            this.импортироватьЛистExcelToolStripMenuItem.Click += new System.EventHandler(this.импортироватьЛистExcelToolStripMenuItem_Click);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.найтиToolStripMenuItem.Text = "Найти...";
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.найтиToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поФИОToolStripMenuItem,
            this.поГодуРожденияToolStripMenuItem,
            this.поОбразованиюToolStripMenuItem,
            this.поИностранномуЯзыкуToolStripMenuItem,
            this.поУровнюЗнанияЯзыкаToolStripMenuItem,
            this.поУровнюВладенияКомпьютеромToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поФИОToolStripMenuItem
            // 
            this.поФИОToolStripMenuItem.Name = "поФИОToolStripMenuItem";
            this.поФИОToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.поФИОToolStripMenuItem.Text = "По ФИО";
            this.поФИОToolStripMenuItem.Click += new System.EventHandler(this.поФИОToolStripMenuItem_Click);
            // 
            // поГодуРожденияToolStripMenuItem
            // 
            this.поГодуРожденияToolStripMenuItem.Name = "поГодуРожденияToolStripMenuItem";
            this.поГодуРожденияToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.поГодуРожденияToolStripMenuItem.Text = "По году рождения";
            this.поГодуРожденияToolStripMenuItem.Click += new System.EventHandler(this.поГодуРожденияToolStripMenuItem_Click);
            // 
            // поОбразованиюToolStripMenuItem
            // 
            this.поОбразованиюToolStripMenuItem.Name = "поОбразованиюToolStripMenuItem";
            this.поОбразованиюToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.поОбразованиюToolStripMenuItem.Text = "По образованию";
            this.поОбразованиюToolStripMenuItem.Click += new System.EventHandler(this.поОбразованиюToolStripMenuItem_Click);
            // 
            // поИностранномуЯзыкуToolStripMenuItem
            // 
            this.поИностранномуЯзыкуToolStripMenuItem.Name = "поИностранномуЯзыкуToolStripMenuItem";
            this.поИностранномуЯзыкуToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.поИностранномуЯзыкуToolStripMenuItem.Text = "По иностранному языку";
            this.поИностранномуЯзыкуToolStripMenuItem.Click += new System.EventHandler(this.поИностранномуЯзыкуToolStripMenuItem_Click);
            // 
            // поУровнюЗнанияЯзыкаToolStripMenuItem
            // 
            this.поУровнюЗнанияЯзыкаToolStripMenuItem.Name = "поУровнюЗнанияЯзыкаToolStripMenuItem";
            this.поУровнюЗнанияЯзыкаToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.поУровнюЗнанияЯзыкаToolStripMenuItem.Text = "По уровню знания языка";
            this.поУровнюЗнанияЯзыкаToolStripMenuItem.Click += new System.EventHandler(this.поУровнюЗнанияЯзыкаToolStripMenuItem_Click);
            // 
            // поУровнюВладенияКомпьютеромToolStripMenuItem
            // 
            this.поУровнюВладенияКомпьютеромToolStripMenuItem.Name = "поУровнюВладенияКомпьютеромToolStripMenuItem";
            this.поУровнюВладенияКомпьютеромToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.поУровнюВладенияКомпьютеромToolStripMenuItem.Text = "По уровню владения компьютером";
            this.поУровнюВладенияКомпьютеромToolStripMenuItem.Click += new System.EventHandler(this.поУровнюВладенияКомпьютеромToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справкаToolStripMenuItem.Text = "О программе";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem1.Text = "Справка";
            this.справкаToolStripMenuItem1.Click += new System.EventHandler(this.справкаToolStripMenuItem1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 606);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Помощник нанимателя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сериализацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поФИОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поГодуРожденияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поОбразованиюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поИностранномуЯзыкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУровнюЗнанияЯзыкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУровнюВладенияКомпьютеромToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem десериализацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортироватьЛистExcelToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

