using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, prod = 1;

            Console.WriteLine("Ingrese un numero del 1 al 10");
            num = int.Parse(Console.ReadLine());

            for (int n=1; n<=10; n++)
            {
                prod = num * n;

                Console.WriteLine("La multiplicacion es " + num + "x" + n + "=" + prod);
            }
        }
    }
}
