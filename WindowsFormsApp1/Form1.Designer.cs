
namespace WindowsFormsApp1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3_Torles = new System.Windows.Forms.Button();
            this.button2_modositas = new System.Windows.Forms.Button();
            this.button1_Uj = new System.Windows.Forms.Button();
            this.comboBox1_Orszag = new System.Windows.Forms.ComboBox();
            this.numericUpDown2_Irszam = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1_Szuletett = new System.Windows.Forms.NumericUpDown();
            this.textBox2_Nev = new System.Windows.Forms.TextBox();
            this.textBox1_Azon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1_Tagok = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1_Befizetesek = new System.Windows.Forms.DataGridView();
            this.button2_Torless = new System.Windows.Forms.Button();
            this.button1_Rogzitess = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1_Tagok = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1_Osszeg = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2_Irszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Szuletett)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Befizetesek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Osszeg)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.listBox1_Tagok);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3_Torles);
            this.groupBox1.Controls.Add(this.button2_modositas);
            this.groupBox1.Controls.Add(this.button1_Uj);
            this.groupBox1.Controls.Add(this.comboBox1_Orszag);
            this.groupBox1.Controls.Add(this.numericUpDown2_Irszam);
            this.groupBox1.Controls.Add(this.numericUpDown1_Szuletett);
            this.groupBox1.Controls.Add(this.textBox2_Nev);
            this.groupBox1.Controls.Add(this.textBox1_Azon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(173, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 356);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kivalasztott Tag";
            // 
            // button3_Torles
            // 
            this.button3_Torles.Location = new System.Drawing.Point(453, 257);
            this.button3_Torles.Name = "button3_Torles";
            this.button3_Torles.Size = new System.Drawing.Size(75, 23);
            this.button3_Torles.TabIndex = 12;
            this.button3_Torles.Text = "Torles";
            this.button3_Torles.UseVisualStyleBackColor = true;
            this.button3_Torles.Click += new System.EventHandler(this.button3_Torles_Click);
            // 
            // button2_modositas
            // 
            this.button2_modositas.Location = new System.Drawing.Point(278, 257);
            this.button2_modositas.Name = "button2_modositas";
            this.button2_modositas.Size = new System.Drawing.Size(75, 23);
            this.button2_modositas.TabIndex = 11;
            this.button2_modositas.Text = "Modositas";
            this.button2_modositas.UseVisualStyleBackColor = true;
            this.button2_modositas.Click += new System.EventHandler(this.button2_modositas_Click);
            // 
            // button1_Uj
            // 
            this.button1_Uj.Location = new System.Drawing.Point(98, 257);
            this.button1_Uj.Name = "button1_Uj";
            this.button1_Uj.Size = new System.Drawing.Size(75, 23);
            this.button1_Uj.TabIndex = 10;
            this.button1_Uj.Text = "ÚJ";
            this.button1_Uj.UseVisualStyleBackColor = true;
            this.button1_Uj.Click += new System.EventHandler(this.button1_Uj_Click);
            // 
            // comboBox1_Orszag
            // 
            this.comboBox1_Orszag.FormattingEnabled = true;
            this.comboBox1_Orszag.Location = new System.Drawing.Point(98, 178);
            this.comboBox1_Orszag.Name = "comboBox1_Orszag";
            this.comboBox1_Orszag.Size = new System.Drawing.Size(121, 24);
            this.comboBox1_Orszag.TabIndex = 9;
            // 
            // numericUpDown2_Irszam
            // 
            this.numericUpDown2_Irszam.Location = new System.Drawing.Point(90, 143);
            this.numericUpDown2_Irszam.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown2_Irszam.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2_Irszam.Name = "numericUpDown2_Irszam";
            this.numericUpDown2_Irszam.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2_Irszam.TabIndex = 8;
            this.numericUpDown2_Irszam.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDown1_Szuletett
            // 
            this.numericUpDown1_Szuletett.Location = new System.Drawing.Point(91, 103);
            this.numericUpDown1_Szuletett.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1_Szuletett.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDown1_Szuletett.Name = "numericUpDown1_Szuletett";
            this.numericUpDown1_Szuletett.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1_Szuletett.TabIndex = 7;
            this.numericUpDown1_Szuletett.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // textBox2_Nev
            // 
            this.textBox2_Nev.Location = new System.Drawing.Point(88, 63);
            this.textBox2_Nev.Name = "textBox2_Nev";
            this.textBox2_Nev.Size = new System.Drawing.Size(100, 22);
            this.textBox2_Nev.TabIndex = 6;
            // 
            // textBox1_Azon
            // 
            this.textBox1_Azon.Location = new System.Drawing.Point(88, 26);
            this.textBox1_Azon.Name = "textBox1_Azon";
            this.textBox1_Azon.ReadOnly = true;
            this.textBox1_Azon.Size = new System.Drawing.Size(100, 22);
            this.textBox1_Azon.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Orszag:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "irszam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "szüleév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "nev:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "azon:";
            // 
            // listBox1_Tagok
            // 
            this.listBox1_Tagok.FormattingEnabled = true;
            this.listBox1_Tagok.ItemHeight = 16;
            this.listBox1_Tagok.Location = new System.Drawing.Point(26, 18);
            this.listBox1_Tagok.Name = "listBox1_Tagok";
            this.listBox1_Tagok.Size = new System.Drawing.Size(120, 324);
            this.listBox1_Tagok.TabIndex = 0;
            this.listBox1_Tagok.SelectedIndexChanged += new System.EventHandler(this.listBox1_Tagok_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericUpDown1_Osszeg);
            this.tabPage2.Controls.Add(this.dataGridView1_Befizetesek);
            this.tabPage2.Controls.Add(this.button2_Torless);
            this.tabPage2.Controls.Add(this.button1_Rogzitess);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.comboBox1_Tagok);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1_Befizetesek
            // 
            this.dataGridView1_Befizetesek.AllowUserToAddRows = false;
            this.dataGridView1_Befizetesek.AllowUserToDeleteRows = false;
            this.dataGridView1_Befizetesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Befizetesek.Location = new System.Drawing.Point(8, 24);
            this.dataGridView1_Befizetesek.Name = "dataGridView1_Befizetesek";
            this.dataGridView1_Befizetesek.ReadOnly = true;
            this.dataGridView1_Befizetesek.RowHeadersWidth = 51;
            this.dataGridView1_Befizetesek.RowTemplate.Height = 24;
            this.dataGridView1_Befizetesek.Size = new System.Drawing.Size(460, 324);
            this.dataGridView1_Befizetesek.TabIndex = 12;
            this.dataGridView1_Befizetesek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RekordAdatainakbetoltese);
            // 
            // button2_Torless
            // 
            this.button2_Torless.Location = new System.Drawing.Point(609, 224);
            this.button2_Torless.Name = "button2_Torless";
            this.button2_Torless.Size = new System.Drawing.Size(75, 23);
            this.button2_Torless.TabIndex = 11;
            this.button2_Torless.Text = "Törlés";
            this.button2_Torless.UseVisualStyleBackColor = true;
            // 
            // button1_Rogzitess
            // 
            this.button1_Rogzitess.Location = new System.Drawing.Point(595, 169);
            this.button1_Rogzitess.Name = "button1_Rogzitess";
            this.button1_Rogzitess.Size = new System.Drawing.Size(75, 23);
            this.button1_Rogzitess.TabIndex = 10;
            this.button1_Rogzitess.Text = "Rögzités";
            this.button1_Rogzitess.UseVisualStyleBackColor = true;
            this.button1_Rogzitess.Click += new System.EventHandler(this.button1_Rogzitess_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(555, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // comboBox1_Tagok
            // 
            this.comboBox1_Tagok.FormattingEnabled = true;
            this.comboBox1_Tagok.Location = new System.Drawing.Point(571, 21);
            this.comboBox1_Tagok.Name = "comboBox1_Tagok";
            this.comboBox1_Tagok.Size = new System.Drawing.Size(121, 24);
            this.comboBox1_Tagok.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(495, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Osszeg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Datum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "NEV2:";
            // 
            // numericUpDown1_Osszeg
            // 
            this.numericUpDown1_Osszeg.Location = new System.Drawing.Point(571, 121);
            this.numericUpDown1_Osszeg.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDown1_Osszeg.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1_Osszeg.Name = "numericUpDown1_Osszeg";
            this.numericUpDown1_Osszeg.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1_Osszeg.TabIndex = 13;
            this.numericUpDown1_Osszeg.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2_Irszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Szuletett)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Befizetesek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Osszeg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1_Tagok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1_Azon;
        private System.Windows.Forms.TextBox textBox2_Nev;
        private System.Windows.Forms.NumericUpDown numericUpDown1_Szuletett;
        private System.Windows.Forms.NumericUpDown numericUpDown2_Irszam;
        private System.Windows.Forms.ComboBox comboBox1_Orszag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1_Uj;
        private System.Windows.Forms.Button button2_modositas;
        private System.Windows.Forms.Button button3_Torles;
        private System.Windows.Forms.ComboBox comboBox1_Tagok;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2_Torless;
        private System.Windows.Forms.Button button1_Rogzitess;
        private System.Windows.Forms.DataGridView dataGridView1_Befizetesek;
        private System.Windows.Forms.NumericUpDown numericUpDown1_Osszeg;
    }
}

