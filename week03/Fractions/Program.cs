using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction1 = new Fraction();
        Console.WriteLine($"{fraction1.GetFractionString()}\n{fraction1.GetDecimalValue()}");

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"{fraction2.GetFractionString()}\n{fraction2.GetDecimalValue()}");

        Fraction fraction3 = new Fraction(3,4);
        Console.WriteLine($"{fraction3.GetFractionString()}\n{fraction3.GetDecimalValue()}");

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine($"{fraction4.GetFractionString()}\n{fraction4.GetDecimalValue()}");
    }
}