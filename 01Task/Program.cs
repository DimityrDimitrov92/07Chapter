using System;

namespace _01Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 2;
            int[] myArray = { 2, 5, 7, 9, 15,
                21, 23, 24, 25, 34, 35, 37, 48, 
                51, 53, 57, 67, 71, 75, 78 };
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] =5* myArray[i];
            //    Console.WriteLine(myArray[i]);
            //}
            foreach (var item in myArray)
            {
                int a = item * 5;
                Console.WriteLine(a);
            }


            //int[] array =  { 1, 2, 3, 4, 5 };
            //Console.Write("Output: ");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    // Doubling the number
            //    array[i] = 2 * array[i];
            //    // Print the number
            //    Console.Write(array[i] + " ");
            //}
        }
    }
}
