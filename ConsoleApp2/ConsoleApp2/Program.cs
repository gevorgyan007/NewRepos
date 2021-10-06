using System;

namespace ConsoleApp2
{
    class Program
    {
        public static int[] Sort(params int[] array) {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = 0 ; j < array.Length-i-1; j++)
                {
                    if (array[j]>array[j+1])
                    {
                        int temp = array[j+1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
          int[] arr =  Sort(5, 8, 78, 45, 12, 3, 6);

            for (int a = 0; a < arr.Length; a++)
            {
                Console.WriteLine(arr[a]);
            }
        }
    }
}
