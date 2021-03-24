using System;
using System.Collections.Generic;
using System.Text;

namespace If_Switch
{
    public partial class If_Switch
    {
        static void Metanit1()
        {
            //С помощью циклов переберите все элементы этого массива и выведите их на консоль в следующем виде:
            //{{{1 , 2} , {3 , 4}} , {{4 , 5} , {6 , 7}} , {{7 , 8}, {9 , 10}} , {{10 , 11} , {12 , 13}}}
            int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
            };
            int firstLayer = mas.GetUpperBound(0);
            int secondLayer = mas.GetUpperBound(1);
            int thirdLayer = mas.GetUpperBound(2);

            Console.Write("{");
            for (int i = 0; i <= firstLayer; i++)
            {
                Console.Write("{");
                for (int j = 0; j <= secondLayer; j++)
                {
                    Console.Write("{");
                    for (int k = 0; k <= thirdLayer; k++)
                    {
                        Console.Write(mas[i, j, k]);
                        if (k < thirdLayer)
                            Console.Write(" , ");
                    }

                    Console.Write("}");
                    if (j < secondLayer)
                        Console.Write(" , ");
                }
                Console.Write("}");

                if (i < firstLayer)
                    Console.Write(" , ");
            }
            Console.Write("}");
            Console.ReadLine();
        }
        static void Task12_10()
        {
            //Составить программу, которая меняет местами два любых элемента двумерного массива.
            Console.Write("Enter number of elements of first dimention: ");
            int firstN = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of elements of second dimention: ");
            int secondN = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[firstN,secondN];
            for (int i = 0; i<firstN; i++)
            {
                for (int j = 0; j < secondN; j++)
                {
                    Console.Write($"Enter {j + 1} element of second dimension: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int temp;
            Console.Write("Enter dimention of element you would like to swap: ");
            int i1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of element you woulg like to swap: ");
            int j1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter dimention of element you would like to be swapped: ");
            int i2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of element you woulg like to be swapped: ");
            int j2 = Convert.ToInt32(Console.ReadLine());
            temp = arr[i1, j1];
            arr[i1, j1] = arr[i2, j2];
            arr[i2, j2] = temp;

            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void Task12_34()
        {
            //Дан двумерный массив. Вывести на экран его элементы следующим образом:
            var rand = new Random();
            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter number of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"\nEnter {j + 1} element: ");
                    arr[i, j] = rand.Next(0,9);
                    Console.Write($"{arr[i, j]}");
                }
            }
            //a) сначала элементы первой строки справа налево, затем второй строки справа налево и т.п
            for (int i = 0; i < rows; i++)
            {
                for (int j = columns - 1; j >= 0; j--)
                {
                    Console.Write($"{arr[i, j]} \t");
                }
                Console.WriteLine();
            }
            //б) сначала элементы первой строки справа налево, затем второй строки слева направо и т. п.
            for (int i = 0; i < rows; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{arr[i, j]} \t");
                    }
                }
                else
                {
                    for (int j = columns - 1; j >= 0; j--)
                    {
                        Console.Write($"{arr[i, j]} \t");
                    }
                }
                Console.WriteLine();
            }
            //в) сначала элементы первого столбца сверху вниз, затем второго столбца сверху вниз и т. п.
            for (int i = 0; i < columns; i++)
            {
                Console.WriteLine($"");
                for (int j = 0; j < rows; j++)
                {
                    Console.Write($"{arr[i, j]} \t");
                }
                
            }
        }
    }
    
}
