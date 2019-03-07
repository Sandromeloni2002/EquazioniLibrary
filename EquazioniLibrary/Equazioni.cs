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

        static bool IsInconsisted(double a, double b)
        {
            bool ret = false;

            if (a != 0 && b == 0) ret = true;

            return ret;
        }

        static bool IsDegree2(double a)
        {
            bool ret = false;

            if (a != 0) ret = true;

            return ret;
        }

        static double Delta(double a, double b, double c)
        {
            double ret = 0;

            ret = (b * b) - (4 * a * c);

            return ret;
        }
    }
}
