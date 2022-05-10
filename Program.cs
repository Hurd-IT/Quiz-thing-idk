using System;

namespace Quiz
{
    internal class Program {
        public static void Main()
        {
            Console.WriteLine("Our Quiz");
            Declan();
            Nigel();
        }
            public static void Jacob()
            {
                string temp;
                int answer, correctanswer;
                Console.Write("How many Calories in a gram of uranium? ");
                temp = Console.ReadLine();
                answer = Convert.ToInt32(temp);
                correctanswer = 16000000;
                Console.WriteLine($"the answer was {correctanswer}. You guessed {answer}");
            }
            public static void Declan()
            {
                string temp;
                int ans, correctans;
                Console.Write("How many days in a leap year?   ");
                temp = Console.ReadLine();
                ans = Convert.ToInt32(temp);
                correctans = 366;
            Console.WriteLine($"the answer was {correctans}. You guessed {ans}");
             }

            public static void Nigel()
            {
                Console.WriteLine("What color is grass");
                Console.WriteLine("1: Green");
                Console.WriteLine("2: Yellow");
                Console.WriteLine("3: Blue");
                Console.WriteLine("4: Black");
            string temp = Console.ReadLine();
                int num = int.Parse(temp);

                switch (num)
                {
                    case:
                        1
                Console.WriteLine("Correct");
                        break;
                    case:
                        2
                Console.WriteLine("Wrong");
                        break;
                    case:
                        3
                Console.WriteLine("Wrong");
                        break;
                    case: 4
                        Console.WriteLine("Wrong");
                        break;
                    default:
                        break;
                }
            }


        }
    }
}
