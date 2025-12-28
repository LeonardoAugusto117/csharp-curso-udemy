using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Inferencias
    {
        public static void Executar() {

            var nome = "Leonardo";
            Console.WriteLine(nome);

           /* "var numero;" <--- Desta maneira o compilador informarar o erro, segue abaixo uma possivel solução.
            * Necessario sempre que for usar o VAR informar o valor que aquela variavel recebera para que o compilador
            * Saiba o que está sendo referenciado nela.
            */
            var numero = 0;
            numero = 10;
            Console.WriteLine(numero);

            int a;
            int b = 3;

            int soma = a = 2 + b;
            Console.WriteLine(soma);


        }
    }
}
