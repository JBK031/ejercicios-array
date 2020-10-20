using System;

namespace Programa_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5.Un programa que prepare espacio para un máximo de 100 nombres. El usuario deberá ir introduciendo un nombre cada vez, hasta que se pulse Intro sin teclear nada, 
            momento en el que dejarán de pedirse más nombres y se mostrará en pantalla la lista de los nombres que se han introducido.*/
            
            string[] nombre = new string[100];

            for (int i =0; i < 100; i++)
            {
                
                Console.WriteLine("Introducir el nombre: ");
                nombre[i] = Console.ReadLine();

                
            }
        }
    }
}
