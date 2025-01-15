using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleApp45
{
   
        public static class StringExtensions
        {
            public static int word(this string str)
            {
                return str.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
            }
        }

    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слова:");
            string choice=Console.ReadLine();
            int Word = choice.word();
            Console.WriteLine("Количество слов:"+Word);
        }
    }
}
