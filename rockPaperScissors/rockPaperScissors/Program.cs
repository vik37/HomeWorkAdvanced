using ReturnNumberString;
using rockPaperScissors.Helper;
using System;

namespace rockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfThreeWord = ClassOfRockPapSis.PlayList;
            string user;
            int points = 0;
            int lost = 0;
           
            Console.WriteLine("GAME: ROCK - PAPER - SCISSORS");
            Console.WriteLine("___________________________________");
           
            Console.ReadLine();
           
            //Console.WriteLine("YOU MUST ONLY WRITE: ROCK, PAPER or SCISSORS");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("For exit press: escape, For Continue: enter");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Press Enter for start the Game");
            Console.WriteLine("----------------------------------------");
            
                while (Console.ReadKey().Key != ConsoleKey.Escape)
                {
                Console.WriteLine("WRITE: ROCK, PAPER or SCISSORS");
                Console.WriteLine("----------------------------------------");
                user = Console.ReadLine().ToUpper().Trim();                               
                if (user != "ROCK" && user != "PAPER" && user != "SCISSORS")
                    {
                        Console.WriteLine("WRONG WORD");
                    }                
                    else
                    {
                        Console.WriteLine($"{RandomWord.SomeText(listOfThreeWord)}");
                        if (user == RandomWord.SomeText(listOfThreeWord))
                        {
                            points = points + 1;
                        }
                        else
                        {
                            lost = lost - 1;
                        }
                    }
                   
                }
            Console.ForegroundColor = ConsoleColor.Green;            
            Console.WriteLine($"Winner Points: --{points}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Lost Points: -{lost}");
            

            Console.ReadLine();
        }
    }
}
