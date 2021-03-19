using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate
{
    class Program
    {
        static void Main()
        {
            List<Usuario> usuarios = new List<Usuario>()
            {
                new Usuario { Nome = "Alessandro" },
                new Usuario { Nome = "Alessandra" },
                new Usuario { Nome = "Thiago" },
                new Usuario { Nome = "Lizanea" },
                new Usuario { Nome = "Matheus"}
            };
            //com Predicate (retorna um único elemento)
            Usuario pesq = usuarios.Find(new Predicate<Usuario>(Pesquisar));

            if (pesq != null)
                Console.WriteLine(pesq.Nome);

            // com Lambda (retorna uma coleção de elementos)
            var res  = usuarios.Where(n => n.Nome.StartsWith("Ale"));

            // com Linq (retorna uma coleção de elementos)
            var linq = from n in usuarios
                       where n.Nome.StartsWith("Ale")
                       select n;

            Console.ReadLine();
        }

        private static bool Pesquisar(Usuario user)
        {
            //return user.Nome.Length == 6;
            //return user.Nome.Equals("Lizanea");
            //return user.Nome.StartsWith("Ma");
            return user.Nome.Contains("ssa");
        }
    }
}
