using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int par = 0, impar = 0;

            for (int i=1; i<=300; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " par");
                    par++;
                }
                else if (i % 2 != 0)
                {
                    Console.WriteLine(i + " impar");
                    impar++;
                }
            }
        }
    }
}
