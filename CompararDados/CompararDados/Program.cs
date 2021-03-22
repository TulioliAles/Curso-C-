using System;
using System.Collections.Generic;

namespace CompararDados
{
    class Program
    {
        static void Main()
        {
            List<Usuario> usuarios = new List<Usuario>()
            {
                new Usuario { nome = "Pedro" },
                new Usuario { nome = "Robson" },
                new Usuario { nome = "Maria" },
                new Usuario { nome = "C" },
                new Usuario { nome = "B" },
                new Usuario { nome = "A" }
            };

            usuarios.Sort(new Comparison<Usuario>(Ordenar));

            usuarios.ForEach(new Action<Usuario>(Exibir));

            Console.ReadLine();
        }

        private static int Ordenar(Usuario u1, Usuario u2)
        {
            return Comparer<string>.Default.Compare(u1.nome, u2.nome);
        }

        private static void Exibir(Usuario user)
        {
            Console.WriteLine(user.nome);
        }
    }
}
