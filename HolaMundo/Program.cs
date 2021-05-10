using System;
using System.Windows.Forms;
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
            /*
            Console.WriteLine("Humano escribe una opcion\nacceso\nconfiguracion\nayuda");
            string seleccion = Console.ReadLine();
            seleccion = seleccion.ToLower();
            switch (seleccion) {
                case "acceso":
                    Console.WriteLine("Humano seleccionaste acceso");
                    break;
                case "configuracion":
                    Console.WriteLine("Humano seleccionaste configuracion");
                    break;
                case "ayuda":
                    Console.WriteLine("Humano seleccionaste ayuda");
                    break;
                default:
                    Console.WriteLine("Humano estupido no escribiste ninguna opcion");
                    break;
            }
            */
            Console.WriteLine("Humano escribe hola");
            string saludo = Console.ReadLine().ToLower();
            if (saludo == "hola")
            {
                Console.WriteLine("Hola humano como estas");
            }
            else {
                Console.WriteLine("Mi no entender");
            }
            Console.Read();
        }
    }
}
