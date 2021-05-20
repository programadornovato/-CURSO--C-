using System;
class Vehiculo
{
    string marca;
    string modelo;
    string sku;
    public Vehiculo(string _marca, string _modelo) {
        marca = _marca;
        modelo = _modelo;
    }
    public Vehiculo(string _sku) {
        sku = _sku;
    }
    public void acelera() {
        if (marca != null)
        {
            Console.WriteLine("El vehiculo  " + marca + " " + modelo + " esta acelerando ");
        }
        else {
            Console.WriteLine("El vehiculo  " + sku + "  esta acelerando ");
        }
    }
    public void acelera(int kmh) {
        if (marca != null)
        {
            Console.WriteLine("El vehiculo  " + marca + " " + modelo + " esta acelerando a " + kmh + " km/h ");
        }
        else {
            Console.WriteLine("El vehiculo  " + sku + " esta acelerando a " + kmh + " km/h ");
        }
    }
}
