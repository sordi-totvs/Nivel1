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

                if (!success) {
                    option = -1;
                    continue;
                }

                switch (option)
                {
                    case 0:
                        {
                            return;
                        }
                    case 1:
                        {
                            var exercicio = new Exercicio1();
                            exercicio.Run();
                            break;
                        }
                    case 2:
                        {
                            var exercicio = new Exercicio2();
                            exercicio.Run();
                            break;
                        }
                    case 3:
                        {
                            var exercicio = new Exercicio3();
                            exercicio.Run();
                            break;
                        }
                    case 4:
                        {
                            var exercicio = new Exercicio4();
                            exercicio.Run();
                            break;
                        }
                    case 5:
                        {
                            var exercicio = new Exercicio5();
                            exercicio.Run();
                            break;
                        }
                    case 6:
                        {
                            var exercicio = new Exercicio6();
                            exercicio.Run();
                            break;
                        }
                }

                option = -1;
            }

        }
    }
}
