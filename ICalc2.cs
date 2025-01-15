using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ConsoleApp43
{
    //Интерфейс 
    public interface ICalc2
{
    int CountDistinct();
    int EqualToValue(int valueToCompare);
}

public class Array : ICalc2
{
    private int[] array;
        private int[] numbers;

        public Array(int[] numbers)
        {
            this.numbers = numbers;
        }


        //Переберают массив
        public int CountDistinct()
    {
        // Ищет уникальные елементы
        HashSet<int> uniqueNumbers = new HashSet<int>(array);
        return uniqueNumbers.Count;
    }

    public int EqualToValue(int valueToCompare)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num == valueToCompare)
            {
                count++;
            }
        }
        return count;
    }
}



    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 1, 4, 1, 5 };
             Array myArray = new Array(numbers);

            int distinctCount = myArray.CountDistinct();
            int countOfFives = myArray.EqualToValue(5);

            Console.WriteLine("Уникальные числа:"+ distinctCount);
            Console.WriteLine("Количество чисел равны 5:" + countOfFives);
        }
    }
}
