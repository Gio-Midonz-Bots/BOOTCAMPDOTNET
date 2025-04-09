using System;
using System.Linq;
using System.Collections.Generic;

namespace Calculadora;

public class Calculadora
{
    public void Somar(int x, int y)
    {
        Console.WriteLine($"{x} e {y} = {x + y}");
    }
    public void Subtrar(int x, int y)
    {
        Console.WriteLine($"{x} e {y} = {x - y}");
    }
    public void Multipicar(int x, int y)
    {
        Console.WriteLine($"{x} e {y} = {x * y}");
    }
    public void Dividir(int x, int y)
    {
        Console.WriteLine($"{x} e {y} = {x / y}");
    }
}
