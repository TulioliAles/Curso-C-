using System;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Iniciando a variável dataNascimento com null, cai no else e mostra a exception.
             * 
             * Iniciando a variável com DateTime.Now, cai no if e mostra a data atual no console.
             */
            DateTime? dataNascimento = null;

            if (dataNascimento.HasValue)
            {
                Console.WriteLine("A data de nascimento foi definida");
            }
            else
            {
                Console.WriteLine("A data de nascimento é null");
            }

            try
            {
                Console.WriteLine(dataNascimento.Value);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}
