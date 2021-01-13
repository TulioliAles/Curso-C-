using System;
using System.IO;

namespace FuncaoRecursiva
{
    class Program
    {
        private static void LerArquivo(int numeroArquivo)
        {
            string caminhoArquivo = @"C:\arquivos\Arq" + numeroArquivo + ".txt";

            if (File.Exists(caminhoArquivo))
            {
                using (StreamReader arquivo = File.OpenText(caminhoArquivo))
                {
                    string linha;
                    while((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }

                string caminhoArquivo2 = @"C:\arquivos\Arq" + (numeroArquivo + 1) + ".txt";
                if (File.Exists(caminhoArquivo2))
                {
                    LerArquivo(numeroArquivo + 1);
                }
            }
        }

        static void Main(string[] args)
        {
            LerArquivo(1);
        }
    }
}
