using System;

namespace ConsoleApp1
{
    internal class Exercicio1 : Exercicio
    {
        public Exercicio1()
        {
            Name = "Exercício 1";
        }

        protected override void MainProcess()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine().Trim();
            Console.WriteLine($"Olá, {nome}! Seja muito bem vindo!");
        }
    }
}
