using System;
using System.Collections.Generic;
using System.Text;

namespace If_Switch
{
    public partial class If_Switch
    {
        static void ChoiceSort()
        {
            int[] mass = { 2, 7, 34, 1, 0, 7, 8, 1, -8, 12};
            int j = 0;
            int i = 0;
            int minIndex = 0;
            while (i< mass.Length)
            {
                j = i;
                int min = mass[i];

                while (j < (mass.Length-1)) ///loop for min search
                {
                    if (mass[j] <= min)
                    {
                        min = mass[j];
                        minIndex = j;
                       Console.WriteLine($"minimum value: {min}");
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
