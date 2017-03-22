using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prroiect_v1._0.Clase
{
    class DirectorVideo : Dimensiune, IComparable, ICloneable, ExistaVideo
    {
        public string denumireDirector { get; set; }
        public string caleDirector { get; set; }
        public int nrFisiere { get; set; }
        public FisierVideo[] fisiereVideo { get; set; }
        private static double dim = 0;
        public DirectorVideo()
        {
        }

        public DirectorVideo(string denumireDirector, string caleDirector, FisierVideo[] fisiereVideo)
        {
            this.denumireDirector = denumireDirector;
            this.caleDirector = caleDirector;
            this.fisiereVideo = fisiereVideo;
            nrFisiere = fisiereVideo.Length;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (FisierVideo fisier in fisiereVideo)
            {
                sb.Append(fisier.denumireFisier).Append(", ");
            }
            if (sb.Length != 0)
            {
                return "Directorul " + denumireDirector + " cu calea: " + caleDirector + " are "
                    + nrFisiere + " fisiere: " + sb.ToString().Substring(0, sb.Length - 2);
            }
            else
                return "Directorul " + denumireDirector + " cu calea: " + caleDirector
                    + " nu are fisiere Video ";

        }

        public object Clone()
        {
            DirectorVideo dirClone = (DirectorVideo)this.MemberwiseClone();
            FisierVideo[] nouFis = new FisierVideo[fisiereVideo.Length];
            int i = 0;
            foreach (FisierVideo fis in fisiereVideo)
            {
                nouFis[i] = (FisierVideo)fis.Clone();
                i++;
            }
            dirClone.fisiereVideo = nouFis;
            return dirClone;
        }

        public int CompareTo(object obj)
        {
            DirectorVideo dirVid = (DirectorVideo)obj;
            if (nrFisiere < dirVid.nrFisiere)
                return -1;
            else
                if (nrFisiere > dirVid.nrFisiere)
                return 1;
            else
                return 0;
        }

        public bool Exista(string fisier)
        {
            foreach (FisierVideo fisierVideo in fisiereVideo)
                if (fisierVideo.denumireFisier == fisier)
                    return true;
            return false;
        }

        public override double CalculateDimVideo()
        {
            for (int i = 0; i < fisiereVideo.Length; i++)
                dim += fisiereVideo[i].dimensiuneFisier;
            return dim;
        }

      
    }
}
