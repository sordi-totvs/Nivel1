using System;

namespace ConsoleApp1
{
    internal class Exercicio
    {
        protected string Name;
        public void Run()
        {
            Console.Clear();
            Console.WriteLine(Name);

            MainProcess();

            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadLine();
        }

        protected virtual void MainProcess()
        {

        }
    }
}
