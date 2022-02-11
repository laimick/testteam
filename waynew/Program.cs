using System;

namespace waynew
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Ввести А");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввести В");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите операцию (+,-,*,/)");
            switch (Console.ReadLine())
            {
                case "*":
                    {
                        Console.WriteLine("- выполнить операцию “*”");
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;
                    }
                case "+":
                    {
                        Console.WriteLine("- выполнить операцию “+”");
                        Console.WriteLine($"{a} / {b} = {a + b}");
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine("- выполнить операцию “-”");
                        Console.WriteLine($"{a} - {b} = " + (a - b));
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine("- выполнить операцию “/”");
                        Console.WriteLine($"{a} / {b} = {a / b}");
                        break;
                    }
            }
        }
    }
}
