using System;

namespace MaxThreeResult
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new[] {10, 5, 20, 6};

            int max1 = Int32.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max1)
                {
                    max1 = arr[i];
                }
            }
            
            int max2 = Int32.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max2 && arr[i] < max1)
                {
                    max2 = arr[i];
                }
            }
            
            int max3 = Int32.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max3 && arr[i] < max2)
                {
                    max3 = arr[i];
                }
            }
            Console.WriteLine(max1);
            Console.WriteLine(max2);
            Console.WriteLine(max3);
            
            Console.WriteLine(max3 * max2 * max1);
        }
    }
}