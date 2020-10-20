using System;

namespace Programa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un programa que pida al usuario 5 números reales (pista: necesitarás un array de "float")
            y luego los muestre en el orden contrario al que se introdujeron.*/

            float[] reales = new float[5];

            Console.WriteLine("Introducir el 1 de 5 numeros: ");
            reales[0] = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el 2 de 5 numeros: ");
            reales[1] = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el 3 de 5 numeros: ");
            reales[2] = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducit el 4 de 5 numeros: ");
            reales[3] = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el 5 de 5 numeros: ");
            reales[4] = float.Parse(Console.ReadLine());

            Console.WriteLine("El orden contrario es: " + reales[4] + "," + reales[3] + "," + reales[2] + "," + reales[1] + "," +reales[0]);
            Console.ReadKey();
        }
    }
}
