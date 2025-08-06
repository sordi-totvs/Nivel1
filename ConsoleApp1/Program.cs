using System;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = -1;
            string input;
            bool success;

            while (option < 0)
            {
                option = -1;
                Console.Clear();
                Console.WriteLine("Selecione uma opção para continuar:\n0 = Sair");
                for(int i = 1; i <= 6; i++)
                {
                    Console.WriteLine(i + " = Exercício " + i);
                }
                input = Console.ReadLine();
                success = int.TryParse(input, out option);

                if (success && (option >= 1 && option <= 6))
                {
                    TryRun(option);
                    option = -1;
                }
              
            }

        }

        static void TryRun(int exerciseNumber)
        {
            string className = $"Exercicio{exerciseNumber}";

            Type type = Type.GetType($"ConsoleApp1.{className}");

            if (type == null)
            {
                Console.WriteLine($"Classe inválida: {className}");
                return;
            }

            Exercicio exercicio = (Exercicio)Activator.CreateInstance(type);
            exercicio.Run();
        }
    }
}
