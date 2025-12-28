using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar() {

            double numero = 17.175;

            Console.WriteLine(numero.ToString("F1"));
            Console.WriteLine(numero.ToString("C"));
            Console.WriteLine(numero.ToString("#.##"));
            Console.WriteLine(numero.ToString("P"));


            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(numero.ToString("C3", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
