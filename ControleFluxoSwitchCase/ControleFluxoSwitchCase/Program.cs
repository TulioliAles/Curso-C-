using System;

namespace ControleFluxoSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string marca;
            string fabrica;

            Console.WriteLine("Digite a marca do seu carro: ");
            marca = Console.ReadLine();

            switch (marca)
            {
                case "Civic":
                case "Fit":
                case "City":
                    fabrica = "Honda";
                    break;

                case "Focus":
                case "Fiesta":
                    fabrica = "Ford";
                    break;

                case "Corolla":
                    fabrica = "Toyota";
                    break;

                default:
                    fabrica = "Desconhecida";
                    break;
            }

            Console.WriteLine("A fabricante do seu carro é {0}. ", fabrica);
        }
    }
}
