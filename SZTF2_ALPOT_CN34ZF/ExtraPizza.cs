using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_ALPOT_CN34ZF
{
    class ExtraPizza : Pizza
    {
        static int darabszam = 0;

        public ExtraPizza(string nev, int ar, string megrendelo) : base(nev, ar, megrendelo)
        {

        }

        public override bool Sütés()
        {
            darabszam++;
            if (darabszam > 10)
            {
                return false;
            }
            return true;
        }
    }
}
