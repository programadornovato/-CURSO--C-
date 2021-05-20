using System;
class Persona
{
    private string nombre;
    private int edad;
    public Persona(string _nombre, int _edad) {
        nombre = _nombre;
        if (_edad < 0)
        {
            edad = 0;
        }
        else {
            edad = _edad;
        }
        
    }
    /*
    public void inicializar(string _nombre,int _edad) {
        nombre = _nombre;
        edad = _edad;
    }
    */
    public void mostrar() {
        Console.WriteLine("Nombre="+nombre+" Edad="+edad);
    }
}
