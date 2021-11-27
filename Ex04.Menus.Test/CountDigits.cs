using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountCaptials : IMenuClickListener
    {
        public void MenuClick()
        {
            countCaptials();
        }

        private void countCaptials()
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
    }
}
