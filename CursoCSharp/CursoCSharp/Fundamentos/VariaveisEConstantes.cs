using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            double raio = 4.5;
            const double pi = 3.14;

            double area = pi * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine($"A area é {area}");

            //Tipos internos

            bool estarChovendo = false;
            Console.WriteLine($"Está chovendo {estarChovendo}");

            byte idade = 45;
            Console.WriteLine($"Idade: {idade}");

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine($"Saldo de Gols  {saldoDeGols}");

            short salario = short.MaxValue;
            Console.WriteLine($"Salário {salario}");

            int valorMenorInt = int.MinValue; //Mais usado dos Inteiros.
            Console.WriteLine($"Inteiro valor {valorMenorInt}");


        }
       
    }
}
