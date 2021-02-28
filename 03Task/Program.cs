using System;

namespace _03Task
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isIqual = true;
            char[] a = { 'a', 'q' };
            char[] b = { 'a', 'b', 'c' };
            if (a.Length < b.Length)
            {
                Console.WriteLine($"First array (A) is more ahead ");
                
            }
            else if (a.Length > b.Length)
            {
                Console.WriteLine($"Second array (B) is more ahead");
                
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] < b[i])
                    {
                        Console.WriteLine($"First array (A)is more ahead");
                        isIqual = false;
                        break;
                    }
                    else if (a[i] > b[i])
                    {
                        Console.WriteLine($"Second array (B)is more ahead");
                        isIqual = false;
                        break;
                    }
                }
                if (isIqual)
                {
                    Console.WriteLine($"They are equal");
                }
            }
            



        }
    }
}
