using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excsercise2_del2.Modules
{
    public class Questions
    {
        public static List<string> question = new List<string>() { "What is the capital of Tasmania?", 
            "What is the tallest building in the Republic of the Congo?",
        "Which of these is not one of Pluto's moons?","What is the smallest lake in the world?",
            "What country has the largest population of alpacas?"};

        public static void ShowFirst()
        {
            string text;
            text = question.FirstOrDefault();
            Console.WriteLine(text);
         }
        public static void ShowSecond()
        {
            string text;
            text = question.Where(q => q.Contains("Congo?")).FirstOrDefault();
            Console.WriteLine(text);
        }
        public static void ShowThird()
        {
            string text;
            text = question.Where(q => q.EndsWith("moons?")).FirstOrDefault();
            Console.WriteLine(text);
        }
        public static void ShowForth()
        {
            string text;
            text = question.Where(q => q.EndsWith("world?")).FirstOrDefault();
            Console.WriteLine(text);
        }
        public static void Showifth()
        {
            string text;
            text = question.LastOrDefault();
            Console.WriteLine(text);
        }

    }
    
}
