using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_ALPOT_CN34ZF
{
    class TúlSokMegrendelés : Exception
    {
        IÉtel etel { get; }
        public TúlSokMegrendelés(IÉtel etel) : base($"Az adott megrendelés meghaladja a maximum összértéket: {etel.ToString()}")
        {
            this.etel = etel;
        }


    }
}
