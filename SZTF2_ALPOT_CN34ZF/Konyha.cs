using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_ALPOT_CN34ZF
{
    class Konyha<T> where T : IÉtel
    {
        LancoltLista<T> etelek = new LancoltLista<T>();

        private int maxHitel;
        public Konyha(int maxhitel)
        {
            this.maxHitel = maxhitel;
        }

        public event TeljesitesKezelo RendelesTeljesitve;
        public void Megrendeles(T elem)
        {
            if (maxHitel >= elem.Ár)
            {
                etelek.Beszuras(elem);
                maxHitel -= elem.Ár;
            }
            else
            {
                throw new TúlSokMegrendelés(elem);
            }
        }

        public void Kiszolgalas(int bevetelcel)
        {
            foreach (T etel in etelek)
            {
                bool sikerulte = false;
                if ((bevetelcel -= etel.Ár) > 0)
                {
                    if (etel.Sütés())
                    {
                        sikerulte = true;
                        etelek.Torles(etel);
                    }
                }
                RendelesTeljesitve?.Invoke(etel.ToString(), etel.Megrendelő, sikerulte);
            }
        }
    }
}
