using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodichka
{
    class Program
    {
        static void moving(ref int ch1, ref int ch2)
        {
            //1.2
            int number;
            number = ch1;
            ch1 = ch2;
            ch2 = number;
            Console.WriteLine($"\n{ch1} \n {ch2}");
        }
        //1.3
            static bool factorial(int number, out int resulting)
            {
                resulting = 1;
                try
                {
                    for (int i = 2; i <= number; i++)
                    {
                        checked
                        {
                            resulting *= i;
                        }
                    }
                }
                catch(OverflowException)
                {
                    resulting = 0;
                    return false;
                }
                return true;
            }
        //1.4
        static bool rekfactorial(ref int factorial,int k,int n)
        {
            try
            {
                checked
                {
                   if (k<=n)
                    {
                        factorial *= k++;
                         if (!rekfactorial(ref factorial,k,n))
                        {
                            throw new OverflowException();
                        }
                    }
                    return true;
                }
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("5.2\nвведите первое число: \n введите второе число:");
            int ch1 = Convert.ToInt32(Console.ReadLine());
            int ch2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("наибольшее число: " + getmax(ch1, ch2));
        }
        public static int getmax(int ch1, int ch2)
        {
            if (ch1 > ch2)
            {
                return ch1;
            }
            else
            {
                return ch2;
            }
            if (ch1 == ch2) ;
            {
                Console.WriteLine("введите другие числа");
            }
            Console.WriteLine("5.2");
            moving(ref ch1, ref ch2);

            Console.WriteLine("5.3");
            int n = Convert.ToInt32(Console.ReadLine());
            int nfactor;
            if(factorial(nfactor,out nfactor))
            {
                Console.WriteLine("факториал:" + nfactor);
            }
            else
            {
                Console.WriteLine("переполнение");
            }

            Console.WriteLine("5.4");
            Console.WriteLine($"рекурсивный метод:{rekfactorial(n)}");
            Console.ReadLine();
        }
        private static object rekfactorial(int n)
        {
            throw new NotImplementedException();
        }
    }
    }


    

