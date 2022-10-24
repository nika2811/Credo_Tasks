using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool looping = false;
            while (!looping) 
            { 
                Console.Write("\n\nEnter first number: ");
                string numInput1 = Console.ReadLine();

                double Num1 = 0;
                while (!double.TryParse(numInput1, out Num1))
                {
                    Console.Write("Text is not a number, Enter first number: : ");
                    numInput1 = Console.ReadLine();
                }


                Console.Write("Enter second number: ");
                string numInput2 = Console.ReadLine();

                double Num2 = 0;
                while (!double.TryParse(numInput2, out Num2))
                {
                    Console.Write("Text is not a number, Enter second number: ");
                    numInput2 = Console.ReadLine();
                }


                Console.Write("Enter Math operation (+ - * /): ");
                string oper = Convert.ToString(Console.ReadLine());


                if(oper == "+")
                {
                    Console.Write(Num1 + " + " + Num2 + " = " + (Num1 + Num2));
                }else if(oper == "-")
                {
                    Console.Write(Num1 + " - " + Num2 + " = " + (Num1 - Num2));
                }else if(oper == "*")
                {
                    Console.Write(Num1 + " * " + Num2 + " = " + (Num1 * Num2));
                }else if(oper == "/")
                {
                    if (Num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    else
                    {
                        Console.Write(Num1 + " / " + Num2 + " = " + (Num1 / Num2));
                    }
                }
                
            }

        }
    }
}