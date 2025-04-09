using System;
using System.Linq;
using Calculadora;

namespace Calculadora;

public static class Program
{
    public static void Main()
    {
        Calculadora calc = new Calculadora();
        calc.Somar(10, 30);
        calc.Subtrar(10, 5);
        calc.Multipicar(9, 3);
        calc.Dividir(3, 3);
    }
}
