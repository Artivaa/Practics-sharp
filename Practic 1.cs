using System;

namespace Practic__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 1: Вычисления выражений
            Console.WriteLine("Задача 1:");
            
            Console.Write("Введите m: ");
            if (!int.TryParse(Console.ReadLine(), out int m))
            {
                Console.WriteLine("Ошибка: Неверный ввод данных для m");
                return;
            }
            Console.Write("Введите n: ");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка: Неверный ввод данных для n");
                return;
            }
            Console.Write("Введите x для выражения 4 в пределах [-1; 1]: ");
            if (!double.TryParse(Console.ReadLine(), out double x))
            {
                Console.WriteLine("Ошибка: Неверный ввод данных для x");
                return;
            }
            else if(x < -1 || x > 1)
            {
                Console.WriteLine("Ошибка: Значение х вне границы допустимых значений");
                return;
            }

            Console.WriteLine($"Выражение 1: m={m}, n={n} Значение m - --n = {m - --n}");  
            Console.WriteLine($"Выражение 2: m={m}, n={n} Значение m++ < n = {m++ < n}");
            Console.WriteLine($"Выражение 3: m={m}, n={n} Значение n++ > m = {n++ > m}");
            Console.WriteLine($"Выражение 4: x={x}, Значение cos⁡(arcsin⁡(x)) = {Math.Cos(Math.Asin(x))}");

            // Задача 2: Проверка принадлежности точки
            Console.WriteLine("\nЗадача 2:");
            
            Console.Write("Введите X1: ");
            if (!double.TryParse(Console.ReadLine(), out double X1))
            {
                Console.WriteLine("Ошибка: Неверный ввод данных для X1");
                return;
            }
            Console.Write("Введите Y1: ");
            if (!double.TryParse(Console.ReadLine(), out double Y1))
            {
                Console.WriteLine("Ошибка: Неверный ввод данных для Y1");
                return;
            }

            Console.WriteLine($"Координата принадлежит: {Math.Abs(X1) + Math.Abs(Y1) <= 2}");

            // Задача 3: Вычисление выражения с float и double
            Console.WriteLine("\nЗадача 3:");
            
            double a = 1000;
            double b = 0.0001;
            
            double temp1 = Math.Pow(a + b, 3);
            double temp2 = Math.Pow(a, 3) + 3 * Math.Pow(a, 2) * b;
            
            Console.WriteLine($"Значение выражения (Double): {(temp1 - temp2) / (3 * a * Math.Pow(b, 2) + Math.Pow(b, 2))}");

            float aFloat = 1000f;
            float bFloat = 0.0001f;
            
            float temp1Float = (float)Math.Pow(aFloat + bFloat, 3);
            float temp2Float = (float)(Math.Pow(aFloat, 3) + 3 * Math.Pow(aFloat, 2) * bFloat);
            
            Console.WriteLine($"Float: {(temp1Float - temp2Float) / ((float)(3 * aFloat * Math.Pow(bFloat, 2) + Math.Pow(bFloat, 2)))}");
        }
        
    }
}
