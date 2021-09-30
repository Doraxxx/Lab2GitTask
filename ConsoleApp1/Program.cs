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
                char typeOper;

                Console.WriteLine("Выберите тип операции: с - стандартные (+, -, *, /), д - дополнительные (sin, cos)");
                typeOper = Convert.ToChar(Console.ReadLine());

                switch (typeOper)
                {
                    case 'с':

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
                            Console.WriteLine(a + " * " + b + " = " + total);
                        }

                        else if (oper == '/')
                        {
                            if (b == 0)
                            {
                                Console.WriteLine("Деление на ноль невозможно");
                            }
                            else
                            {
                                total = a / b;
                                Console.WriteLine(a + " / " + b + " = " + total);
                            }

                        }
                        else
                        {
                            Console.WriteLine("Неизвестный оператор.");
                        }

                        break;

                    case 'д':

                        double ug;
                        double znach;
                        char mathOp;

                        Console.WriteLine("Введите угол:");
                        ug = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Введите математическую функцию (s для вычисления sin, c для вычисления cos):");
                        mathOp = Convert.ToChar(Console.ReadLine());

                        if (mathOp == 's')
                        {
                            Console.WriteLine("sin " + ug + " = " + Math.Sin(ug));
                        }

                        else if (mathOp == 'c')
                        {
                            Console.WriteLine("cos " + ug + " = " + Math.Cos(ug));
                        }

                        break;
                }

                
                Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)");
                again = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
