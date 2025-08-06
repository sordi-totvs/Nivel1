using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ConsoleApp1
{
    internal class Exercicio3 : Exercicio
    {
        public Exercicio3()
        {
            Name = "Exercício 3";
        }

        protected override void MainProcess()
        {
            var nomeCompleto = new List<string>();

            Console.Write("Digite o primeiro número: ");
            var n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            var n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nSOMA");
            Console.WriteLine($"\n{n1} + {n2} = {n1 + n2}");

            Console.WriteLine("\nSUBTRAÇÃO");
            Console.WriteLine($"\n{n1} - {n2} = {n1 - n2}");

            Console.WriteLine("\nMULTIPLICAÇÃO");
            Console.WriteLine($"\n{n1} * {n2} = {n1 * n2}");

            Console.WriteLine("\nDIVISÃO");
            if(n2 == 0)
            {
                Console.WriteLine("N/A");
            }
            else
            {
                Console.WriteLine($"\n{n1} / {n2} = {n1 / n2}");
            };

            Console.WriteLine("\nMÉDIA");
            Console.WriteLine($"\n{(n1 + n2)/2}");
        }
    }
}
