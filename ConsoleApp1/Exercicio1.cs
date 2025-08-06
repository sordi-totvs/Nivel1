using System;

namespace ConsoleApp1
{
    internal class Exercicio1
    {
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Exercício 1");

            LerNome();

            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadLine();
        }

        private void LerNome()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}! Seja muito bem vindo!");
        }
    }
}
