using System;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountWords());
            Console.WriteLine(isUpper());
        }

        public static int CountWords()
        {
            string sentence = "Salam Aleykum";
            var wordCount = 0;
            for (var i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ' || i == sentence.Length -1)
                {
                    wordCount++;
                }
            }
            return wordCount;
        }
        public static bool isUpper()
        {
            string sentence = "Task qisadi";
            int count = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (char.IsUpper(sentence[i]) && i == 0)
                {
                    count++;

                }
                else if (char.IsWhiteSpace(sentence[i]))
                {
                    count++;
                    if(char.IsUpper(sentence[i + 1]))
                    {
                        count++;
                    }
                }
            }
            return count ==3 ? true : false;
        }
    }
}
