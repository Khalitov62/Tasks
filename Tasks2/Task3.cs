using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks2
{
    public class Task3
    {
        
        public static void FirstWorld(string sentence)
        {
            sentence.Substring(0, sentence.IndexOf(' '));
            Console.WriteLine(sentence.Substring(0,sentence.IndexOf(' ')));
        }
    }
}
