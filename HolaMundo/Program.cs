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
            vocho1.color = "Verde";
            vocho1.modelo = 1980;
            vocho1.marca = "Vocho";
            Console.WriteLine(vocho1.color);
            Console.WriteLine(vocho1.modelo);
            Console.WriteLine(vocho1.marca);
            vocho1.enciende();
            vocho1.acelera();
            vocho1.frena();

            Auto chevy = new Auto();
            chevy.color = "azul";
            chevy.modelo = 2010;
            chevy.marca = "Chevrolet";
            Console.WriteLine(chevy.color);
            Console.WriteLine(chevy.modelo);
            Console.WriteLine(chevy.marca);
            chevy.enciende();
            chevy.acelera();
            chevy.frena();
            Console.Read();
        }
    }
    class Auto {
        public string color = "";
        public int modelo = 0;
        public string marca = "";
        public void enciende() {
            Console.WriteLine("Se encendio el auto run run");
        }
        public void acelera() {
            Console.WriteLine("El auto esta acelerando");
        }
        public void frena() {
            Console.WriteLine("El auto ha frenado");
        }
    }
}
