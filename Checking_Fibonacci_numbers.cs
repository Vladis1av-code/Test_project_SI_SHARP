using System;
using System.IO;
using System.Collections.Generic;

namespace _15._07._2024
{
    public static class Program
    {
        //______________________________________________________
        //Проверка число есть негативным или нет если да то не есть Финабочи
        public static bool fibonacci(this int num)
        {
            if (num < 0)
            {
                return false;
            }
            if (num == 0 || num == 1)
            {
                return true;
            }
            int a = 0, b = 1;
            while (b <= num)
            {
                if (b == num)
                {
                    return true; 
                }

                int t = b;
                b = a + b;
                a = t;
            }

            return false;
        }
    }
    //______________________________________________________
    public class M
    {
        static void Main(string[] args)
        {
            Func<int, bool> Fibonacci = (num) => num.fibonacci();
            List<int> numbers = new() { 1, 3, 5, 8, 6,45,23 };
            foreach (var num in numbers)
            {
                Console.WriteLine($"{num} is Fibonacci: {Fibonacci(num)}");
            }
        }
    }
}

