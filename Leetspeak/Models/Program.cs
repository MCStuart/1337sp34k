using System;

namespace SharedLeetspeak
{
    public class UserInterface
    {
        static void Main()
        {
            Console.WriteLine("Please enter a word: ");
            string userInput = Console.ReadLine();
            Leetspeak leetspeaker = new Leetspeak();
            string leetspoken = leetspeaker.LeetspeakGenerator(userInput);
            Console.WriteLine(leetspoken);
        }
    }
}
