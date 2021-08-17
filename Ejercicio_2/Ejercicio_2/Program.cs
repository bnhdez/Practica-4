using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant, num=0, ma=0, me=0;
            
            Console.WriteLine("Ingrese la cantidad de numeros a comparar: ");
            cant = int.Parse(Console.ReadLine());

            for (int i = 1; i<=cant; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    //comparamos los numeros entre si
                    ma = num;
                    me = num;
                }
                if (num > ma) { ma = num; }
                if (num < me) { me = num; }

                num = 0;
            }

            Console.WriteLine("El numero mayor es: " + ma);
            Console.WriteLine("El numero menor es: " + me);

        }
    }
}
