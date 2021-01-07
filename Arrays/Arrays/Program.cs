using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vogais = new char[] { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i <= vogais.Length - 1; i++)
            {
                Console.WriteLine(vogais[i]);
            }


            int[] numeros = new int[30];

            for(int j = 0; j <= numeros.Length - 1; j++)
            {
                numeros[j] = j;
            }

            for (int j = 0; j <= numeros.Length - 1; j++)
            {
                Console.WriteLine("O número no indice [" + j + "] = " + numeros[j]);
            }
        }
    }
}
