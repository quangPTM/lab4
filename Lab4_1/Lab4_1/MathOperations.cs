using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate void SampleDelegate(int a, int b);
class MathOperations
{
    public void Add(int a, int b)
    {
        Console.WriteLine("Add ResultL {0}", a + b);
    }
    public void Subtract(int x, int y)
    {
        Console.WriteLine("Subtract Result: {0} ", x - y);
    }
    public void Multiply(int x, int y)
    {
        Console.WriteLine("Multiply Result: {0}", x * y);
    }
    public void Divide(int x, int y)
    {
        if (y != 0)
        {
            Console.WriteLine("Divide Result: {0}", (double)x / y);
        }
        else
        {
            Console.WriteLine("Divide Result: invalid.");
        }
    }
}


