using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_ALPOT_CN34ZF
{
    class NincsIlyenEtelException : Exception
    {
        public NincsIlyenEtelException() : base("Nincs ilyen étel a listában.")
        {

        }
    }
}
