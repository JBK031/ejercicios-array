using System;

namespace Programa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3.Un programa que almacene en un array el número de días que tiene cada mes (supondremos que es un año no bisiesto), 
           pida al usuario que le indique un mes (1=enero, 12=diciembre) y muestre en pantalla el número de días que tiene ese mes.*/
            int[] dias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int mes;
            Console.WriteLine("Introducir el mes del 1 al 12:");
            mes = int.Parse(Console.ReadLine());

            if (mes == 1)
            {
                Console.WriteLine("Eligio el mes de Enero, que tiene un total de dias: " + dias[0]);
            }else if(mes ==2) 
            {

                Console.WriteLine("Eligio el mes de Febrero, que tiene un total de dias: " + dias[1]);
            }else if (mes==3)
            {
                Console.WriteLine("Eligio el mes de Marzo, que tiene un total de dias: " + dias[2]);
            }else if (mes == 4)
            {
                Console.WriteLine("Eligio el mes de Abril, que tiene un total de dias: " + dias[3]);
            }else if (mes == 5)
            {
                Console.WriteLine("Eligio el mes de Mayo, que tiene un total de dias: " + dias[4]);
            }else if (mes == 6)
            {
                Console.WriteLine("Eligio el mes de Junio, que tiene un total de dias: " + dias[5]);
            }else if (mes == 7)
            {
                Console.WriteLine("Eligio el mes de Julio, que tiene un total de dias: " + dias[6]);
            }else if (mes == 8)
            {
                Console.WriteLine("Eligio el mes de Agosto, que tiene un total de dias: " + dias[7]);
            }else if (mes == 9)
            {
                Console.WriteLine("Eligio el mes de Septiembre,que tiene un total de dias: " + dias[8]);
            }else if (mes == 10)
            {
                Console.WriteLine("Eligio el mes de Octubre,que tiene un total de dias: " + dias[9]);
            }else if (mes == 11)
            {
                Console.WriteLine("Eligio el mes de Noviembre,que tiene un total de dias: " + dias[10]);
            }else if (mes == 12)
            {
                Console.WriteLine("Eligio el mes de Diciembre,que tiene un total de dias: " + dias[11]);
            }else
            {
                Console.WriteLine("Puso el numero de un mes que ni existe, Verifique");
            }
            Console.ReadKey();
        }
    }
}
