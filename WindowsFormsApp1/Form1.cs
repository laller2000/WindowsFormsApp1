using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection con = null;
        MySqlCommand sql = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tagdij";
            con = new MySqlConnection(sb.ToString());
            try
            {
                con.Open();
                sql = con.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            Tagok_listbox_update();
            Tagok_combobox_update();
            orszagok_combobox_update();
            numericUpDown1_Szuletett.Maximum = (decimal)DateTime.Now.Year;
            Befizetesek_tabla_create();
        }
        private void Befizetesek_tabla_create()
        {
            //Datagrid oszloponkénti létrehozása
            DataGridViewColumn col_id = new DataGridViewColumn();
            {
                col_id.Name = "azon";
                col_id.HeaderText = "id";
                col_id.CellTemplate = new DataGridViewTextBoxCell();
                col_id.Visible = false;
            }
            DataGridViewColumn col_nev = new DataGridViewColumn();
            {
                col_nev.Name = "nev";
                col_nev.HeaderText = "Tag neve";
                col_nev.CellTemplate = new DataGridViewTextBoxCell();
            }
            DataGridViewColumn col_datum = new DataGridViewColumn();
            {
                col_datum.Name = "datum";
                col_datum.HeaderText = "Befizetes ideje";
                col_datum.CellTemplate = new DataGridViewTextBoxCell();
            }
            DataGridViewColumn col_osszeg = new DataGridViewColumn();
            {
                col_osszeg.Name = "osszeg";
                col_osszeg.HeaderText = "Befizetett összeg";
                col_osszeg.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView1_Befizetesek.Columns.Add(col_id);
            dataGridView1_Befizetesek.Columns.Add(col_nev);
            dataGridView1_Befizetesek.Columns.Add(col_datum);
            dataGridView1_Befizetesek.Columns.Add(col_osszeg);

        }
        private void Tagok_listbox_update()
        {
            listBox1_Tagok.Items.Clear();
            sql.CommandText = "SELECT `azon`,`nev`,`szulev`,`irszam`,`orsz` FROM `ugyfel` WHERE 1";
            using (MySqlDataReader dr=sql.ExecuteReader())
            {
                while(dr.Read())
                {
                    listBox1_Tagok.Items.Add(new Ugyfel(dr.GetInt32("azon"),dr.GetString("nev"),dr.GetInt32("szulev"),dr.GetInt32("irszam"),dr.GetString("orsz")));
                }
            }
        }
        private void Tagok_combobox_update()
        {
            comboBox1_Tagok.Items.Clear();
            sql.CommandText = "SELECT `azon`,`nev`,`szulev`,`irszam`,`orsz` FROM `ugyfel` WHERE 1";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    comboBox1_Tagok.Items.Add(new Ugyfel(dr.GetInt32("azon"), dr.GetString("nev"), dr.GetInt32("szulev"), dr.GetInt32("irszam"), dr.GetString("orsz")));
                }
            }
        }
        private void orszagok_combobox_update()
        {
            comboBox1_Orszag.Items.Clear();
            sql.CommandText = "SELECT DISTINCT `orsz` FROM `ugyfel` WHERE 1 ORDER BY 1";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    comboBox1_Orszag.Items.Add(dr.GetString("orsz"));
                }
            }
        }

        private void listBox1_Tagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1_Tagok.SelectedIndex<0)
            {
                MessageBox.Show("Válasszon ki egy tagot!");
                listBox1_Tagok.Focus();
                return;
            }
            Ugyfel kiv = (Ugyfel)listBox1_Tagok.SelectedItem;
            textBox1_Azon.Text = kiv.Id.ToString();
            textBox2_Nev.Text = kiv.Nev;
            numericUpDown2_Irszam.Value = (decimal)kiv.Irszam;
            numericUpDown1_Szuletett.Value = (decimal)kiv.Szulev;
            comboBox1_Orszag.Text = kiv.Orszag;
        }

        private void button1_Uj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2_Nev.Text.Trim()))
            {
                MessageBox.Show("Kérem addjon meg egy nevet!","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox2_Nev.Focus();
                return;
            }
            if (comboBox1_Orszag.SelectedIndex<0)
            {
                MessageBox.Show("Válasszon országot!","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                comboBox1_Orszag.Focus();
                return;
            }
            sql.CommandText = $"INSERT INTO `ugyfel`(`azon`, `nev`, `szulev`, `irszam`, `orsz`) VALUES (null,'{textBox2_Nev.Text.Trim()}','{numericUpDown1_Szuletett.Value.ToString()}','{numericUpDown2_Irszam.Value.ToString()}','{comboBox1_Orszag.SelectedItem.ToString()}')";
            try
            {
                if (sql.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("A rögzítés sikeres!");
                }
                else
                {
                    MessageBox.Show("Sikertelen a rögzítés!");
                }
                textBox1_Azon.Text = "";
                textBox2_Nev.Text = "";
                Tagok_combobox_update();
                Tagok_listbox_update();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button2_modositas_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(textBox2_Nev.Text.Trim()))
                {
                    MessageBox.Show("Kérem addjon meg egy nevet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2_Nev.Focus();
                    return;
                }
                if (comboBox1_Orszag.SelectedIndex < 0)
                {
                    MessageBox.Show("Válasszon országot!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBox1_Orszag.Focus();
                    return;
                }
                sql.CommandText = $"UPDATE `ugyfel` SET `nev`='{textBox2_Nev.Text.Trim()}',`szulev`='{numericUpDown1_Szuletett.Value.ToString()}',`irszam`='{numericUpDown2_Irszam.Value.ToString()}',`orsz`='{comboBox1_Orszag.SelectedItem.ToString()}' WHERE azon={textBox1_Azon.Text}";
                try
                {
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("A Módositás sikeres!");
                    }
                    else
                    {
                        MessageBox.Show("A módositas sikertelen!");
                    }
                    textBox1_Azon.Text = "";
                    textBox2_Nev.Text = "";
                    Tagok_combobox_update();
                    Tagok_listbox_update();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            
        }

        private void button3_Torles_Click(object sender, EventArgs e)
        {
            if (listBox1_Tagok.SelectedIndex<0)
            {
                MessageBox.Show("Nincs kiválasztva tag!");
                listBox1_Tagok.Focus();
                return;
            }
            sql.CommandText = $"DELETE FROM ugyfel WHERE azon={textBox1_Azon.Text}";
            try
            {
                if (sql.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("A Törlés sikeres!");
                }
                else
                {
                    MessageBox.Show("A Törlés sikertelen!");
                }
                textBox1_Azon.Text = "";
                textBox2_Nev.Text = "";
                Tagok_combobox_update();
                Tagok_listbox_update();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
