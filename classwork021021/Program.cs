using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        static int NOD(int k1, int k2)
        {
            while (k1 != k2)
            {
                if (k1 > k2)
                {
                    k1 -= k2;
                }
                else
                {
                    k2 -= k1;
                }
            }
            return k2;
        }
        static int NOD(int k1, int k2, int k)
        {
            while (k != k2)
            {
                if (k > k2)
                {
                    k -= k2;
                }
                else
                {
                    k2 -= k;
                }

                while (k1 != k2)
                {
                    if (k1 > k2)
                    {
                        k1 -= k2;
                    }
                    else
                    {
                        k2 -= k1;
                    }
                }
            }
            return k;
        }
        
     
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 5.1\nВведите 2 числа, у которых нужно вычислить НОД");
            int k1 = Convert.ToInt32(Console.ReadLine());
            int k2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"НОД = {NOD(k1, k2)}" + $"\nВведите 3 числа, у которых нужно вычислить НОД");
            k1 = Convert.ToInt32(Console.ReadLine());
            k2 = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"НОД = {NOD(k1, k2, k)}" +
                $"\nЗадание 5.2 (Фибоначчи)\nВведите номер члена последовательности");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"n-й член последовательности = {Fibonacci(k)}");
        }

    }
    }

