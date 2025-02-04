using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_ALPOT_CN34ZF
{
    class ListaBejaro<T> : IEnumerator
    {
        ListaElem<T> fej;
        ListaElem<T> aktualis;

        public ListaBejaro(ListaElem<T> fej)
        {
            this.fej = fej;
            this.aktualis = new ListaElem<T>();
            this.aktualis.kovetkezo = fej;
        }

        public object Current
        {
            get
            {
                return aktualis.tartalom;
            }
        }

        public bool MoveNext()
        {
            if (aktualis == null)
            {
                return false;
            }
            aktualis = aktualis.kovetkezo;
            return aktualis != null;
        }

        public void Reset()
        {
            aktualis = new ListaElem<T>();
            aktualis.kovetkezo = fej;
        }
    }
}
