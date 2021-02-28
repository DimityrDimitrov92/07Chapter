using System;

namespace _02Task
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isIqual = true;
            Console.Write($"Enter length of first array : ");
            int length = int.Parse(Console.ReadLine());
            int[] firstArray = new int[length];

                for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write($"Enter ({i+1}) array : ");
                firstArray[i] =int.Parse( Console.ReadLine());
                    
            }
            Console.Write($"Enter length of second array : ");
            if (length != int.Parse(Console.ReadLine()))
            {
                Console.WriteLine($"The arrays are not equal");
            }
            else
            {
                int[] secondArray = new int[length];
                for (int i = 0; i < secondArray.Length; i++)
                {
                    Console.Write($"Enter ({i+1}) array : ");
                    secondArray[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i <firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine($"\nThey are different");
                        isIqual = false;
                        break;

                    }
                }

            }
            if (isIqual)
            {
                Console.WriteLine($"They are equal");
            }
 
            
        }
    }
}
