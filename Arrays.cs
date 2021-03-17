using System;
using System.Collections.Generic;
using System.Text;

namespace If_Switch
{
    public partial class If_Switch
    {
        static void Task11_10()
        {
            //Дано натуральное число n (n <= 999999). Заполнить массив его цифрами,
            //расположенными в обратном порядке(первый элемент равен последней
            //цифре, второй — предпоследней и т.д.). Незаполненные элементы массива
            //должны быть равны нулю.Элементы массива, являющиеся цифрами
            //числа n, вывести на экран

            Console.Write("Enter n: ");
            string n = Console.ReadLine();
            string[] arr = new string [n.Length];
            int i = 0;
            int j = 0;

            while (i < n.Length)
            {
                arr[j] = Convert.ToString(n[n.Length-i-1]);
                j++;
                i++;
            }
            foreach (string element in arr)
            {
                Console.Write(element + " ");
            }
            //int n = Convert.ToInt32(Console.ReadLine());

        }
        static void Task11_34()
        {
            //      В массиве хранятся сведения о количестве осадков, выпавших за каждый
            //    день июня.Определить:
            //    в какой период выпало больше осадков: в первую половину июня или во вторую;
            var rand = new Random();
            int i = 0;
            int sum1 = 0;
            int sum2 = 0;
            int[] arr = new int[30];
            for (int index = 0; index < 30; index++)
            {
                arr[index] = rand.Next(0, 10);
            }
            while (i < arr.Length / 2)
            {
                sum1 += arr[i];
                i++;
            }
            i = 15;
            while (i < arr.Length)
            {
                sum2 += arr[i];
                i++;
            }
            string res1 = (sum1 > sum2) ? "1-15" : "15-30";
            Console.Write(res1);
        }
        static void Task11_58()
        {
            //Известны данные о количестве осадков, выпавших за каждый месяц года.
            //Найти общее число осадков, выпавших в марте(2), июне(5), сентябре(8) и декабре(11).
            var rand = new Random();
            int[] arr = new int[12];
            for (int index = 0; index < 12; index++)
            {
                arr[index] = rand.Next(0, 10);
                //Console.Write($"{arr[index]} ");
            }

            int i = 0;
            int sum = 0;
            while (i < 12)
            {
                if ((i == 2) | (i == 5) | (i == 8) | (i == 11))
                {
                    sum += arr[i];
                }
                i++;
            }
            Console.WriteLine($"total precipitation: {sum}");
        }
        static void Task11_82()
        {
            //Найти среднее арифметическое элементов массива, больших числа 10.
            var rand = new Random();
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            double count = 0;
            double sum = 0;

            for (int index = 0; index<n; index++)
            {
                arr[index] = rand.Next(0, 30);
                //Console.Write($"{arr[index]} ");
                if(arr[index] > 10)
                {
                    count++;
                    sum += arr[index];
                }
            }
            Console.WriteLine($"Average: {sum / count}");
        }
        static void Task11_106()
        {
            //Дан массив целых чисел.Рассмотреть отрезки массива(группы идущих 
            //подряд чисел), состоящие из нечетных чисел. Получить наибольшую из длин рассматриваемых отрезков.
            var rand = new Random();
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int count = 0;
            int maxCount = 0;

            for (int index = 0; index < n; index++)
            {
                arr[index] = rand.Next(0, 30);
                //Console.Write($"{arr[index]} ");
                if (arr[index] % 2 != 0)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            Console.WriteLine($"maximum odd-numbered array lenth: {maxCount}");
        }
        static void Task11_130()
        {
            //Известны очки(3, 1 или 0), полученные футбольной командой за ряд игр
            //в порядке их проведения. Что было раньше: первый выигрыш(3 очка) или
            //первый проигрыш(0 очков) ?
            int[] arr = new int[3];
            for (int index = 0; index<3; index++)
            {
                Console.Write($"Enter {index + 1} element: ");
                arr[index] = Convert.ToInt32(Console.ReadLine());
            }
            if((arr[0] == 0) | ((arr[1] == 0) & (arr[2] == 3)))
            {
                Console.WriteLine("Fail first");
            }
            else
            {
                Console.WriteLine("winning first");
            }
            
        }
        static void Task11_154()
        {
            //Удалить из массива, в котором все элементы различны, максимальный
            //и минимальный элементы.
            var rand = new Random();
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int index = 0; index < n; index++)
            {
                arr[index] = rand.Next(-10, 30);
                //Console.Write($"{arr[index]} ");
            }
            int i = 0;
            int minIndex = 0;
            int min = arr[0];
            int max = arr[0];
            int maxIndex = 0;
            int[] secondArr = new int[n-2];
            while (i<n)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }
                i++;
            }
            //Console.WriteLine($"min value: {min} with its index {minIndex}" +
            //    $"\nmax value: {max} with its index {maxIndex}");
            i = 0;
            int j = 0;
            while (i < n)
            {
                if ((i != minIndex) & (i != maxIndex))
                {
                    secondArr[j] = arr[i];
                    j++;
                }
                i++;
            }
            Console.Write($"Final array: ");
            for (int index = 0; index < n-2; index++)
            {
                Console.Write($"{secondArr[index]} ");
            }

        }
        static void Task11_180()
        {
            var rand = new Random();
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            
            for (int index = 0; index < n; index++)
            {
                arr[index] = rand.Next(4, 8);
                Console.Write($"{arr[index]} ");
            }
            int i = 0;
            while ((i < n) && (arr[i] != 5))
            {
                i++;
            }
            if (i == n)
            {
                Console.WriteLine("-- 5 not found");
            }
            else
            {
                Console.WriteLine($"first '5' index = {i}");
            }
            i = n - 1;
            while ((i >= 0) && (arr[i] != 5))
            {
                i--;
            }
            if (i < 0)
            {
                Console.WriteLine("-- 5 not found");
            }
            else
            {
                Console.WriteLine($"last '5' index = {i}");
            }
        }
        static void Task11_204()
        {
            //Дан массив целых чисел. Определить, есть ли в нем хотя бы одна пара соседних
            //нечетных чисел. В случае положительного ответа определить номера элементов первой из таких пар.
            var rand = new Random();
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int count = 0;
            int indexOfPair = 0;

            for (int index = 0; index < n; index++)
            {
                arr[index] = rand.Next(0, 30);
                Console.Write($"{arr[index]} ");
            }
            for (int index = 0; index < n; index++)
            { 
                if (arr[index] % 2 != 0)
                {
                    count++;
                    if (count >= 2)
                    {
                        indexOfPair = index;
                        break;
                    }
                }
            }
            Console.WriteLine($"indexes are: {indexOfPair-1}, {indexOfPair}");
        }
        static void Task11_228()
        {
            //Известны данные о численности населения(в миллионах жителей) и площади
            //(в тысячах квадратных километров) 28 государств.Определить общую численность
            //населения в "маленьких" государствах(чья площадь не превышает А тысяч квадратных километров)
            var rand = new Random();
            int[] population = new int[28];
            int[] S = new int[28];
            int totalPop = 0;
            Console.Write("Enter A < 500: ");
            int A = Convert.ToInt32(Console.ReadLine());
            for (int index = 0; index < 28; index++)
            {
                population[index] = rand.Next(0, 50);
            }
            for (int index = 0; index < 28; index++)
            {
                S[index] = rand.Next(0, 700);
                if (S[index] <= A)
                {
                    totalPop += population[index];
                }
            }
            Console.WriteLine($"'small' countries population = {totalPop}");

        }
    }
}
