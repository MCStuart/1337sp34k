using System;

namespace Leetspeak
{
    public class Leetspeak
    {
        public string LeetspeakGenerator(string userInput)
        {
            if (userInput == "e")
            {
                return "3";
            }
            if (userInput == "o")
            {
                return "0";
            }
            if (userInput == "I")
            {
                return "1";
            }
            return "";
        }
    }
}
