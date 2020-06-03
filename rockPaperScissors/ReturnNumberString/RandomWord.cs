using System;
using System.Collections.Generic;

namespace ReturnNumberString
{
    public class RandomWord
    {
        public static string SomeText(List<string> text)
        {
            var random = new Random();
            int index = random.Next(text.Count);
            return $"{text[index]}";
        }
    }
}
