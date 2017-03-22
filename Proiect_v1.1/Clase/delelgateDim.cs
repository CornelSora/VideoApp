using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prroiect_v1._0.Clase
{
    public class DimensiuneEventArgs : EventArgs
    {
        public string denumireFis;
        public int dim;

        public DimensiuneEventArgs(string denumireFis, int dim)
        {
            this.denumireFis = denumireFis;
            this.dim = dim;
        }
    }

    public class DimensiuneEvent
    {
        //definire delegat - tip pointer la functie
        public delegate void DimensiuneActionDelegate(object sender, DimensiuneEventArgs e);

        //definire eveniment
        public event DimensiuneActionDelegate DimEvent = null;

        //definire functie starter a evenimentului
        public void VerificaDim(DimensiuneEventArgs e)
        {
            if (DimEvent != null)
            {
                //se apeleaza evenimentul
                DimEvent(this, e);
            }
        }
    }

    public class DimensiuneHandler
    {
        //definire metoda pentru abonare la eveniment
        public void DoSomething(object sender, DimensiuneEventArgs e)
        {
            if (e.dim < 1000)
            {
                Console.WriteLine("Fisierul " +
                    e.denumireFis + " are dimensiunea prea mica. ");
            }
            else
                if (e.dim > 10000)
            {
                Console.WriteLine("Fisierul " +
                    e.denumireFis + " are dimensiunea prea mare. ");
            }
            else
                Console.WriteLine("Fisierul " + e.denumireFis + " are dimensiunea ok.");
        }

        //definire constructor
        public DimensiuneHandler(DimensiuneEvent dim)
        {
            //abonare metoda proprie la eveniment
            dim.DimEvent += new DimensiuneEvent.DimensiuneActionDelegate(this.DoSomething);
        }
    }
}
