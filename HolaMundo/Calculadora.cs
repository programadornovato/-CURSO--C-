using System;
class Calculadora
{
    public int suma(int num1, int num2) {
        int res = 0;
        if (num1 > 0 && num2 > 0) {
            res = num1 + num2;
        }
        return res;
    }
    public int resta(int num1, int num2) {
        int res = 0;
        if (num1 > 0 && num2 > 0) {
            res = num1 - num2;
        }
        return res;
    }
    public int multiplicacion(int num1, int num2) {
        int res = 0;
        if (num1 > 0 && num2 > 0) {
            res = num1 * num2;
        }
        return res;
    }
    public double divicion(double num1, double num2) {
        double res = 0;
        if (num1 > 0 && num2 > 0) {
            res = num1 / num2;
        }
        return res;
    }
}
