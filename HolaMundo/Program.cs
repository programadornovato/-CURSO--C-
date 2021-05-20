using System;
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
            Auto vocho1 = new Auto();
            vocho1.meterLlave("123456");
            vocho1.mando("enciende");

            Auto chevy = new Auto();
            chevy.meterLlave("123456");
            chevy.mando("enciende");

            Console.Read();
        }
    }
}
