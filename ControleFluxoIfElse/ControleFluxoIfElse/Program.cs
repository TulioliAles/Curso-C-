using System;

namespace ControleFluxoIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um número de 0 a 10: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 10)
            {
                Console.WriteLine("O número tem que estar entre 0 e 10!");
            } else
            {
                if (numero < 0)
                {
                    Console.WriteLine("O número deve ser maior que 0!");
                } else
                {
                    Console.WriteLine("O número digitado foi: " + numero);
                }
            }
        }
    }
}
