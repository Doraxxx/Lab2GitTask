using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char again = 'д';
            while (again == 'д')
            {
                double a;
                double b;
                double total;
                char oper;

                Console.WriteLine("Введите первое число:");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите оператор:");
                oper = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                b = Convert.ToDouble(Console.ReadLine());

                if (oper == '+')
                {
                    total = a + b;
                    Console.WriteLine(a + " + " + b + " = " + total);
                }

                else if (oper == '-')
                {
                    total = a - b;
                    Console.WriteLine(a + " - " + b + " = " + total);
                }

                else if (oper == '*')
                {
                    total = a * b;
                    Console.WriteLine(a + " - " + b + " = " + total);
                }

                else if (oper == '/')
                {
                    total = a / b;
                    Console.WriteLine(a + " / " + b + " = " + total);
                }
                else
                {
                    Console.WriteLine("Неизвестный оператор.");
                }
                Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)");
                again = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
