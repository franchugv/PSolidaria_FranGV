using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSolidaria_FranGV
{
    public static class Conversiones
    {
        public static int ConvertInt(string cadena)
        {
            int numeroFinal = 0;
            numeroFinal = Convert.ToInt32(cadena);
            return numeroFinal;
        }
    }
}
