using System;
using System.Collections.Generic;
using System.Text;

namespace If_Switch
{
    public partial class If_Switch
    {
        static void SelectionSort()
        {
            var rand = new Random();
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int index = 0; index < n; index++)
            {
                arr[index] = rand.Next(0, 30);
                Console.Write($"{arr[index]} ");
            }
            int i = 1;
            int j = i;
            while (i < n)
            {
                    j = i;
                    while (j > 0)
                    {
                     
                        if (arr[j] <= arr[j-1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j-1];
                            arr[j-1] = temp;
                        }
                        j--;
                    }
              
                i ++;
            }
            Console.Write($"\nres: ");
            for (int index = 0; index < n; index++)
            {
                Console.Write($"{arr[index]} ");
            }
        }
    }
}
