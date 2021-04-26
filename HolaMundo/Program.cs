using System;
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
        const double PI = 3.1416;
        const int semenas = 52, meses = 12;
        const string pagina = "programadornovato.com";
        static void Main(string[] args)
        {
            double doblePI = PI * 2;
            Console.WriteLine("El valor de PI="+PI);
            Console.WriteLine("El valor de 2xPI="+ doblePI);
            Console.WriteLine("Mi pagina es:"+ pagina);

            Console.Read();
        }
    }
}
