using System;

namespace SharedLeetspeak
{
    public class Leetspeak
    {
        public string LeetspeakGenerator(string userInput)
        {
            char[] letters = userInput.ToCharArray();
            string word = new string(letters);
            Console.WriteLine(word);
            for (int i = 0; i <= word.Length - 1; i++)
            {
                word.Replace("e","3");
                word.Replace("o","0");
                word.Replace("I","1");
                word.Replace("t","7");
                word.Replace("s","s");
                if (word.Contains("s") && !word.StartsWith("s"))
                {
                    word.Replace("s","z");
                }
                else
                {
                    return "";
                }
            }
        }
    }
}
