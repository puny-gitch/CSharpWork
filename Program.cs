using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static bool isPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        { 
            Console.WriteLine("请输入一个整数作为下限：");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入一个整数作为上限：");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n-m间的素数有：");
            int a = 0;
            for (int b = n; b <= m; b++)
            {
                if (isPrime(b))
                {
                    Console.Write(b + " ");
                    a++;
                    if (a==10)
                    {
                        Console.WriteLine("\n");
                        a = 0;
                    }
                }

            }
            

        }
    }
}
