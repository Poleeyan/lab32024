using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

/*
namespace task1_lab3_2024
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {

            //task 1
            int n, m;

            // Введення та перевірка значень n і m
            do
            {
                Console.Write("Введiть натуральне число n: ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введiть натуральне число m (m повинно бути бiльше n): ");
                m = Convert.ToInt32(Console.ReadLine());

                if (n <= 0 || m <= 0)
                {
                    Console.WriteLine("Числа повиннi бути натуральними (бiльшими за 0). Спробуйте ще раз.");
                }
                else if (n >= m)
                {
                    Console.WriteLine("Число m повинно бути бiльше за n. Спробуйте ще раз.");
                }
            } while (n <= 0 || m <= 0 || n >= m);

            // Обчислення суми чисел від n до m
            int sum = 0;
            for (int i = n; i <= m; i++)
            {
                sum += i;
            }

            // Виведення результату
            Console.WriteLine($"Сума чисел вiд {n} до {m} дорiвнює: {sum}");
            Console.ReadKey();
            //the end of task 1
        }
    }
}
*/

/*
namespace task2_lab3_2024
{
    internal class Program
    {
        static void Main()
        {
            double currentTerm = 0;  // Поточний член ряду
            double x = (Math.PI / 16);
            double epsilon = Math.Pow(10, -7);
            double N = 1; //кількість ітерацій
            double error = 1;  // Відносна похибка
            double S1 = 0;
            while (error >= epsilon) // Виконуємо код до тих пір, поки значення буде більше заданої помилки
            {
                double factorial = 1;
                for (int i = 1; i <= 2 * N + 1; i++) // Вычисляем факториал (2N + 1) прямо в цикле
                {
                    factorial *= i;
                }
                currentTerm = (Math.Pow(-1, N - 1) * Math.Pow(x, 2 * N - 1)) / factorial; // Обчислюємо поточний член ряду
                S1 += currentTerm; // Додаємо поточний член до накопиченої суми
                error = Math.Abs(currentTerm / S1); // Обчислення відносної похибки
                N++; // Збільшуємо кількість ітерацій
            }
            N--; // Віднімаємо після останього перевіреного значення
            Console.WriteLine($"Кiлькiсть iтерацiй: {N}");
            Console.WriteLine($"Поточний член ряду (a_{N}): {currentTerm}");
            Console.WriteLine($"Накопичена сума ряду (S1): {S1}");
            Console.WriteLine($"Досягнута похибка: {error}");
            Console.ReadKey();
        }
    }
}
*/


namespace task3_lab3_2024
{
    internal partial class Program
    {
        static void Main()
        {
            // Задаємо початкові значення інтервалу, крок та кінцеве значення
            double a = 0.5;
            double b = 4.0;
            double h = 0.1;
            double x = a;
            Console.WriteLine("Значення функцiй y = 1/x та z = (x/3)^2 на вiдрiзку [0.5; 4] з кроком h = 0.1:");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("    x         y = 1/x         z = (x/3)^2");
            Console.WriteLine("---------------------------------------------------");
            // Цикл для обчислення значень функцій на кожному кроці
            while (x <= b)
            {
                // Обчислюємо значення функцій
                double y = 1 / x;
                double z = Math.Pow(x / 3, 2);
                x += h;
                Console.WriteLine($"{x:F1}      {y:F4}          {z:F4}"); // Виводимо результати в консоль
            }
            Console.WriteLine("---------------------------------------------------");
            Console.ReadKey();
        }
    }
}
