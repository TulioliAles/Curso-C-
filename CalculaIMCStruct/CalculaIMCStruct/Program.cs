using System;

namespace CalculaIMCStruct
{
    class Program
    {
        public struct Pessoa
        {
            public double Altura;
            public double Peso;
            public double IMC;
        }

        static void Main(string[] args)
        {
            Pessoa Tulioli = new Pessoa();

            string resposta = "s";

            while (resposta != "n")
            {
                Console.WriteLine("Informe seu Peso (Kg): ");
                Tulioli.Peso = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe sua Altura (M): ");
                Tulioli.Altura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("O Peso informado é {0} Kg e a Altura informada é {1} m.", Tulioli.Peso, Tulioli.Altura);

                Tulioli.IMC = CalcularIMC(Tulioli.Peso, Tulioli.Altura);
                Console.WriteLine("Seu IMC é {0}.", Tulioli.IMC);

                ExibeResultado(Tulioli.IMC);

                Console.WriteLine("Deseja continuar? [s] [n] ?");
                resposta = Console.ReadLine();
            }

            static double CalcularIMC(double peso, double altura)
            {
                return peso / (Math.Pow(altura, 2));
            }

            static void ExibeResultado(double imc)
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
}
