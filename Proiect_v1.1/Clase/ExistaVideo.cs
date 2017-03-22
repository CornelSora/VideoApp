using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prroiect_v1._0.Clase
{
    interface ExistaVideo
    {
        FisierVideo[] fisiereVideo { get; set; }
        bool Exista(string fisier);
    }
}
