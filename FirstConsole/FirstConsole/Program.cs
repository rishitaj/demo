using System;

namespace FirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1; 
            int val2;
            int add, sub, mul, div;
            Console.WriteLine("Enter value1: ");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value2: ");
            val2 = Convert.ToInt32(Console.ReadLine());
            add = val1 + val2;
            Console.WriteLine("Addition: " + add);
            sub = val1 - val2;
            Console.WriteLine("Subtraction: " + sub);
            mul = val1 * val2;
            Console.WriteLine("Multiplication: " + mul);
            div = val1 / val2;
            Console.WriteLine("Division: " + div);
            Console.Read();

        }
    }
}
