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
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hola humano, bienvenido a tu pn");
                Console.WriteLine("Ingresa el numero de la opcion que quieres elegir:");
                Console.WriteLine("1.- Ver saldo");
                Console.WriteLine("2.- Ingresar dinero");
                Console.WriteLine("3.- Sacar dinero");
                Console.WriteLine("4.- Salir");
                int opcion = int.Parse(Console.ReadLine());
                double saldo = 100;
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Tu saldo es de $" + saldo);
                        break;
                    case 2:
                        Console.WriteLine("Humano cuanto dinero quieres ingresar:");
                        double dineroIngresar = double.Parse(Console.ReadLine());
                        saldo = saldo + dineroIngresar;
                        Console.WriteLine("Haz ingresado $" + dineroIngresar + " y tu saldo es de $" + saldo);
                        break;
                    case 3:
                        Console.WriteLine("Humano cuanto dinero quieres retirar:");
                        double dineroRetirar = double.Parse(Console.ReadLine());
                        if (dineroRetirar > saldo)
                        {
                            Console.WriteLine("Humano pillin como que querias retirar mas dinero de lo que tienes tu saldo es de $" + saldo);
                        }
                        else
                        {
                            saldo = saldo - dineroRetirar;
                            Console.WriteLine("Haz retirado $" + dineroRetirar + " y tu saldo es de $" + saldo);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Adio humano gracias por usar el pn");
                        break;
                    default:
                        Console.WriteLine("Humano estupido " + opcion + " no es una opcion valida");
                        break;
                }
            }
            catch (Exception e) {
                Console.WriteLine("Humano estupido haz ingresa un valor no valido "+e);
            }

            Console.Read();
        }
    }
}
