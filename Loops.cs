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
        static void Task5_58()
        {
            ///Известны результаты двух спортсменов-пятиборцев в каждом из пяти видов
            ///спорта в баллах.Определить сумму баллов, полученных каждым спортсменом.
            int sport1 = 1;
            int sport2 = 1;
            int sum1 = 0;
            int sum2 = 0;

            while (sport1 < 6)
            {
                Console.WriteLine($"first sportsman, {sport1} result: ");
                int res1 = Convert.ToInt32(Console.ReadLine());
                sum1 = sum1 + res1;
                while (sport2 < 6)
                {
                    Console.WriteLine($"second sportsman, {sport2} result: ");
                    int res2 = Convert.ToInt32(Console.ReadLine());
                    sum2 = sum2 + res2;
                    sport2++;
                    break;
                }
                sport1++;
            }
            Console.WriteLine($"{sum1} - points scored by 1st sportsman" +
                $"\n{sum2} - points scored by 2nd sportsman");
                
        } 
        static void Task5_82()
        {
            ///Составить программу для расчета факториала натурального числа n
            int res = 1;
            Console.WriteLine("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int start = 2; start<=n; start++)
            {
                res *= 1* start;
            }
            Console.WriteLine($"n! = {res}");
        }
        static void Task6_10()
        {
            ///Дано число n
            /// а) Напечатать те натуральные числа, квадрат которых не превышает n
            /// б) Найти первое натуральное число, квадрат которого больше n
            int num;
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("a) ");
            for (num = 1;  Math.Pow(num, 2)<n; num++)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine($"\nb) {num}");
        }
        static void Task6_34()
        {
            ///Найти 15 первых натуральных чисел, делящихся нацело на 19 и находящихся
            ///в интервале, левая граница которого равна 100
            int i = 101;
            int count = 0;
            while (i > 100)
            {
                if (count <= 15)
                {
                    if (i % 19 == 0)
                    {
                        count++;
                        Console.Write(i + " ");

                    }
                }
                else
                {
                    break;
                }
                i++;
            }

        }
        static void Task6_58()
        {
            ///Дана последовательность вещественных чисел a1, a2, ..., a15
            ///Определить, есть ли в последовательности отрицательные числа. 
            ///В случае положительного ответа определить порядковый номер первого из них.
            int i;
            for (i = 1; i<=15; i++)
            {
                Console.Write($"Enter a{i}: ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a < 0)
                {
                    Console.WriteLine($"a{i} is a first negative");
                    break;
                }
            }

        }
        static void Task6_82NotSolved()
        {
            ///Дано натуральное число. Определить, является ли разность его максимальной
            ///и минимальной цифр четным числом.
            Console.WriteLine("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int remainder;
            int divisor;
            do
            {
                remainder = Math.DivRem(Convert.ToInt32(Console.ReadLine()), 10, out divisor);
                if ((remainder < 10) & (divisor < 10))
                {
                    if (remainder > divisor)
                    {
                        string answer = ((remainder - divisor) % 2 == 0) ? "Yes" : "Nope";
                        Console.WriteLine(answer);
                    }
                    else
                    {
                        string answer = ((divisor - remainder) % 2 == 0) ? "Yes" : "Nope";
                        Console.WriteLine(answer);
                    }
                }
            }
            while (divisor > 9);
        }
        static void Task6_106()
        {
            ///Даны целые числа a и b (a > b). Определить:
            ///а) результат целочисленного деления a на b, не используя стандартную операцию целочисленного деления;
            ///б) остаток от деления a на b, не используя стандартную операцию вычисления остатка.

            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b less than a: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int res1 = 0;
            while ((i * b) < a)
            {
                res1 = i;
                i++;
            }
            Console.WriteLine($"a) a // b = {res1}");
            Console.WriteLine($"a) a % b = {a - (res1*b)}");

        }
        static void Task7_10()
        {
            ///Найти все двузначные числа, которые делятся на n или содержат цифру n
            
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 10;
            int remainder;
            while (i <100)
            {
                remainder = Math.DivRem(i, 10, out int divisor);
                if ((i % n == 0) | (remainder == n) | (divisor == n))
                {
                    Console.Write($"{i} ");
                }
                i++;
            }
        }
        static void Task7_34()
        {
            ///Даны натуральное число m и целые числа x1, x2, ..., xm
            ///Определить количество чисел xi кратных трем, и количество чисел xj, кратных семи.
            int countdiv3 = 0;
            int countdiv7 = 0;
            Console.Write("Enter m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[m];
            for (int index = 0; index < m; index++)
            {
                Console.Write($"Enter x{index+1}: ");
                arr[index] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int x in arr)
            {
                if (x%3 == 0)
                {
                    countdiv3++;
                }
                else if (x%7 == 0)
                {
                    countdiv7++;
                }
            }
            Console.Write($"{countdiv3} number(s) divisible by 3 \n{countdiv7} number(s) divisible by 7");
        }
        static void Task7_58()
        {
            ///Даны площади нескольких кругов. Найти радиус самого маленького из них
            int min;
            Console.Write("Enter amount of  circles: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[m];
            for (int index = 0; index < m; index++)
            {
                Console.Write($"Enter S{index+1}: ");
                arr[index] = Convert.ToInt32(Console.ReadLine());
            }
            min = arr[0];
            foreach (int S in arr)
            {
                if (S < min)
                {
                    min = S;
                }
            }
            double minr = Math.Sqrt(min / 2*(Math.PI));
            Console.WriteLine($"{minr} is the lowest radius");
        }
        static void Task7_82()
        {
            ///Известна сумма очков, набранных каждой из 20 команд-участниц чемпионата
            ///по футболу. Определить сумму очков, набранных командами, занявшими в
            ///чемпионате три первых места
            int maxIndex = 0;
            int j;
            int i = 0;
            int[] topArr = new int[3];
            int[] arr = new int[20];
            for (int index = 0; index < 20; index++)
            {
                Console.Write($"Enter {index+1}team score: ");
                arr[index] = Convert.ToInt32(Console.ReadLine());   
            }
            int max = arr[0];
            while (i < 3)
            {
                for (j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > max)
                    {
                        max = arr[j];
                        maxIndex = j;
                    }
                }
                topArr[i] = max;
                arr[maxIndex] = 0;
                i++;
            }
            Console.WriteLine($"{topArr[0]+topArr[1]+topArr[2]} points, scored by top teams");

        }
        static void Task7_106()
        {
            ///Даны натуральное число m и целые числа d1, d2, ..., dm
            ///Выяснить, верно ли, что количество положительных чисел di kратно трем.
            int posCount = 0;
            Console.Write("Enter m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[m];
            for (int index = 0; index < m; index++)
            {
                Console.Write($"Enter d{index + 1}: ");
                arr[index] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int element in arr)
            {
                if (element > 0)
                {
                    posCount++;
                }
            }
            string answer = (posCount % 3 == 0) ? "di is divisible by 3" : "d1 in non-divisible by 3";
            Console.WriteLine(answer);

        }
        static void Task8_34()
        {
            ///Найти все целые числа из промежутка от 100 до 300, у которых сумма делителей равна 50
            int sum = 0;
            for (int i = 100; i<300; i++)
            {
                for (int j = 1; j<i; j++)
                {
                    if ((i % j == 0) & (sum<51))
                    {
                        sum += j;
                    }
                }
                if (sum == 50)
                {
                    Console.Write(i);
                }
                sum = 0;
            }
        }
        


    }
}
