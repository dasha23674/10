using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    using System;

    class Program
    {
        // Метод для задачи 1: Вычисление одной части выражения
        static double ComputeExpressionPart1(double n)
        {
            return (Math.Sqrt(n) + n) / 2;
        }

        // Метод для задачи 2: Вычисление одной части выражения
        static double ComputeExpressionPart2(double numerator, double denominator)
        {
            return (Math.Sqrt(numerator) + numerator) / (Math.Sqrt(denominator) + denominator);
        }

        // Метод для задачи 3: Нахождение максимума из двух чисел
        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // Метод для задачи 4: Нахождение максимума из трех чисел
        static int Max(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        // Метод для задачи 5: Нахождение сложного максимума
        static int ComplexMax(int a, int b, int c, int d)
        {
            return Max(a, b) + Max(c, d);
        }

        static void Main()
        {
            // Задача 1
            double x1 = ComputeExpressionPart1(5) + ComputeExpressionPart1(12) + ComputeExpressionPart1(19);
            Console.WriteLine("Задача 1. Значение x: " + x1);

            // Задача 2
            double x2 = ComputeExpressionPart2(5, 7) + ComputeExpressionPart2(12, 8) + ComputeExpressionPart2(19, 2);
            Console.WriteLine("Задача 2. Значение x: " + x2);

            // Задача 3
            Console.WriteLine("\nЗадача 3. Введите два числа:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Максимум из двух чисел: " + Max(a, b));

            // Задача 4
            Console.WriteLine("\nЗадача 4. Введите три числа:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Максимум из трех чисел: " + Max(a, b, c));

            // Задача 5
            Console.WriteLine("\nЗадача 5. Введите четыре числа:");
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine("Сложный максимум: " + ComplexMax(d, e, f, g));
        }
    }
}



