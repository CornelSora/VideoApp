using Proiect_v1._1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_v1._1
{
    public partial class Form3 : Form
    {
        FisierVideo fisier; 
        public Form3(FisierVideo fis)
        {
            InitializeComponent();
            fisier = fis;
            tbDenumire.Text = fis.denumireFisier;
            tbDimensiune.Text = fis.dimensiuneFisier.ToString();
            tbCale.Text = fis.caleFisier;
            tbExtensie.Text = fis.extensie;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fisier.denumireFisier = tbDenumire.Text;
            fisier.rating = (float)Convert.ToDouble(nudRating.Text);
            if (cbVizualizat.Text == "Da")
                fisier.vizualizat = true;
            else
                fisier.vizualizat = false;
            fisier.gen = tbGen.Text;
            string verif = cbVizualizat.Text;
            if (string.IsNullOrEmpty(verif))
            {
                errorProvider1.SetError((Control)sender, "Aceasta casuta trebuie selectata");
            }
        }

        private void cbVizualizat_Validating(object sender, CancelEventArgs e)
        {
            string verif = cbVizualizat.Text;
            if(string.IsNullOrEmpty(verif))
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Aceasta casuta trebuie selectata");
            }
        }

        private void cbVizualizat_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
