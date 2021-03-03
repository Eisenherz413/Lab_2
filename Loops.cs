using System;
using System.Collections.Generic;
using System.Text;

namespace If_Switch
{
    public partial class If_Switch
    {
        static void Task5_10()
        {
            Console.WriteLine("Enter USD rate: ");
            int rate = Convert.ToInt32(Console.ReadLine());

            for (int num = 1; num < 21; num++)
            {
                int hrn = num * rate;
                Console.WriteLine($"{num}USD - {hrn}UAH");
            }

        }
        static void Task5_34()
        {
            double sum = 0;
            int zn = 1;
            for (int i = 0; i <= 8; i++)
            {
                sum += 1 / zn;
                zn *= 3;
            }
            Console.WriteLine(sum);
        }
    }
}
