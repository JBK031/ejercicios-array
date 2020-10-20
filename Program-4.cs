using Microsoft.VisualBasic;
using System;

namespace Programa_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.Un programa que pida al usuario 10 números y luego calcule y muestre cuál es el mayor de todos ellos.
            int[] numero = new int[10];

            Console.WriteLine("Introducir el 1 de 10 numeros: ");
            numero[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el 2 de 10 numeros: ");
            numero[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el 3 de 10 numeros: ");
            numero[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el 4 de 10 numeros: ");
            numero[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el 5 de 10 numeros: ");
            numero[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el 6 de 10 numeros: ");
            numero[5] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el 7 de 10 numeros: ");
            numero[6] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el 8 de 10 numeros: ");
            numero[7] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el 9 de 10 numeros: ");
            numero[8] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el 10 de 10 numeros: ");
            numero[9] = int.Parse(Console.ReadLine());
            int suma;
            suma = numero[0] + numero[1] + numero[2] + numero[3] + numero[4] + numero[5] + numero[6] + numero[7] + numero[8] + numero[9];
            Console.WriteLine("El resultado de los calculos es: " +suma);

            if ((numero[0]>numero[1]) &&(numero[0]>numero[2]) && (numero[0]>numero[3]) && (numero[0] > numero[4]) && (numero[0] > numero[5]) && (numero[0] > numero[6]) && (numero[0] > numero[7]) && (numero[0] > numero[8]) && (numero[0] > numero[9]))
            {
                Console.WriteLine("El mayor es: " + numero[0]);
            }else if ((numero[1] > numero[0]) && (numero[1] > numero[2]) && (numero[1] > numero[3]) && (numero[1] > numero[4]) && (numero[1] > numero[5]) && (numero[1] > numero[6]) && (numero[1] > numero[7]) && (numero[1] > numero[8]) && (numero[1] > numero[9]))
            {
                Console.WriteLine("El mayor es: " + numero[1]);
            }else if ((numero[2] > numero[0]) && (numero[2] > numero[1]) && (numero[2] > numero[3]) && (numero[2] > numero[4]) && (numero[2] > numero[5]) && (numero[2] > numero[6]) && (numero[2] > numero[7]) && (numero[2] > numero[8]) && (numero[2] > numero[9]))
            {
                Console.WriteLine("El mayo es : " + numero[2]);
            }else if ((numero[3] > numero[0]) && (numero[3] > numero[1]) && (numero[3] > numero[2]) && (numero[3] > numero[4]) && (numero[3] > numero[5]) && (numero[3] > numero[6]) && (numero[3] > numero[7]) && (numero[3] > numero[8]) && (numero[3] > numero[9]))
            {
                Console.WriteLine("El mayor es: " + numero[3]);
            }else if ((numero[4] > numero[0]) && (numero[4] > numero[1]) && (numero[4] > numero[2]) && (numero[4] > numero[3]) && (numero[4] > numero[5]) && (numero[4] > numero[6]) && (numero[4] > numero[7]) && (numero[4] > numero[8]) && (numero[4] > numero[9]))
            {
                Console.WriteLine("El mayor es: " +numero[4]);
            }else if ((numero[5] > numero[0]) && (numero[5] > numero[1]) && (numero[5] > numero[2]) && (numero[5] > numero[3]) && (numero[5] > numero[4]) && (numero[5] > numero[6]) && (numero[5] > numero[7]) && (numero[5] > numero[8]) && (numero[5] > numero[9]))
            {
                Console.WriteLine("El mayor es: " + numero[5]);
            }else if ((numero[6] > numero[0]) && (numero[6] > numero[1]) && (numero[6] > numero[2]) && (numero[6] > numero[3]) && (numero[6] > numero[4]) && (numero[6] > numero[5]) && (numero[6] > numero[7]) && (numero[6] > numero[8]) && (numero[6] > numero[9]))
            {
                Console.WriteLine("El mayor es: " + numero[6]);
            }else if ((numero[7] > numero[0]) && (numero[7] > numero[1]) && (numero[7] > numero[2]) && (numero[7] > numero[3]) && (numero[7] > numero[4]) && (numero[7] > numero[5]) && (numero[7] > numero[6]) && (numero[7] > numero[8]) && (numero[7] > numero[9]))
            {
                Console.WriteLine("El mayor es: " + numero[7]);
            }else if ((numero[8] > numero[0]) && (numero[8] > numero[1]) && (numero[8] > numero[2]) && (numero[8] > numero[3]) && (numero[8] > numero[4]) && (numero[8] > numero[5]) && (numero[8] > numero[6]) && (numero[8] > numero[7]) && (numero[8] > numero[9]))
            {
                Console.WriteLine("El mayor es: " + numero[8]);
            }
            else
            {
                Console.WriteLine("El mayor es: " + numero[9]);
            }
            Console.ReadKey();




           
        }
    }
}
