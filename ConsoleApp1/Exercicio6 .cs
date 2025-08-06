using System;

namespace ConsoleApp1
{
    internal class Exercicio6
    {
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Exercício 6");

            MainProcess();

            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadLine();
        }

        private void MainProcess()
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
