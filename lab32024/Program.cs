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


namespace task2_lab3_2024
{
    internal class Program
    {
        static dynamic Main(string[] args)
        {
            double currentTerm;  // Поточний член ряду
            double x = (Math.PI / 16);
            double epsilon = Math.Pow(10, -7);
            double N = 1; //кількість етерацій
            double error = 0;  // Відносна похибка
            double S1 = 0;
            double n = 1;
            Console.WriteLine("Обчислення почалось");
            dynamic result = 1;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    result *= i; // Ітерація
                }
            }
            return result;
            while (error >= epsilon)    // Виконуємо код до тих пір коли значення буде менше заданої помилки
            {
                currentTerm = (Math.Pow(-1, (N - 1)) * Math.Pow(x, (2 * N - 1))) / result(2 * N + 1);
                // Додаємо поточний член до накопиченої суми
                S1 += currentTerm;
                // Обчислення відносної похибки
                error = Math.Abs(currentTerm / S1);
                N++;
            }
            N--;                        // Віднімаємо після останього перевіреного значення
            Console.WriteLine($"Обчислення завершено, кiлькiсть iтерацiй: {N}");  // Виводимо в консоль кількість ітерацій і повідомлення про завершення розрахунку
            Console.WriteLine($"Поточний член ряду (a_{N}): {currentTerm}");
            Console.WriteLine($"Накопичена сума ряду (S1): {S1}");
            Console.WriteLine($"Досягнута похибка: {error}");
            Console.ReadKey();
        }
    }
}


/*
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
            Console.WriteLine("Значення функцiй y = 1/x та z = (x/3)^2 на вiдрiзку [0.5; 4] з кроком h = 0.1:");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("    x         y = 1/x         z = (x/3)^2");
            Console.WriteLine("---------------------------------------------------");
            // Цикл для обчислення значень функцій на кожному кроці
            for (double x = a; x <= b; x += h)
            {
                // Обчислюємо значення функцій
                double y = 1 / x;
                double z = Math.Pow(x / 3, 2);
                // Виводимо результати в консоль
                Console.WriteLine($"{x:F1}      {y:F4}          {z:F4}");
            }
            Console.WriteLine("---------------------------------------------------");
            Console.ReadKey();
        }
    }
}
*/