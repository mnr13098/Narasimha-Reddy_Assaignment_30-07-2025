using System;
namespace Console1{
    class RemoveDupes{
        static void Main(string[] args)
        {
            int[] sample = { 5, 1, 2, 3, 4, 5, 5, 6, 7, 8, 5, 9 };
            Array.Sort(sample);
            //{1,2,3,4,5,5,5,5,6,7,8,9}
            int n = sample.Length;
            int[] temp = new int[n];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || sample[i] != sample[i - 1])
                {
                    temp[count] = sample[i];
                    count++;
                }
            }
        Console.WriteLine("Array without duplicates:");
        for (int i = 0; i < count; i++)
        {
            Console.Write(temp[i] + " ");
        }
        }
    }
}
