using System;
using System.Collections.Generic;

namespace Action
{
    class Program
    {
        static void Main()
        {
            List<Usuario> usuarios = new List<Usuario>() {
                new Usuario() { ID = 1, nome = "Pedro"},
                new Usuario() { ID = 2, nome = "Amanda"},
                new Usuario() { ID = 3, nome = "Gabriel"},
                new Usuario() { ID = 4, nome = "Jussara"}
            };

            usuarios.ForEach(new Action<Usuario>(MostrarDados));

            Console.ReadLine();
        }

        private static void MostrarDados (Usuario user)
        {
            Console.WriteLine(user.ID + "-" + user.nome);
        }
    }
}
