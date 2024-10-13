using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Обчислення завершено.{0}", N);  // Виводимо в консоль кількість ітерацій і повідомлення про завершення розрахунку
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
