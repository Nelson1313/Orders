using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_ALPOT_CN34ZF
{
    class ListaElem<T>
    {
        public T tartalom { get; set; }
        public ListaElem<T> kovetkezo;
    }
    class LancoltLista<T> : IEnumerable where T : IComparable
    {
        private ListaElem<T> fej;

        public void Beszuras (T tartalom)
        {
            ListaElem<T> uj = new ListaElem<T>();
            uj.tartalom = tartalom;

            ListaElem<T> p = fej;
            ListaElem<T> e = null;

            while (p != null && p.tartalom.CompareTo(p.tartalom) < tartalom.CompareTo(p.tartalom))
            {
                e = p;
                p = p.kovetkezo;
            }
            if (e == null)
            {
                uj.kovetkezo = fej;
                fej = uj;
            }
            else
            {
                uj.kovetkezo = p;
                e.kovetkezo = uj;
            }
        }

        public void Torles (T torlendo)
        {
            ListaElem<T> p = fej;
            ListaElem<T> e = null;

            while (p != null && p.tartalom.GetHashCode() != torlendo.GetHashCode())
            {
                e = p;
                p = p.kovetkezo;
            }
            if (p != null)
            {
                if (e == null)
                {
                    fej = p.kovetkezo;
                }
                else
                {
                    e.kovetkezo = p.kovetkezo;
                }
            }
            else
            {
                throw new NincsIlyenEtelException();
            }
        }

        public bool VanEMegEtel()
        {
            return fej != null;
        }

        public IEnumerator GetEnumerator()
        {
            return new ListaBejaro<T>(fej);
        }
    }
}
