using System;
using System.Collections.Generic;

namespace ColeçõesComGenerics
{
    class ColecoesGenerics
    {
        static void Main(string[] args)
        {
            List<Carro> carros = new List<Carro>()
            {
                new Carro {ID = 1, Marca = "VW", Modelo = "Fusca"},
                new Carro {ID = 2, Marca = "VW", Modelo = "Kombi"},
                new Carro {ID = 3, Marca = "Chevrolet", Modelo = "Opala"},
                new Carro {ID = 4, Marca = "Ford", Modelo = "Corcel"}
            };

            foreach (var carro in carros)
            {
                Console.WriteLine(string.Format("ID: {0} - Marca: {1} - Modelo: {2}", carro.ID, carro.Marca, carro.Modelo));
            }

            Console.ReadKey();
        }
    }
}
