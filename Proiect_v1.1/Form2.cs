using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_v1._1.Classes;
using System.IO;

namespace Proiect_v1._1
{
    public partial class Form2 : Form
    {
        string provider;
        public ArrayList listafisiere = new ArrayList();

        public Form2(ArrayList fisiereVideo)
        {
            InitializeComponent();
            provider = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Istoric.accdb";
            foreach (FisierVideo fis in fisiereVideo)
                listafisiere.Add(fis);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(provider);
            OleDbCommand comanda = new OleDbCommand("SELECT * FROM fisierevideo", conexiune);
            lvw.Items.Clear();
            listafisiere.Clear();
            try
            {
                
                conexiune.Open();
                OleDbDataReader reader = comanda.ExecuteReader();
                while(reader.Read())
                {
                    FisierVideo fis = new FisierVideo();
                    ListViewItem itm = new ListViewItem(reader["Cod"].ToString());
                    itm.SubItems.Add(reader["Denumire Fisier"].ToString());
                    fis.denumireFisier = reader["Denumire Fisier"].ToString();
                    itm.SubItems.Add(reader["Cale Fisier"].ToString());
                    fis.caleFisier = reader["Cale Fisier"].ToString();
                    itm.SubItems.Add(reader["Extensie"].ToString());
                    fis.extensie = reader["Extensie"].ToString();
                    itm.SubItems.Add(reader["Gen"].ToString());
                    fis.gen = reader["Gen"].ToString();
                    itm.SubItems.Add(reader["Dimensiune"].ToString());
                    fis.dimensiuneFisier = Convert.ToDouble(reader["Dimensiune"].ToString());
                    itm.SubItems.Add(reader["Rating"].ToString());
                    fis.rating = (float)Convert.ToDouble(reader["Rating"]);
                    itm.SubItems.Add(reader["Vizualizat"].ToString());
                    if (reader["Vizualizat"].ToString() == "Da")
                        fis.vizualizat = true;
                    else
                        fis.vizualizat = false;
                    lvw.Items.Add(itm);
                    listafisiere.Add(fis);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (FisierVideo fis in listafisiere)
            {
                insertVideo(fis);
            }
        }
        private void insertVideo(FisierVideo fis)
        {
            OleDbConnection conexiune = new OleDbConnection(provider);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conexiune.Open();
                int cod;
                comanda.Connection = conexiune;
                comanda.CommandText = "select count(*) from fisierevideo";
                int check = Convert.ToInt32(comanda.ExecuteScalar());
                comanda.CommandText = "select max(cod) from fisierevideo";
                if (check != 0)
                   cod = Convert.ToInt32(comanda.ExecuteScalar());
                else
                    cod = 0;

                comanda.CommandText = "insert into fisierevideo values(?,?,?,?,?,?,?,?)";
                comanda.Parameters.Add("Cod", OleDbType.Integer).Value = cod + 1;
                comanda.Parameters.Add("Denumire Fisier", OleDbType.Char, 30).Value = fis.denumireFisier;
                comanda.Parameters.Add("Cale Fisier", OleDbType.Char, 150).Value = fis.caleFisier;
                comanda.Parameters.Add("Extensie", OleDbType.Char, 4).Value = fis.extensie;
                comanda.Parameters.Add("Gen", OleDbType.Char, 150).Value = fis.gen;
                comanda.Parameters.Add("Dimensiune", OleDbType.Integer, 150).Value = fis.dimensiuneFisier;
                comanda.Parameters.Add("Rating", OleDbType.Integer).Value = fis.rating;
                if (fis.vizualizat == false)
                    comanda.Parameters.Add("Vizualizat", OleDbType.Char, 3).Value = "Nu";
                else
                    comanda.Parameters.Add("Vizualizat", OleDbType.Char, 3).Value = "Da";
                comanda.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(provider);
            OleDbCommand comanda = new OleDbCommand();

            foreach(ListViewItem itm in lvw.Items)
            {
                if(itm.Selected == true)
                {
                    try
                    {
                        conexiune.Open();
                        int cod = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "DELETE FROM fisierevideo WHERE Cod= " + cod;
                        comanda.Connection = conexiune;
                        comanda.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexiune.Close();
                    }
                    lvw.Items.Clear();
                    button1_Click(sender, e);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(provider);
            OleDbCommand comanda = new OleDbCommand();
            conexiune.Open();
            comanda.Connection = conexiune;
            comanda.CommandText = "DELETE FROM fisierevideo";
            comanda.ExecuteNonQuery();
            conexiune.Close();
            lvw.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(provider);
            OleDbCommand comanda = new OleDbCommand();
            string nume = null;
            foreach (ListViewItem item in lvw.Items)
            {
                if (item.Selected == true)
                {
                    nume = item.SubItems[1].Text;
                }
            }
            FisierVideo fis = new FisierVideo();
            foreach (FisierVideo fisier in listafisiere)
            {
                if (fisier.denumireFisier.CompareTo(nume) == 0)
                    fis = fisier;
            }
            Form3 frm = new Form3(fis);
            frm.ShowDialog();

            foreach (ListViewItem item in lvw.Items)
            {
                if (item.Selected == true)
                {
                    try
                    {
                        conexiune.Open();
                        int cod = Convert.ToInt32(item.SubItems[0].Text);
                        string viz = null;
                        if (fis.vizualizat == true)
                            viz = "da";
                        else
                            viz = "nu";
                        comanda.CommandText = "update fisierevideo set Gen='" + fis.gen + "', Rating='" +
                            fis.rating + "', Vizualizat='" + viz + "' where Cod=" + cod;
                        comanda.Connection = conexiune;
                        comanda.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexiune.Close();
                    }
                }
                //listView1.Items.Clear();
            }
        }
        static FileStream fisier = new FileStream("RaportCautari.txt", FileMode.Open, FileAccess.Write);
        
        private void button6_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(fisier);
            textBox1.Clear();
            string gen = tbExtensie.Text;
            int gasit = 0;
            sw.Write("Rezultate dupa cautarea dupa gen: ");
            sw.Write("\r\n");
            foreach (ListViewItem itm in lvw.Items)
            {
                if (itm.SubItems[4].Text.CompareTo(gen) == 0)
                {
                    gasit++;
                    if (itm.SubItems[7].Text.CompareTo("da") == 0)
                        sw.Write("Denumire Fisier Video: " + itm.SubItems[1].Text + " cu extensia: " + itm.SubItems[3].Text + " si a fost vizualizat" + "\r\n");
                    else
                        sw.Write("Denumire Fisier Video: " + itm.SubItems[1].Text + " cu extensia: " + itm.SubItems[3].Text + " si nu a fost vizualizat" + "\r\n");
                    textBox1.Text += "Nr. " + itm.SubItems[0].Text + " Denumire film:" + "\r\n" + itm.SubItems[1].Text + "\r\n";
                }
                
            }
            MessageBox.Show("S-au gasit " + gasit + " fisere cu extensia cautata si au fost adaugate in fisier");
            tbExtensie.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(fisier);
            textBox1.Clear();
            int rating = Convert.ToInt32(tbRating.Text);
            int gasit = 0;
            sw.Write("Rezultate dupa cautarea dupa rating: ");
            sw.Write("\r\n");
            foreach (ListViewItem itm in lvw.Items)
            {
                if (Convert.ToInt32(itm.SubItems[6].Text) == rating)
                {
                    gasit++;
                    if (itm.SubItems[7].Text.CompareTo("da") == 0)
                        sw.Write("Denumire Fisier Video: " + itm.SubItems[1].Text + " cu extensia: " + itm.SubItems[3].Text + " si a fost vizualizat" + "\r\n");
                    else
                        sw.Write("Denumire Fisier Video: " + itm.SubItems[1].Text + " cu extensia: " + itm.SubItems[3].Text + " si nu a fost vizualizat" + "\r\n");
                    textBox1.Text += "Nr. " + itm.SubItems[0].Text + " Denumire film:" + "\r\n" + itm.SubItems[1].Text + "\r\n";
                }
            }
            MessageBox.Show("S-au gasit " + gasit + " fisere cu rating-ul dorit si au fost adaugate in fisier");
            tbRating.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(fisier);
            textBox1.Clear();
            string ext = cbVizualizat.Text;
            int gasit = 0;
            if (ext.CompareTo("Da") == 0)
            {
                sw.Write("Rezultate dupa cautarea filmelor care au fost vizualizate: ");
                sw.Write("\r\n");
                foreach (ListViewItem itm in lvw.Items)
                {
                    if (itm.SubItems[7].Text.CompareTo("da") == 0)
                    {
                        gasit++;
                        sw.Write("Denumire Fisier Video: " + itm.SubItems[1].Text + " cu extensia: " + itm.SubItems[3].Text + " si a fost vizualizat" + "\r\n");
                        textBox1.Text += "Nr. " + itm.SubItems[0].Text + " Denumire film: " + "\r\n" + itm.SubItems[1].Text + "\r\n";
                    }
                }
                MessageBox.Show("S-au gasit " + gasit + " fisere care au fost vizualizate deja si au fost adaugate in fisier");
            }
            else
            {
                sw.Write("Rezultate dupa cautarea filmelor care nu au fost vizualizate: ");
                sw.Write("\r\n");
                foreach (ListViewItem itm in lvw.Items)
                {
                    if (itm.SubItems[7].Text.CompareTo("Nu") == 0)
                    {
                        gasit++;
                        sw.Write("Denumire Fisier Video: " + itm.SubItems[1].Text + " cu extensia: " + itm.SubItems[3].Text + " si nu a fost vizualizat" + "\r\n");
                        textBox1.Text += "Nr. " + itm.SubItems[0].Text + " Denumire film: " + "\r\n" + itm.SubItems[1].Text + "\r\n";
                    }
                }
                MessageBox.Show("S-au gasit " + gasit + " fisere care nu au fost vizualizate inca si au fost adaugate in fisier");
            }
          
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button5_Click(sender, e);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvw.Items.Clear();
        }
    }
}
