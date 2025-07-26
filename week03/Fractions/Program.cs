using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions f1 = new Fractions();
        Console.WriteLine("Default fraction created:" + f1.GetTop() + "/" + f1.GetBottom());
        Fractions f2 = new Fractions(3);
        Console.WriteLine("Fraction with numerator 3 created:" + f2.GetTop() + "/" + f2.GetBottom());
        Fractions f3 = new Fractions(2, 5);
        Console.WriteLine("Fraction with numerator 2 and denominator 5 created:" + f3.GetTop() + "/" + f3.GetBottom());


        f2.SetBottom(4);
        Console.WriteLine("Updated fraction f2 to: " + f2.GetFractionString());
        Console.WriteLine("Decimal value of f2: " + f2.GetDecimalValue());
        f3.SetTop(6);
        Console.WriteLine("Updated fraction f3 to: " + f3.GetFractionString());
        Console.WriteLine("Decimal value of f3: " + f3.GetDecimalValue());

    }
}