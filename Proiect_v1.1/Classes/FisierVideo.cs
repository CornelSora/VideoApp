using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_v1._1.Classes
{
    public class FisierVideo : ICloneable, IComparable
    {
        public string denumireFisier { get; set; }
        public string caleFisier { get; set; }
        public string gen { get; set; }
        public float rating { get; set; }
        public bool vizualizat { get; set; }
        public string extensie { get; set; }
        public double dimensiuneFisier { get; set; }

        public FisierVideo()
        {
        }

        public FisierVideo(string denumirFisier, string caleFisier, double dimensiuneFisier)
        {
            this.denumireFisier = denumireFisier;
            this.caleFisier = caleFisier;
            this.rating = 0;
            this.vizualizat = false;
            this.dimensiuneFisier = dimensiuneFisier;
        }

        public FisierVideo(string denumirFisier, string caleFisier)
        {
            this.denumireFisier = denumireFisier;
            this.caleFisier = caleFisier;
            this.rating = 0;
            this.vizualizat = false; 
        }

        public FisierVideo(string denumirFisier)
        {
            this.denumireFisier = denumireFisier;
            this.caleFisier = null;
            this.rating = 0;
            this.vizualizat = false;
        }

        public override string ToString()
        {
            if (this.vizualizat == true)
            return "Fisierul video: " + denumireFisier + " are calea: "
                + caleFisier + " rating-ul: " + rating + " si a fost vizualizat.";
            else
                return "Fisierul video: " + denumireFisier + " are calea: "
                    + caleFisier + " rating-ul: " + rating + " si nu a fost vizualizat.";
        }

        public int CompareTo(object obj)
        {
            FisierVideo fisVid = (FisierVideo)obj;
            return denumireFisier.CompareTo(fisVid.denumireFisier);
        }

        public object Clone()
        {
            FisierVideo fisClone = (FisierVideo)this.MemberwiseClone();
            return fisClone;
        }

        public static bool operator>(FisierVideo f1, FisierVideo f2)
        {
            return f1.dimensiuneFisier > f2.dimensiuneFisier;
        }

        public static bool operator <(FisierVideo f1, FisierVideo f2)
        {
            return f1.dimensiuneFisier < f2.dimensiuneFisier;
        }

        
    }
}
