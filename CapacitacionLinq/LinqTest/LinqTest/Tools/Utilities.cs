using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LinqTest.Tools
{
    public static class Utilities
    {
        public static string OnlyNumbers(this string cadena)
        {
            var regex = new Regex(@"^[A-Za-z.]+$");
            cadena = regex.Replace(cadena, "");
            return cadena;
        }
    }
}
