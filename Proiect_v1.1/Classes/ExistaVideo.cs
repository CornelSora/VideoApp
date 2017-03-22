using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_v1._1.Classes
{
    interface ExistaVideo
    {
        FisierVideo[] fisiereVideo { get; set; }
        bool Exista(string fisier);
    }
}
