using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_ALPOT_CN34ZF
{
    class Pizza : IÉtel
    {
        public string nev { get; set; }
        private int ar { get; set; }
        private string megrendelo { get; set; }
        public int Ár { get { return ar; } }
        public string Megrendelő { get { return megrendelo; } }

        public int CompareTo(object obj)
        {
            return Ár;
        }

        public virtual bool Sütés()
        {
            return true;
        }

        public Pizza(string nev, int ar, string megrendelo)
        {
            this.nev = nev;
            this.ar = ar;
            this.megrendelo = megrendelo;
        }

        public override string ToString()
        {
            return nev;
        }
    }
}
