using Proiect_v1._1.Classes;
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Xml;
using System.Text;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Proiect_v1._1
{
    
    public partial class Form1 : Form
    {
        int stop = 0;
        List<FisierVideo> listFis = new List<FisierVideo>();
        ArrayList listaFisiere = new ArrayList();
        DirectorVideo director = new DirectorVideo();
        List<DirectorVideo> directoare = new List<DirectorVideo>();
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            afisareFisiere();
        }

        private void afisareFisiere()
        {
            lvFisiere.Items.Clear();
            lvFisiere.LabelEdit = true;
            int i = 1; // contor pentru numararea tuturor fisierelor video
            foreach (FisierVideo fis in listaFisiere)
            {
                var listViewItem = new ListViewItem((i++).ToString());
                listViewItem.SubItems.Add(fis.denumireFisier);
                listViewItem.SubItems.Add(fis.caleFisier);
                listViewItem.SubItems.Add(fis.extensie);
                listViewItem.SubItems.Add(fis.gen);
                listViewItem.SubItems.Add(fis.dimensiuneFisier.ToString());
                listViewItem.SubItems.Add(fis.rating.ToString());
                if(fis.vizualizat == true)
                    listViewItem.SubItems.Add("Da");
                else
                    listViewItem.SubItems.Add("Nu");
                listViewItem.ImageKey = "Movies.png";
                lvFisiere.Items.Add(listViewItem);

                var list2 = new ListViewItem(fis.rating.ToString());
            }

        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ScanApplication v1.0");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FillDirectoryTree();
        }

        private void FillDirectoryTree()
        {
            tvw.BeginUpdate();
            tvw.Nodes.Clear();
            string[] strDrives = Environment.GetLogicalDrives();
            foreach (string rootDirectoryName in strDrives)
            {
                try
                {
                    Directory.GetDirectories(rootDirectoryName);

                    TreeNode ndRoot = new TreeNode(rootDirectoryName);

                    tvw.Nodes.Add(ndRoot);
                    director.denumireDirector = ndRoot.Name;
                    director.caleDirector = ndRoot.FullPath;
                    GetSubDirectoryNodes(ndRoot);
                }
                catch (IOException)
                {
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            tvw.EndUpdate();

        }

        private void GetSubDirectoryNodes(TreeNode parentNode)
        {
            if (stop == 0)
            {
                DirectoryInfo di = new DirectoryInfo(parentNode.FullPath);
                if ((di.Attributes & FileAttributes.Directory) == 0)
                {
                    return;
                }

                parentNode.Nodes.Clear();

                try
                {
                    string[] arSubs = Directory.GetDirectories(parentNode.FullPath);

                    foreach (var subDir in arSubs)
                    {
                        DirectoryInfo dirInfo = new DirectoryInfo(subDir);
                        if ((dirInfo.Attributes & FileAttributes.Hidden) != 0)
                        {
                            continue;
                        }

                        TreeNode subNode = new TreeNode(dirInfo.Name);
                        parentNode.Nodes.Add(subNode);
                    }

                    string[] files = Directory.GetFiles(parentNode.FullPath);

                    foreach (string str in files)
                    {
                        FileInfo fi = new FileInfo(str);
                        TreeNode fileNode = new TreeNode(fi.Name);
                        bool verificare1 = fi.Name.EndsWith(".mkv");
                        bool verificare2 = fi.Name.EndsWith(".flv");
                        bool verificare3 = fi.Name.EndsWith(".avi");
                        bool verificare4 = fi.Name.EndsWith(".wmv");
                        bool verificare5 = fi.Name.EndsWith(".mp4");
                        bool verificare6 = fi.Name.EndsWith(".vob");


                        if ((verificare1 || verificare2 || verificare3
                         || verificare4 || verificare5 || verificare6))
                        {
                            //parentNode.Nodes.Clear();
                            parentNode.Nodes.Add(fileNode);
                            FisierVideo fis = new FisierVideo();
                            fis.denumireFisier = fileNode.Text.Split('.')[0];
                            fis.caleFisier = fileNode.FullPath;
                            fis.dimensiuneFisier = fi.Length / 1000000;
                            fis.extensie = fi.Extension;
                            fis.gen = "necunoscut";
                            fis.rating = 0;
                            fis.vizualizat = false;
                            listaFisiere.Add(fis);
                        }
                        int j = 0;
                        director.fisiereVideo = new FisierVideo[listaFisiere.Count];
                        foreach (FisierVideo fis in listaFisiere)
                        {
                            director.fisiereVideo[j] = fis;
                            j++;
                        }
                        director.nrFisiere = j - 1;

                    }
                }
                catch (UnauthorizedAccessException)
                {

                }
            }
        }    
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            FillDirectoryTree();
        }

        private void tvw_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            tvw.BeginUpdate();

            foreach (TreeNode tn in e.Node.Nodes)
            {
                GetSubDirectoryNodes(tn);
            }

            tvw.EndUpdate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDirectoryTree();
        }


        private void tvw_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            bool verificare1 = e.Node.Text.EndsWith(".mkv");
            bool verificare2 = e.Node.Text.EndsWith(".flv");
            bool verificare3 = e.Node.Text.EndsWith(".avi");
            bool verificare4 = e.Node.Text.EndsWith(".wmv");
            bool verificare5 = e.Node.Text.EndsWith(".mp4");
            bool verificare6 = e.Node.Text.EndsWith(".vob");
            if ((verificare1 || verificare2 || verificare3
                     || verificare4 || verificare5 || verificare6))
            {
                System.Diagnostics.Process.Start(e.Node.FullPath);
            }
        }

        private void fisierXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (FisierVideo fis in listaFisiere)
                listFis.Add(fis);
            XmlSerializer serializer = new XmlSerializer(typeof(List<FisierVideo>));
            using (StreamWriter writer = new StreamWriter("SerializedXML.xml"))
            {
                serializer.Serialize(writer, listFis);
            }
            MessageBox.Show("Serializare in XML s-a realizat cu succes");

    }

    private void button2_Click(object sender, EventArgs e)
        {
            if (tvw.SelectedNode != null)
                tvw.SelectedNode.ExpandAll();
        }

        private void fisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fisier = new FileStream("fisier.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fisier);
            foreach (FisierVideo fisVid in listaFisiere)
                sw.Write(fisVid.denumireFisier + "; " + fisVid.caleFisier + "; " + fisVid.rating + "\r\n");
            sw.Close();
            fisier.Close();
        }

        private void citireTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fisier = new FileStream("fisier.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fisier);
            foreach(FisierVideo fisVid in listaFisiere)
            {
                string line = null;
                while((line = sr.ReadLine()) != null)
                {
                    string[] t = line.Split(';');
                    fisVid.denumireFisier = t[0].Trim();
                    fisVid.caleFisier = t[1].Trim();
                    fisVid.rating = (float)Convert.ToDouble(t[2].Trim());
                }
            }
            afisareFisiere();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            afisareFisiere();
        }

        private void lvFisiere_DoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Node.FullPath);
        }

        private void bazaDeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaFisiere);
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            try
            {
                DialogResult result = fbd.ShowDialog();

                if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    TreeNode Radacina = new TreeNode(fbd.SelectedPath);
                    tvw.Nodes.Add(Radacina);
                    GetSubDirectoryNodes(Radacina);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nume = null; 
            foreach (ListViewItem item in lvFisiere.Items)
            {
                if (item.Selected == true)
                {
                    nume = item.SubItems[1].Text;
                }
            }
            FisierVideo fis = new FisierVideo();
            foreach (FisierVideo fisier in listaFisiere)
            {
                if (fisier.denumireFisier.CompareTo(nume) == 0)
                    fis = fisier;
            }
            Form3 frm = new Form3(fis);
            frm.ShowDialog();
        }

        private void citireXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<FisierVideo>));
            using (StreamReader streamReader = new StreamReader("SerializedXML.xml"))
            {
                listFis.Clear();
                listFis = (List<FisierVideo>)serializer.Deserialize(streamReader);
            }
            MessageBox.Show("Deserializare din XML efectuata cu succes");
            listaFisiere.Clear();
            foreach (FisierVideo fis in listFis)
                listaFisiere.Add(fis);
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem itm in lvFisiere.Items)
            {
                if (itm.Selected == true)
                    itm.Remove();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afisareFisiere();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stop = 1;
        }
    }
}
