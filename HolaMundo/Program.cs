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
            Console.WriteLine("Humano ingresa tu fecha de nacimiento en formato dd/MM/yyyy");
            string fechaNacString = Console.ReadLine();
            DateTime fechaNacDate = DateTime.Now;
            try
            {
                fechaNacDate = DateTime.ParseExact(fechaNacString, "dd/MM/yyyy", null);
            }
            catch (Exception e) {
                Console.WriteLine("Humano estupido escribe bien la fecha en formato dd/MM/yyyy "+e);
            }
            DateTime fechaActual = DateTime.Now;
            /*
            int años = fechaActual.Year - fechaNacDate.Year;
            Console.WriteLine("Humano tu tienes "+años+" años");
            */
            TimeSpan diferecia = fechaActual - fechaNacDate;
            double dias = diferecia.TotalDays;
            double años = Math.Floor(dias / 365);
            Console.WriteLine("Humano tu tienes " + años + " años");
            Console.Read();
        }
    }
}
