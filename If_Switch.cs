using System;

namespace If_Switch
{
    public partial class If_Switch
    {
        static void Task4_10()
        {
            Console.WriteLine("Eneter R: ");
            double R = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Eneter a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            string result = ((Math.PI * Math.Pow(R, 2)) > Math.Pow(a, 2)) ? "The area of circle is bigger"
                                                                           : "The area of square is bigger";
            Console.WriteLine(result);
        }
        static void Task4_26()
        {
            Console.WriteLine("Eneter a two-digit num: ");
            string num2 = Console.ReadLine();

            Console.WriteLine("Eneter a : ");
            int a2 = Convert.ToInt32(Console.ReadLine());

            string res26 = (((Convert.ToInt32(num2[0]) + Convert.ToInt32(num2[1])) % 3) == 0) ? "Your num is multiple by 3"
                                                                                       : "Your num isn't multiple by 3";
            Console.WriteLine(res26);

            string res26_2 = (((Convert.ToInt32(num2[0]) + Convert.ToInt32(num2[1])) % a2) == 0) ? "Your num is multiple by a"
                                                                                                : "Your num isn't multiple by a";
            Console.WriteLine(res26_2);
        }
        static void Task4_42()
        {
            Console.WriteLine("Eneter a: ");
            double a42 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Eneter b: ");
            double b42 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Eneter c: ");
            double c42 = Convert.ToDouble(Console.ReadLine());

            string res42 = (a42 < b42) & (b42 < c42) ? "Yeap" : "Nope";
            string res42_4 = (a42 > c42) & (c42 > a42) ? "Yeap" : "Nope";

            Console.WriteLine($"4.42 a) {res42}\n4.42 b) {res42_4}");
        }      
        static void Task4_110()
        {
            Console.WriteLine("Введите масть: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номинал: ");
            int second = Convert.ToInt32(Console.ReadLine());

            switch (first)
            {
                case 1:
                    switch (second)
                    {
                        case 6:
                            Console.WriteLine("Шестерка");
                            break;
                        case 7:
                            Console.WriteLine("Семерка");
                            break;
                        case 8:
                            Console.WriteLine("Восьмерка");
                            break;
                        case 9:
                            Console.WriteLine("Девятка");
                            break;
                        case 10:
                            Console.WriteLine("Десятка");
                            break;
                        case 11:
                            Console.WriteLine("Валет");
                            break;
                        case 12:
                            Console.WriteLine("Дама");
                            break;
                        case 13:
                            Console.WriteLine("Король");
                            break;
                        case 14:
                            Console.WriteLine("Туз");
                            break;
                    }
                    Console.WriteLine("пик");
                    break;
                case 2:
                    switch (second)
                    {
                        case 6:
                            Console.WriteLine("Шестерка");
                            break;
                        case 7:
                            Console.WriteLine("Семерка");
                            break;
                        case 8:
                            Console.WriteLine("Восьмерка");
                            break;
                        case 9:
                            Console.WriteLine("Девятка");
                            break;
                        case 10:
                            Console.WriteLine("Десятка");
                            break;
                        case 11:
                            Console.WriteLine("Валет");
                            break;
                        case 12:
                            Console.WriteLine("Дама");
                            break;
                        case 13:
                            Console.WriteLine("Король");
                            break;
                        case 14:
                            Console.WriteLine("Туз");
                            break;
                    }
                    Console.WriteLine("треф");
                    break;
                case 3:
                    switch (second)
                    {
                        case 6:
                            Console.WriteLine("Шестерка");
                            break;
                        case 7:
                            Console.WriteLine("Семерка");
                            break;
                        case 8:
                            Console.WriteLine("Восьмерка");
                            break;
                        case 9:
                            Console.WriteLine("Девятка");
                            break;
                        case 10:
                            Console.WriteLine("Десятка");
                            break;
                        case 11:
                            Console.WriteLine("Валет");
                            break;
                        case 12:
                            Console.WriteLine("Дама");
                            break;
                        case 13:
                            Console.WriteLine("Король");
                            break;
                        case 14:
                            Console.WriteLine("Туз");
                            break;
                    }
                    Console.WriteLine("бубен");
                    break;
                case 4:
                    switch (second)
                    {
                        case 6:
                            Console.WriteLine("Шестерка");
                            break;
                        case 7:
                            Console.WriteLine("Семерка");
                            break;
                        case 8:
                            Console.WriteLine("Восьмерка");
                            break;
                        case 9:
                            Console.WriteLine("Девятка");
                            break;
                        case 10:
                            Console.WriteLine("Десятка");
                            break;
                        case 11:
                            Console.WriteLine("Валет");
                            break;
                        case 12:
                            Console.WriteLine("Дама");
                            break;
                        case 13:
                            Console.WriteLine("Король");
                            break;
                        case 14:
                            Console.WriteLine("Туз");
                            break;
                    }
                    Console.WriteLine("червей");
                    break;
            }
        }
        static void Task4_58()
        {
            Console.WriteLine("Eneter a three-digit num: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            int desiatok = Math.DivRem(num5, 100, out int sotni);
            int odinitsi = Math.DivRem(sotni, 10, out int nevaghno);
            string res = (odinitsi == 4 | odinitsi == 7 | desiatok == 4 | desiatok == 7 | nevaghno == 4 | nevaghno == 7) ? "Yes" : "No";
            Console.WriteLine(res);
        }
        static void Main(string[] args)
        {
            ChoiceSort();
        }           
     
    }
}
