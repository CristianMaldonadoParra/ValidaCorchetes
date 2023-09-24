using System;

namespace ValidaCorchetes
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite uma string contendo apenas colchetes:");
            string input = Console.ReadLine();

            try
            {
                if (VerificadorColchetes.ValidarEntrada(input))
                {
                    if (VerificadorColchetes.VerificarOrdemColchetes(input))
                    {
                        Console.WriteLine("A ordem dos colchetes é válida.");
                    }
                    else
                    {
                        Console.WriteLine("A ordem dos colchetes não é válida.");
                    }
                }
                else
                {
                    Console.WriteLine("A entrada é inválida. Por favor, forneça uma string contendo apenas colchetes.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
