using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Exercicio2 : Exercicio
    {

        public Exercicio2()
        {
            Name = "Exercício 2";
        }

        protected override void MainProcess()
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
