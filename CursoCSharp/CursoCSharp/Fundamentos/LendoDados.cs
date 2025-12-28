using System;


namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar(){

            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());


            Console.Write("Informe seu Salário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"Nome: {nome} idade: {idade} salário: {salario}");
        }
    }
}
