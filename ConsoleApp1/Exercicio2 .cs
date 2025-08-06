using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ConsoleApp1
{
    internal class Exercicio2
    {
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Exercício 2");

            LerNome();

            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadLine();
        }

        private void LerNome()
        {
            var nomeCompleto = new List<string>();

            Console.Write("Digite seu nome: ");
            nomeCompleto.Add(Console.ReadLine());

            Console.Write("Digite seu sobrenome: ");
            nomeCompleto.Add(Console.ReadLine());

            Console.WriteLine($"Olá, {string.Join(" ", nomeCompleto)}! Seja muito bem vindo!");
        }
    }
}
