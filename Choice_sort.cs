using System;
using System.Collections.Generic;
using System.Text;

namespace If_Switch
{
    public partial class If_Switch
    {
        static void ChoiceSort()
        {
            Console.Write("Enter amount of  elements: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[m];
            for (int index = 0; index < m; index++)
            {
                Console.Write($"Enter element #{index + 1}: ");
                mass[index] = Convert.ToInt32(Console.ReadLine());
            }
            int j = 0;
            int i = 0;
            int minIndex = 0;
            while (i< mass.Length)
            {
                j = i;
                int min = mass[i];

                while (j < (mass.Length)) ///loop for min search
                {
                    if (mass[j] <= min)
                    {
                        min = mass[j];
                        minIndex = j;
                    }
                    j++;
                }

                int temp = mass[i];
                mass[i] = mass[minIndex];
                mass[minIndex] = temp;
                i++;

            }
            foreach (int element in mass)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
