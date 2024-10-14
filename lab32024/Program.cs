using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;


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
                Console.Write("Введіть натуральне число n: ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введіть натуральне число m (m повинно бути більше n): ");
                m = Convert.ToInt32(Console.ReadLine());

                if (n <= 0 || m <= 0)
                {
                    Console.WriteLine("Числа повинні бути натуральними (більшими за 0). Спробуйте ще раз.");
                }
                else if (n >= m)
                {
                    Console.WriteLine("Число m повинно бути більше за n. Спробуйте ще раз.");
                }
            } while (n <= 0 || m <= 0 || n >= m);

            // Обчислення суми чисел від n до m
            int sum = 0;
            for (int i = n; i <= m; i++)
            {
                sum += i;
            }

            // Виведення результату
            Console.WriteLine($"Сума чисел від {n} до {m} дорівнює: {sum}");
            Console.ReadKey();
            //the end of task 1
        }
    }
}


/*
namespace task2_lab3_2024
{
    internal class Program
    {
        public static double currentTerm;  // Поточний член ряду
        public static double x = (Math.PI / 16);
        public static double epsilon = Math.Pow(10, -7);
        public static double N = 1; //кількість етерацій
        public static double error = 0;  // Відносна похибка
        public static double S1 = 0;
        static void Main(string[] args)
        {
            FindNewError();             // Знаходимо нове значення
            Console.WriteLine("Обчислення почалось");
            while (error >= epsilon)    // Виконуємо код до тих пір коли значення буде менше заданої помилки
            {
                FindNewError();         // Знаходимо нове значення
            }
            N--;                        // Віднімаємо після останього перевіреного значення
            Console.WriteLine($"Обчислення завершено, кількість ітерацій: {N}");  // Виводимо в консоль кількість ітерацій і повідомлення про завершення розрахунку
            Console.WriteLine($"Поточний член ряду (a_{N}): {currentTerm}");
            Console.WriteLine($"Накопичена сума ряду (S1): {S1}");
            Console.WriteLine($"Досягнута похибка: {error}");
            Console.ReadKey();
        }
        static void FindNewError() // Знаходимо нове значення 
        {
            currentTerm = (Math.Pow(-1, (N - 1)) * Math.Pow(x, (2 * N - 1))) / Factorial(2 * N + 1);
            // Додаємо поточний член до накопиченої суми
            S1 += currentTerm;

            // Обчислення відносної похибки
            error = Math.Abs(currentTerm / S1);
            N++;
        }
        static long Factorial(double n)
        {
            long result = 1;
            if(n > 0)
            {
                for (int i = 1; i <= n; i++) 
                {
                    result *= i; // Ітерація
                }
            }
            return result;
        }// Знаходження факторіала числа
    }
}
*/

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
            Console.WriteLine("Значення функцій y = 1/x та z = (x/3)^2 на відрізку [0.5; 4] з кроком h = 0.1:");
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