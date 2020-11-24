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
            Befizetesek_table_update();
        }
        private void Befizetesek_table_update()
        {
            sql.CommandText = "SELECT ugyfel.nev, ugyfel.azon, befiz.datum, befiz.osszeg From ugyfel JOIN befiz USING (azon) WHERE 1";
            try
            {
                using (MySqlDataReader dr=sql.ExecuteReader())
                {
                    dataGridView1_Befizetesek.Rows.Clear();
                    while(dr.Read())
                    {
                        int index = dataGridView1_Befizetesek.Rows.Add();
                        DataGridViewRow ujSor = dataGridView1_Befizetesek.Rows[index];
                        ujSor.Cells["azon"].Value = dr.GetInt32("azon");
                        ujSor.Cells["nev"].Value = dr.GetString("nev");
                        ujSor.Cells["datum"].Value = dr.GetDateTime("datum");
                        ujSor.Cells["osszeg"].Value = dr.GetInt32("osszeg");
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
                throw;
            }
        }
        private void Befizetesek_tabla_create()
        {
            dataGridView1_Befizetesek.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1_Befizetesek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //--Fejléc megváltoztatása--
            dataGridView1_Befizetesek.EnableHeadersVisualStyles = false;
            dataGridView1_Befizetesek.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1_Befizetesek.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1_Befizetesek.ColumnHeadersDefaultCellStyle.ForeColor = Color.Yellow;
            dataGridView1_Befizetesek.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
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
                col_datum.ValueType = typeof(DateTime);
                col_datum.CellTemplate = new DataGridViewTextBoxCell();
            }
            DataGridViewColumn col_osszeg = new DataGridViewColumn();
            {
                col_osszeg.Name = "osszeg";
                col_osszeg.HeaderText = "Befizetett összeg";
                col_osszeg.ValueType = typeof(int);
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

        private void button1_Rogzitess_Click(object sender, EventArgs e)
        {
            if (comboBox1_Tagok.SelectedIndex<0)
            {
                MessageBox.Show("Válasszon egy tagot", "hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1_Tagok.Focus();
                return;
            }
            if (numericUpDown1_Osszeg.Value<1)
            {
                MessageBox.Show("Addjon meg egy összeget!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDown1_Osszeg.Focus();
                return;
            }
            Ugyfel u = (Ugyfel)comboBox1_Tagok.SelectedItem;
            sql.CommandText =$"INSERT INTO `befiz`( `azon`,`datum`, `osszeg`) VALUES ('{u.Id}','{dateTimePicker1.Value.ToString("yyyy-MM-dd")}','{numericUpDown1_Osszeg.Value.ToString()}')";
            try
            {
                sql.ExecuteNonQuery();
                Befizetesek_table_update();
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
            
        }

        private void RekordAdatainakbetoltese(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rekord = dataGridView1_Befizetesek.SelectedRows[0];
            comboBox1_Tagok.Text = rekord.Cells["nev"].Value.ToString();
            numericUpDown1_Osszeg.Value = decimal.Parse(rekord.Cells["osszeg"].Value.ToString());
            dateTimePicker1.Value = (DateTime)rekord.Cells["datum"].Value;
        }
    }
}
