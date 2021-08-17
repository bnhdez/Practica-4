using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i<=300; i++)
            {
                //si el numero se divide entre 2 y tiene residuo 0 es par, si no es impar
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " par");
                }
                else if (i % 2 != 0)
                {
                    Console.WriteLine(i + " impar");
                }
            }
        }
    }
}
