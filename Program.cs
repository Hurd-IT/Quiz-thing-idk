﻿using System;

namespace Quiz
{
    internal class Program {
        public static void Main()
        {
            Console.WriteLine("Our Quiz");
            Declan();
            Nigel();
            Chase();
            Jacob();
        }



        public static void Chase()
        {
            string answer;
            Console.WriteLine("What colour is the sky?");
            answer = Console.ReadLine();
            if (answer == "blue")
            {
                Console.WriteLine("You are Correct");
            }
            else
            {
                Console.WriteLine("You are Wrong");
            }
            Console.ReadLine();
        }
            public static void Jacob()
            {
                string temp;
                int answer, correctanswer;
                Console.Write("How many Calories in a gram of uranium? ");
                temp = Console.ReadLine();
                answer = Convert.ToInt32(temp);
                correctanswer = 18000000;
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
            if (ans == correctans)
            {
                Console.WriteLine("You are correct.");
            }
            else
            {
                Console.WriteLine($"The answer you gave was incorrect. The correct answer is {correctans}");
            }
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
                    case 1:
                Console.WriteLine("Correct");
                        break;
                    case 2:
                Console.WriteLine("Wrong");
                        break;
                    case 3:
                Console.WriteLine("Wrong");
                        break;
                    case 4: 
                        Console.WriteLine("Wrong");
                        break;
                    default:
                        break;
                }
            }


        }
    }

