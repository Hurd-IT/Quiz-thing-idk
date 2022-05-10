using System;

namespace Quiz
{
    internal class Program
    {
       public static void Declan()
        {
            string temp;
            int ans, correctans;
            Console.Write("How many days in a leap year?   ");
            temp = Console.ReadLine();
            ans = Convert.ToInt32(temp);
            correctans = 366;
            Console.WriteLine($"the answer was {correctans}. You guessed {ans}")
        }
        public static void Main()
        {
            Console.WriteLine("Our Quiz");
            Declan();
        }
    }
}
