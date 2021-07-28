using System;


namespace OperatorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //int y = 5;
            //int a = x++;
            //int b = ++y;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //for(int i =1; i<=5; ++i)
            //{
            //    Console.WriteLine(i);
            //}

            //var c = 5 / 2;
            //var d = 5.0 / 2;
            //var e = 5 / 3;
            //double f = 5 / 2;
            //Console.WriteLine(f);

            //var daysInAWeek = 7;
            //var totalDaysToBirthday = 23;
            //var weeksToBirthday = totalDaysToBirthday / daysInAWeek;
            //var days = totalDaysToBirthday % daysInAWeek;
            //var res = EvenOdd(22);

            //const int NUM_ROWS = 2;
            //const int NUM_COLS = 5;
            //bool running = true;
            //int row = 0;
            //int col = 0;
            //int spriteNo = -1;

            //while(running)
            //{
            //    spriteNo = ++spriteNo % (NUM_COLS * NUM_ROWS);
            //    row = spriteNo / NUM_ROWS;
            //    col = spriteNo % NUM_COLS;
            //}
            //int pounds = Methods.GetPounds(156);
            //int stones = Methods.GetStones(156);
            //Console.WriteLine(stones + " stones, " + pounds + " pounds \n");

            //int j = 5, k = 3, m = 4;
            //m += +j++ + ++k;
            //Console.WriteLine(m);

            //int mark = 95;
            //var grade = mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Failed";
            //Console.WriteLine(grade);

            var message = Priority(2);
        }
        public static bool EvenOdd(int num)
        {
            return num % 2 == 0;
        }
        public static string Priority(int level)
        {
            string priority = "Code";
            switch (level)
            {
                case 3:
                    priority = priority + "Red";
                    break;
                case 2:
                case 1:
                    priority = priority + "Amber";
                    break;
                case 0:
                    priority = priority + "Green";
                    break;
                default:
                    priority = "Error";
                    break;
            }
            return priority;
        }
    }
}
