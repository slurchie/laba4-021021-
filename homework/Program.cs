using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork
{
    class Program
    {
        private static int Params(params int[] mas)
        {
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }
            return sum;
        }

        static ulong proizvedenie(ref int[] mas)
        {
            ulong proizv = 1;
            for (int i = 0; i < mas.Length; i++)
            {
                proizv *= (ulong)mas[i];
            }
            return proizv;
        }

        static void sraref(int[]mas,out double sraref)
        {
            int sum = Params(mas);
            sraref = (double)sum / mas.Length;
        }

        static void SolvetheEquation()
        {
            Console.WriteLine("введите коэффициенты abc: ");
            double koefa = Convert.ToDouble(Console.ReadLine());
            double koefb = Convert.ToDouble(Console.ReadLine());
            double koefc = Convert.ToDouble(Console.ReadLine());
            double diskriminant = koefb * koefb - 4 * koefa * koefc;
            if (diskriminant < 0)
            {
                Console.WriteLine("отрицательное значение дискриминанта.решений нет");
            }
            else if (diskriminant == 0)
            {
                double answer = (-koefb) / (2 * koefa);
                Console.WriteLine($"корень уравнения: {answer}");
            }
            else if (diskriminant > 0)
            {
                double answer1 = ((-koefb) + Math.Sqrt(diskriminant)) / (2 * koefa);
                double answer2 = ((-koefb) - Math.Sqrt(diskriminant)) / (2 * koefa);
                Console.WriteLine($"корни уравнения {0} {1}: {answer1}{answer2}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1 задание");
            SolvetheEquation();

            //1.2
            Console.WriteLine("1.2");
            int[] mas = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(-100,100);
            }
            foreach (int i in mas)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("введите два числа из иассива: ");
            int ch1 = Convert.ToInt32(Console.ReadLine());
            int ch2 = Convert.ToInt32(Console.ReadLine());
            if (ch1!=ch2)
            {
                int ind1 = Array.IndexOf(mas, ch1);
                int ind2 = Array.IndexOf(mas, ch2);
                int num = mas[ind1];
                mas[ind1] = mas[ind2];
                mas[ind2] = num; 
                for (int i =0;i<mas.Length;i++)
                {
                    Console.WriteLine(mas[i]);
                }
            }
            else
            {
                Console.WriteLine("вы ввели одинаковые числа");
            }

            //3
            Console.WriteLine(1.3);
            Console.Write("сколько чисел будем сортировать:");
            int kolvo = Int32.Parse(Console.ReadLine());
            Console.Write("Введите числа: ");
            int[] massive = new int[kolvo];
            for (int i = 0; i < massive.Length; i++) 
            {
                massive[i] =Int32.Parse(Console.ReadLine());
            }
            int bub;
            for (int i =0;i<massive.Length-1;i++)
            {
                for (int j = i+1;j<massive.Length; j++)
                {
                    if (massive[i] > massive[j])
                    {
                        bub = massive[i];
                        massive[i] = massive[j];
                        massive[j] = bub;
                    }    
                }
            }
            Console.WriteLine("вывод: ");
            for (int i =0;i<massive.Length;i++)
            {
                Console.WriteLine(massive[i]);
            }

            //1.4
            Console.WriteLine("1.4");
            int sum = Params(massive);
            Console.WriteLine($"сумма = {sum}");
            Console.WriteLine($"произведение= " + proizvedenie(ref massive));
            Console.ReadLine();
        }
    }
}




