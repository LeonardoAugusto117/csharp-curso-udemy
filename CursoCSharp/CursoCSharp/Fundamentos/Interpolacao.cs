using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Interpolacao
    {
        public static void Executar() {

            string nome = "Xbox Serie x";
            string marca = "Xbox";
            double preco = 4500.49;

            Console.WriteLine("Console " + nome + " Da marca " + marca + " Valor " + preco);
            Console.WriteLine("Console {0} Da marca {1} Valor {2} ", nome,marca,preco);
            Console.WriteLine($"Console {nome} Da marca {marca} Valor {preco}");
            

        }
    }
}
