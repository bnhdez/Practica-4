using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int alto;

            Console.Write("Ingrese la altura del triangulo: ");
            alto = int.Parse(Console.ReadLine());
            int ancho = alto;
            for (int a = 1; a <= alto; a++)
            {

                for (int b = 1; b <= ancho; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                ancho = ancho - 1;
            }
        }
    }
}
