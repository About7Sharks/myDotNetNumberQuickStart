using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void workingWithIntegers()
        {
            Console.WriteLine("This program uses integers (no decmials)");
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            double maxDouble = double.MaxValue;
            double minDouble = double.MinValue;
            Console.WriteLine($"While the range of double is {minDouble} to {maxDouble}");
            

            decimal minDecimal = decimal.MinValue;
            decimal maxDecimal = decimal.MaxValue;
            Console.WriteLine($"While the range of the decimal type is {minDecimal} to {maxDecimal} which is less than the double type but has better precision");


            Console.WriteLine("Starting Program.......");
            // take a inputs
            int a;
            Console.WriteLine("Please enter a number for variable a: ");
            a = Convert.ToInt32(Console.ReadLine());
            int b;
            Console.WriteLine("Pretty please enter a number for variable b: ");
            b= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"If a={a} and b={b}");
            int c = a + b;
            Console.WriteLine($"a + b = {c}");
            c = a - b;
            Console.WriteLine($"a - b = {c}");
            c = a * b;
            Console.WriteLine($"c * b = {c}");
            c = a / b;
            Console.WriteLine($"a / b = {c}");

            
        }

        static void Main(string[] args)
        {




            workingWithIntegers();
        }
    }
}
