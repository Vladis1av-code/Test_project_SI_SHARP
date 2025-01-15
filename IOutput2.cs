using System;

namespace ConsoleApp42
{
   
    public interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }

    
    public class Array : IOutput2
    {
        private int[] array;

        public Array(int[] arr)
        {
            this.array = arr; 
        }

        public void ShowEven()
        {
            Console.WriteLine("Парные числа:");
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + ", "); 
                }
            }
            Console.WriteLine(); 
        }

       
        public void ShowOdd()
        {
            Console.WriteLine("Непарные числа:");
            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + ", "); 
                }
            }
            Console.WriteLine(); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 4, 1, 5 };
            Array myArray = new Array(arr);

            myArray.ShowEven();
            myArray.ShowOdd();
        }
    }
}
