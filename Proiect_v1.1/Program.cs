using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_v1._1.Classes;

namespace Proiect_v1._1
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            #region OldProgramTest
            FisierVideo fis1 = new FisierVideo();
            fis1.denumireFisier = "fisier1";
            fis1.caleFisier = "E:/movie";
            fis1.vizualizat = true;

            FisierVideo fis2 = new FisierVideo();
            fis2.denumireFisier = "fisier2";
            fis2.caleFisier = "E:/movies";
            fis2.vizualizat = false;

            FisierVideo fis3 = (FisierVideo)fis2.Clone();

            FisierVideo[] fisiere = new FisierVideo[] { fis1, fis2, fis3 };

            DirectorVideo dir = new DirectorVideo("director1", "E:/", fisiere);

            Console.WriteLine(dir);

            foreach (FisierVideo fisier in fisiere)
            {
                Console.WriteLine(fisier);
            }

            DimensiuneEvent myDim = new DimensiuneEvent();

            DimensiuneHandler handler = new DimensiuneHandler(myDim);

            DimensiuneEventArgs e1 = new DimensiuneEventArgs("Fisier1", 3000);
            DimensiuneEventArgs e2 = new DimensiuneEventArgs("Fisier2", 100);
            DimensiuneEventArgs e3 = new DimensiuneEventArgs("Fisier3", 100000);
            //lansare evenimente
            myDim.VerificaDim(e1);
            myDim.VerificaDim(e2);
            myDim.VerificaDim(e3);
            #endregion
        }
    }
}
