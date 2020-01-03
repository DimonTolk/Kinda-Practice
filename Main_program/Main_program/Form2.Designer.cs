namespace Main_program
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выбратьПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иностранномуЯзыкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровнюЯзыкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровнюВладенияКомпьютеромToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.образованиюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(303, 285);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьПоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выбратьПоToolStripMenuItem
            // 
            this.выбратьПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.иностранномуЯзыкуToolStripMenuItem,
            this.уровнюЯзыкаToolStripMenuItem,
            this.уровнюВладенияКомпьютеромToolStripMenuItem,
            this.образованиюToolStripMenuItem});
            this.выбратьПоToolStripMenuItem.Name = "выбратьПоToolStripMenuItem";
            this.выбратьПоToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.выбратьПоToolStripMenuItem.Text = "Выбрать по...";
            // 
            // иностранномуЯзыкуToolStripMenuItem
            // 
            this.иностранномуЯзыкуToolStripMenuItem.Name = "иностранномуЯзыкуToolStripMenuItem";
            this.иностранномуЯзыкуToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.иностранномуЯзыкуToolStripMenuItem.Text = "Иностранному языку";
            this.иностранномуЯзыкуToolStripMenuItem.Click += new System.EventHandler(this.иностранномуЯзыкуToolStripMenuItem_Click);
            // 
            // уровнюЯзыкаToolStripMenuItem
            // 
            this.уровнюЯзыкаToolStripMenuItem.Name = "уровнюЯзыкаToolStripMenuItem";
            this.уровнюЯзыкаToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.уровнюЯзыкаToolStripMenuItem.Text = "Уровню языка";
            this.уровнюЯзыкаToolStripMenuItem.Click += new System.EventHandler(this.уровнюЯзыкаToolStripMenuItem_Click);
            // 
            // уровнюВладенияКомпьютеромToolStripMenuItem
            // 
            this.уровнюВладенияКомпьютеромToolStripMenuItem.Name = "уровнюВладенияКомпьютеромToolStripMenuItem";
            this.уровнюВладенияКомпьютеромToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.уровнюВладенияКомпьютеромToolStripMenuItem.Text = "Уровню владения компьютером";
            this.уровнюВладенияКомпьютеромToolStripMenuItem.Click += new System.EventHandler(this.уровнюВладенияКомпьютеромToolStripMenuItem_Click);
            // 
            // образованиюToolStripMenuItem
            // 
            this.образованиюToolStripMenuItem.Name = "образованиюToolStripMenuItem";
            this.образованиюToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.образованиюToolStripMenuItem.Text = "Образованию";
            this.образованиюToolStripMenuItem.Click += new System.EventHandler(this.образованиюToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(438, 53);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(338, 273);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(278, 385);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 29);
            this.textBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Подходящие претенденты";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Поиск и выборка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбратьПоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem иностранномуЯзыкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровнюЯзыкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровнюВладенияКомпьютеромToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem образованиюToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
    }
}