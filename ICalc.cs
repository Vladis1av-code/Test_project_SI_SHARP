using System;

namespace ConsoleApp41
{
    //Интерфейс
    public interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
    //Класс интерфейса
    public class Arr_1 : ICalc
    {
        private int[] array;

        public Arr_1(int[] array)
        {
            this.array = array;
        }

        //___________________________________________________________________

        //Less и Geater- логика подсчета елементов и переберание массива
        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        //________________________________________________
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 19, 2, 21, 22, 23, 24, 5,27 };

           Arr_1 arr_1 = new Arr_1(arr);

            int lessThanFive = arr_1.Less(4);
            int greaterThanFive = arr_1.Greater(4);

            Console.WriteLine("Количество менших чисел за 5:"+lessThanFive);
            Console.WriteLine("Количество больших чисел за 5:"+greaterThanFive);
        }
    }
}
