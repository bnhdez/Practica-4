using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int par = 0, impar = 0;

            for (int i=1; i<=25; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("par"+ i);
                    par++;
                }
                else if (i % 2 != 0)
                {
                    Console.Write("impar"+ i);
                    impar++;
                }
            }
        }
    }
}
