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
    class Auto {
        private string color = "";
        private int modelo = 0;
        private string marca = "";
        private bool acceso = false;
        public void meterLlave(string llave) {
            if (llave == "123456")
            {
                acceso = true;
                Console.WriteLine("Se tien acceso al auto");
            }
            else {
                acceso = false;
                Console.WriteLine("Llave incorrecta");
            }
        }
        public void mando(string accion) {
            if (acceso == true) {
                if (accion == "enciende")
                {
                    enciende();
                }
                if (accion == "acelera") {
                    acelera();
                }

                if (accion == "frena") {
                    frena();
                }
            }
            else
            {
                Console.WriteLine("No tienes acceso al auto");
            }

        }
        private void enciende() {
            Console.WriteLine("Se encendio el auto run run");
        }
        private void acelera() {
            Console.WriteLine("El auto esta acelerando");
        }
        private void frena() {
            Console.WriteLine("El auto ha frenado");
        }
    }
}
