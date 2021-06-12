using System;
using System.Collections;
using System.Windows.Forms;
using Microsoft.VisualBasic;
/*
Autor: Programador novato
Fecha: 01/01/2021
Este programa hace que los novatos aprenden a hacer
un codigo bonito y ya
*/
namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //listaNormal();
            listaDinamica();
            Console.Read();
        }
        public static void listaNormal() {
            Console.WriteLine("Humano inresa la cantidad de elementos de tu lista");
            int cantidad = int.Parse(Console.ReadLine());
            string[] lista = new string[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Humano ingresa elelemento "+(i+1));
                lista[i] = Console.ReadLine();
            }
            Console.WriteLine("Humano aqui esta tu lista");
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
        public static void listaDinamica() {
            ArrayList lista=new ArrayList();
            char respuesta;
            int i = 0;
            do
            {
                Console.WriteLine("Humano ingresa el valor "+(i+1));
                lista.Add(Console.ReadLine());
                Console.WriteLine("Humano quieres ingresar mas elementos a la lista s/n");
                respuesta = Console.ReadLine()[0];
            } while (respuesta == 's' || respuesta == 'S');
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
