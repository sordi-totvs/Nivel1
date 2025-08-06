using System;

namespace ConsoleApp1
{
    internal class Exercicio5 : Exercicio
    {
        public Exercicio5()
        {
            Name = "Exercício 5";
        }

        protected override void MainProcess()
        {
            Console.Write("Digite a placa do carro: ");
            string placa = Console.ReadLine().ToUpper();

            if (placa.Length != 7)
            {
                ShowResult(false, "A placa deve ter exatamente 7 caracteres.");
                return;                
            }
            for (int i = 0; i < 7; i++)
            {
                if (i < 3)
                {
                    if (!char.IsLetter(placa[i]))
                    {
                        ShowResult(false, $"O dígito da posição {i+1} deveria ser uma letra.");
                        return;
                    }
                }
                else
                {
                    if (!char.IsDigit(placa[i]))
                    {
                        ShowResult(false, $"O dígito da posição {i+1} deveria ser um número.");
                        return;
                    }
                }
            }
            ShowResult(true, "Placa validada com sucesso");
        }

        private void ShowResult(bool result, string message)
        {
            Console.WriteLine($"Resultado: {(result ? "Verdadeiro" : "Falso")}");
            Console.WriteLine(message);
        }
    }
}
