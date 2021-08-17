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
            //Primera funcion for para altura
            for (int a = 1; a <= alto; a++)
            {
                //Segunda funcion for para ancho
                for (int b = 1; b <= ancho; b++)
                {
                    //al usar solo console.write el * se escribira n veces en la misma linea
                    Console.Write("*");
                }
                //Al usar console.writeline hara un salto n veces para imprimir el *
                Console.WriteLine();
                ancho = ancho - 1;
            }
        }
    }
}
