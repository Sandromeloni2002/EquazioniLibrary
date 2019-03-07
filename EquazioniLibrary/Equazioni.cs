using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        static bool IsDetermined(double a, double b)
        {
            bool ret = false;

            if (a != 0 && b != 0) ret = true;

            return ret;
        }
    }
}
