using System;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Exercicio6 : Exercicio
    {
        public Exercicio6()
        {
            Name = "Exercício 6";
        }

        protected override void MainProcess()
        {
            DateTime dateTime = DateTime.Now;

            Console.WriteLine("Formato completo: ");
            Console.WriteLine(dateTime.ToString("F"));

            Console.WriteLine("\nApenas a data: "); 
            Console.WriteLine(dateTime.ToString("d"));

            Console.WriteLine("\nApenas a hora: "); 
            Console.WriteLine(dateTime.ToString("t"));

            Console.WriteLine("\nData com o mês por extenso: ");
            Console.WriteLine(dateTime.ToString("dd/MMMM/yyyy"));

        }
    }
}
