using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_ALPOT_CN34ZF
{
    public delegate void TeljesitesKezelo(string etelNeve, string megrendelo, bool sikerultE);
    interface IÉtel : IComparable
    {
        int Ár { get; }
        string Megrendelő { get; }
        bool Sütés();
    }
}
