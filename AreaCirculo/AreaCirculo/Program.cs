using System;

namespace AreaCirculo
{
    class AreaCirculo
    {
        static void Main(string[] args)
        {
            double raioCirculo, areaCirculo;
            const double PI = 3.1416;

            raioCirculo = 10.0;
            areaCirculo = (raioCirculo * raioCirculo) * PI;

            Console.WriteLine("A área do circulo de raio 10 é: " + areaCirculo);
        }
    }
}
