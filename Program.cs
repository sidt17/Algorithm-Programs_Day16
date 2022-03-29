using System;
namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortarray = new int[5] { 23, 67, 9, 22, 30 };
            int n = 5, value, flag, i, j;
            Console.WriteLine("Before Sorting");

            for (i = 0; i < n; i++)
            {
                Console.Write(sortarray[i] + " ");

            }
            Console.WriteLine();

            for (i = 0; i < n; i++)
            {
                value = sortarray[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (value < sortarray[j])
                    {
                        sortarray[j + 1] = sortarray[j];
                        j--;
                        sortarray[j + 1] = value;
                    }
                    else
                        flag = 1;

                }
            }
            Console.WriteLine("After sorting");
            for (i = 0; i < n; i++)
            {
                Console.Write(sortarray[i] + " ");
            }
        }
    }
}