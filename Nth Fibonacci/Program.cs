using System;

public class Fibonacci
{
    public static void Main()
    {

        Console.Write("Input Number: ");
        string numInput = Console.ReadLine();
        double Num = 0;
        double.TryParse(numInput, out Num);

        int a = 0;
        int b = 1;

        if (Num == 0)
        {
            Console.WriteLine("0");
        }
        else if (Num == 1)
        {
            Console.WriteLine("1");
        }
        else
        {
            for (int i = 2; i < Num; i++)
            {
                b = a + b;
                a = b - a;
            }
            Console.WriteLine(b);
        }
    }
}