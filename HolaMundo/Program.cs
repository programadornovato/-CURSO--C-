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
            Animal a = new Animal();
            a.comer();
            a.correr();

            Humano h = new Humano();
            h.comer();
            h.correr();

            Perro p = new Perro();
            p.correr();
            p.comer();

            Pajaro pa = new Pajaro();
            pa.comer();
            pa.volar();
            pa.correr();
            Console.Read();
        }
    }
}
