using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab32024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            /*
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
                else
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
            */
            //the end of task 1
            //task 2
            // Задана відносна похибка
            Console.Write("Введіть максимальну допустиму похибку: ");
            double epsilon = Convert.ToDouble(Console.ReadLine());

            double S1 = 0;  // Накопичена сума
            int iteration = 1;  // Номер ітерації
            double currentTerm;  // Поточний член ряду
            double error;  // Відносна похибка

            do
            {
                // Обчислення поточного члена ряду a_k (залежить від конкретного ряду)
                currentTerm = 1.0 / iteration;  // Наприклад, для ряду Гармонічного: 1/k

                // Додаємо поточний член до накопиченої суми
                S1 += currentTerm;

                // Обчислення відносної похибки
                error = Math.Abs(currentTerm / S1);

                // Виведення результатів для поточної ітерації
                Console.WriteLine($"Ітерація: {iteration}");
                Console.WriteLine($"Поточний член ряду (a_{iteration}): {currentTerm}");
                Console.WriteLine($"Накопичена сума ряду (S1): {S1}");
                Console.WriteLine($"Досягнута похибка: {error}");
                Console.WriteLine();

                iteration++;  // Перехід до наступної ітерації
            } while (error > epsilon);  // Умова продовження: похибка більше заданої

            Console.WriteLine("Обчислення завершено.");

            //the end of task 2
            Console.ReadKey();
        }
    }
}
