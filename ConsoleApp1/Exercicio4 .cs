using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Exercicio4 : Exercicio
    {

        public Exercicio4()
        {
            Name = "Exercício 4";
        }

        protected override void MainProcess()
        {
            Console.Write("Digite uma palavra ou frase: ");
            string texto1 = Console.ReadLine();

            Console.WriteLine($"\nNúmero de caracteres: {texto1.Length}");
        }
    }
}
