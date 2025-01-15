using System;
using System.IO;
using System.Collections.Generic;


namespace _3
{

    public static class StringExtensions
    {
        public static int LastWordLength(this string str)
        {
            // Удаляем пробелы
            str = str.TrimEnd();

            // Делим слова на пробелы
            string[] words = str.Split(' ');

            // Если строка не пустая возращаем ширину слова
            return words.Length > 0 ? words[words.Length - 1].Length : 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string choice=Console.ReadLine();
            int text_user=choice.LastWordLength();
            Console.WriteLine("Ширина слова:"+text_user);
        }
    }
}
