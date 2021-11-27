using System;

namespace Ex04.Menus.Test
{
    public class MethodsForMenusDelegates
    {
        public void CountCaptials()
        {
            Console.Write("Please enter a sentence: ");
            string sentenceFromUser = Console.ReadLine();
            int numberOfCaptialsInSentence = countNumberOfCaptialsInSentence(sentenceFromUser);
            Console.WriteLine("There are {0} Captials at the current sentence.", numberOfCaptialsInSentence);
        }

        private int countNumberOfCaptialsInSentence(string i_SentenceFromUser)
        {
            int CaptialsCounter = 0;
            char[] sentenceInChars = i_SentenceFromUser.ToCharArray();
            foreach (char character in sentenceInChars)
            {
                if (char.IsUpper(character))
                {
                    CaptialsCounter++;
                }
            }

            return CaptialsCounter;
        }

        public void ShowDate()
        {
            Console.WriteLine(string.Format("Current Date: {0}", DateTime.Now.ToShortDateString()));
        }

        public void ShowTime()
        {
            Console.WriteLine(string.Format("Current Time: {0}", DateTime.Now.ToString("hh:mm:ss tt")));
        }

        public void ShowVersion()
        {
            Console.WriteLine("Version: 20.2.4.30620");
        }
    }
}
