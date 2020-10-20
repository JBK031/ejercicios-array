using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.Un programa que pida al usuario 4 números, los memorice (utilizando un array),
            calcule su media aritmética y después muestre en pantalla la media y los datos tecleados.*/
            int[] num = new int[4];
            int medida;

            Console.WriteLine("Introducir el primero de los cuatros numeros ");
            num[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el segundo de los cuatros numeros :");
            num[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el tercer de los cuatros numeros :");
            num[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el ultimo numero de los cuatros :");
            num[3] = int.Parse(Console.ReadLine());

            medida = (num[0] + num[1] + num[2] + num[3]) / 4;
            Console.WriteLine("La medida aritmetica de los numero es : " + medida);

            Console.WriteLine("Los numeros que introdujo fueron " + num[0]+ "," +num[1]+ "," +num[2]+ "," +num[3]);
            Console.ReadKey();
        }
    }
}
