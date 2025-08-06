using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ConsoleApp1
{
    internal class Exercicio4
    {
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Exercício 4");

            Caracteres();

            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadLine();
        }

        private void Caracteres()
        {
            Console.Write("Digite uma palavra ou frase: ");
            string texto1 = Console.ReadLine();

            Console.WriteLine($"\nNúmero de caracteres: {texto1.Length}");
        }
    }
}
