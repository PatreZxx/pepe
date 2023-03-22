namespace Knihohlad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.VyhladavanieInput = new System.Windows.Forms.TextBox();
            this.VyhladavanieButton = new System.Windows.Forms.Button();
            this.VyhladavanieNadpis = new System.Windows.Forms.Label();
            this.VyhladavanieComboBox = new System.Windows.Forms.ComboBox();
            this.PridatNadpis = new System.Windows.Forms.Label();
            this.PridatNazov = new System.Windows.Forms.TextBox();
            this.Názov = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PridatAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PridatKategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PridatCena = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PridajURL = new System.Windows.Forms.TextBox();
            this.Nazov = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Popis = new System.Windows.Forms.RichTextBox();
            this.PridatButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonOdstranit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // VyhladavanieInput
            // 
            this.VyhladavanieInput.BackColor = System.Drawing.Color.Gold;
            this.VyhladavanieInput.Location = new System.Drawing.Point(292, 136);
            this.VyhladavanieInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.VyhladavanieInput.Name = "VyhladavanieInput";
            this.VyhladavanieInput.Size = new System.Drawing.Size(228, 31);
            this.VyhladavanieInput.TabIndex = 1;
            // 
            // VyhladavanieButton
            // 
            this.VyhladavanieButton.BackColor = System.Drawing.Color.Black;
            this.VyhladavanieButton.ForeColor = System.Drawing.Color.Gold;
            this.VyhladavanieButton.Location = new System.Drawing.Point(547, 126);
            this.VyhladavanieButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.VyhladavanieButton.Name = "VyhladavanieButton";
            this.VyhladavanieButton.Size = new System.Drawing.Size(124, 51);
            this.VyhladavanieButton.TabIndex = 2;
            this.VyhladavanieButton.Text = "Vyhľadaj";
            this.VyhladavanieButton.UseVisualStyleBackColor = false;
            this.VyhladavanieButton.Click += new System.EventHandler(this.VyhladavanieButton_Click);
            // 
            // VyhladavanieNadpis
            // 
            this.VyhladavanieNadpis.AutoSize = true;
            this.VyhladavanieNadpis.BackColor = System.Drawing.Color.Transparent;
            this.VyhladavanieNadpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VyhladavanieNadpis.ForeColor = System.Drawing.Color.Gold;
            this.VyhladavanieNadpis.Location = new System.Drawing.Point(54, 47);
            this.VyhladavanieNadpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VyhladavanieNadpis.Name = "VyhladavanieNadpis";
            this.VyhladavanieNadpis.Size = new System.Drawing.Size(286, 52);
            this.VyhladavanieNadpis.TabIndex = 3;
            this.VyhladavanieNadpis.Text = "Vyhľadávanie";
            // 
            // VyhladavanieComboBox
            // 
            this.VyhladavanieComboBox.BackColor = System.Drawing.Color.Gold;
            this.VyhladavanieComboBox.FormattingEnabled = true;
            this.VyhladavanieComboBox.Items.AddRange(new object[] {
            "nazov",
            "autor",
            "kategoria",
            "cena"});
            this.VyhladavanieComboBox.Location = new System.Drawing.Point(63, 136);
            this.VyhladavanieComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.VyhladavanieComboBox.Name = "VyhladavanieComboBox";
            this.VyhladavanieComboBox.Size = new System.Drawing.Size(208, 33);
            this.VyhladavanieComboBox.TabIndex = 4;
            // 
            // PridatNadpis
            // 
            this.PridatNadpis.AutoSize = true;
            this.PridatNadpis.BackColor = System.Drawing.Color.Transparent;
            this.PridatNadpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PridatNadpis.ForeColor = System.Drawing.Color.Gold;
            this.PridatNadpis.Location = new System.Drawing.Point(1849, 126);
            this.PridatNadpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PridatNadpis.Name = "PridatNadpis";
            this.PridatNadpis.Size = new System.Drawing.Size(250, 52);
            this.PridatNadpis.TabIndex = 5;
            this.PridatNadpis.Text = "Pridaj knihu";
            // 
            // PridatNazov
            // 
            this.PridatNazov.Location = new System.Drawing.Point(1972, 238);
            this.PridatNazov.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PridatNazov.Name = "PridatNazov";
            this.PridatNazov.Size = new System.Drawing.Size(148, 31);
            this.PridatNazov.TabIndex = 6;
            // 
            // Názov
            // 
            this.Názov.AutoSize = true;
            this.Názov.BackColor = System.Drawing.Color.Transparent;
            this.Názov.ForeColor = System.Drawing.Color.White;
            this.Názov.Location = new System.Drawing.Point(1853, 238);
            this.Názov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Názov.Name = "Názov";
            this.Názov.Size = new System.Drawing.Size(73, 25);
            this.Názov.TabIndex = 7;
            this.Názov.Text = "Názov";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1853, 330);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Autor";
            // 
            // PridatAutor
            // 
            this.PridatAutor.Location = new System.Drawing.Point(1972, 327);
            this.PridatAutor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PridatAutor.Name = "PridatAutor";
            this.PridatAutor.Size = new System.Drawing.Size(148, 31);
            this.PridatAutor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1834, 415);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kategória";
            // 
            // PridatKategoria
            // 
            this.PridatKategoria.Location = new System.Drawing.Point(1972, 412);
            this.PridatKategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PridatKategoria.Name = "PridatKategoria";
            this.PridatKategoria.Size = new System.Drawing.Size(148, 31);
            this.PridatKategoria.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1853, 503);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cena";
            // 
            // PridatCena
            // 
            this.PridatCena.Location = new System.Drawing.Point(1972, 497);
            this.PridatCena.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PridatCena.Name = "PridatCena";
            this.PridatCena.Size = new System.Drawing.Size(148, 31);
            this.PridatCena.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 51;
            this.listBox1.Items.AddRange(new object[] {
            ""});
            this.listBox1.Location = new System.Drawing.Point(44, 247);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1135, 820);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1912, 739);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Popis knihy";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(1836, 783);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(276, 148);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1812, 593);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "URL obrázka";
            // 
            // PridajURL
            // 
            this.PridajURL.Location = new System.Drawing.Point(1972, 587);
            this.PridajURL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PridajURL.Name = "PridajURL";
            this.PridajURL.Size = new System.Drawing.Size(148, 31);
            this.PridajURL.TabIndex = 17;
            // 
            // Nazov
            // 
            this.Nazov.AutoSize = true;
            this.Nazov.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nazov.Location = new System.Drawing.Point(1138, 47);
            this.Nazov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nazov.Name = "Nazov";
            this.Nazov.Size = new System.Drawing.Size(0, 61);
            this.Nazov.TabIndex = 19;
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autor.Location = new System.Drawing.Point(1206, 140);
            this.Autor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(0, 37);
            this.Autor.TabIndex = 20;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox1.Location = new System.Drawing.Point(1210, 212);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(572, 656);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 21;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Popis
            // 
            this.Popis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Popis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Popis.ForeColor = System.Drawing.Color.White;
            this.Popis.Location = new System.Drawing.Point(1210, 895);
            this.Popis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Popis.Name = "Popis";
            this.Popis.ReadOnly = true;
            this.Popis.Size = new System.Drawing.Size(572, 172);
            this.Popis.TabIndex = 22;
            this.Popis.Text = "Tu uvidíte popis ku knihe";
            // 
            // PridatButton
            // 
            this.PridatButton.BackColor = System.Drawing.Color.Black;
            this.PridatButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.PridatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PridatButton.ForeColor = System.Drawing.Color.Gold;
            this.PridatButton.Location = new System.Drawing.Point(1836, 959);
            this.PridatButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PridatButton.Name = "PridatButton";
            this.PridatButton.Size = new System.Drawing.Size(284, 81);
            this.PridatButton.TabIndex = 23;
            this.PridatButton.Text = "Pridaj";
            this.PridatButton.UseVisualStyleBackColor = false;
            this.PridatButton.Click += new System.EventHandler(this.PridatButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(1362, 1093);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 52);
            this.label6.TabIndex = 24;
            this.label6.Text = "Údaje o knihe";
            // 
            // buttonOdstranit
            // 
            this.buttonOdstranit.BackColor = System.Drawing.Color.Black;
            this.buttonOdstranit.Cursor = System.Windows.Forms.Cursors.Cross;
            this.buttonOdstranit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOdstranit.ForeColor = System.Drawing.Color.Red;
            this.buttonOdstranit.Location = new System.Drawing.Point(872, 1093);
            this.buttonOdstranit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOdstranit.Name = "buttonOdstranit";
            this.buttonOdstranit.Size = new System.Drawing.Size(284, 81);
            this.buttonOdstranit.TabIndex = 25;
            this.buttonOdstranit.Text = "Odstraniť";
            this.buttonOdstranit.UseVisualStyleBackColor = false;
            this.buttonOdstranit.Click += new System.EventHandler(this.buttonOdstranit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(2224, 1200);
            this.Controls.Add(this.buttonOdstranit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PridatButton);
            this.Controls.Add(this.Popis);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.Nazov);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PridajURL);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PridatCena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PridatKategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PridatAutor);
            this.Controls.Add(this.Názov);
            this.Controls.Add(this.PridatNazov);
            this.Controls.Add(this.PridatNadpis);
            this.Controls.Add(this.VyhladavanieComboBox);
            this.Controls.Add(this.VyhladavanieNadpis);
            this.Controls.Add(this.VyhladavanieButton);
            this.Controls.Add(this.VyhladavanieInput);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox VyhladavanieInput;
        private System.Windows.Forms.Button VyhladavanieButton;
        private System.Windows.Forms.Label VyhladavanieNadpis;
        private System.Windows.Forms.ComboBox VyhladavanieComboBox;
        private System.Windows.Forms.Label PridatNadpis;
        private System.Windows.Forms.TextBox PridatNazov;
        private System.Windows.Forms.Label Názov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PridatAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PridatKategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PridatCena;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PridajURL;
        private System.Windows.Forms.Label Nazov;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.RichTextBox Popis;
        private System.Windows.Forms.Button PridatButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonOdstranit;
    }
}

