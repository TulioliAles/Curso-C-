using System;

namespace CalculaIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;
            string resposta = "s";

            while (resposta != "n")
            {
                Console.Clear();

                Console.WriteLine("Informe seu peso (em Kg): ");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe sua altura (em Metros): ");
                altura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("O peso informado é {0} Kg e a altura informada é {1} m.", peso, altura);

                imc = calcularIMC(peso, altura);
                Console.WriteLine("O IMC é {0} ", imc);

                exibeResultado(imc);

                Console.WriteLine("Quer continuar? [s] [n]: ");
                resposta = Console.ReadLine();
            }
        }
            static double calcularIMC(double peso, double altura)
            {
                return peso / (Math.Pow(altura, 2));
            }

            static void exibeResultado(double imc)
            {
                if (imc < 18.5)
                {
                Console.WriteLine("Você está ABAIXO do peso!");
                } 
                else if (imc >= 18.5 && imc <= 25)
                {
                    Console.WriteLine("Seu peso está NORMAL!");
                }
                else if (imc > 25 && imc <= 30)
                {
                    Console.WriteLine("Você está ACIMA do peso!");
                }
                else if (imc > 30)
                {
                    Console.WriteLine("Você está OBESO!");
                }
            }
    }
}
