using System;
class Auto
{
    private string color = "";
    private int modelo = 0;
    private string marca = "";
    private bool acceso = false;
    public void meterLlave(string llave)
    {
        if (llave == "123456")
        {
            acceso = true;
            Console.WriteLine("Se tien acceso al auto");
        }
        else
        {
            acceso = false;
            Console.WriteLine("Llave incorrecta");
        }
    }
    public void mando(string accion)
    {
        if (acceso == true)
        {
            if (accion == "enciende")
            {
                enciende();
            }
            if (accion == "acelera")
            {
                acelera();
            }

            if (accion == "frena")
            {
                frena();
            }
        }
        else
        {
            Console.WriteLine("No tienes acceso al auto");
        }

    }
    private void enciende()
    {
        Console.WriteLine("Se encendio el auto run run");
    }
    private void acelera()
    {
        Console.WriteLine("El auto esta acelerando");
    }
    private void frena()
    {
        Console.WriteLine("El auto ha frenado");
    }
}
