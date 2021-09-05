using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Guess_the_Word
    {


        public void FindSecretWord(string[] wordlist)
        {

            List<string> myList = new List<string>();
            foreach (var word in wordlist)
            {
                myList.Add(word);
            }

            for (int i = 0; i < 10; i++)
            {
                int rand = new Random().Next(0, myList.Count);
                int guess = master_guess(myList[rand]);
                ReduceList(myList, myList[rand], guess);
            }
        }

        private void ReduceList(List<string> myList, string gWord, int guess)
        {
            for (int i = myList.Count - 1; i >= 0; i--)
            {
                int temp = 0;
                for (int j = 0; j < 6; j++)
                    if (gWord[j] == myList[i][j])
                    {
                        temp++;
                    }
                if (temp != guess)
                    myList.RemoveAt(i);
            }
        }

        private int master_guess(string guess)
        {
            Console.WriteLine(guess);
            int temp = 0;
            string secret = "acckzz";
            for (int j = 0; j < 6; j++)
                if (guess[j] == secret[j])
                {
                    temp++;
                }
            return temp;
        }
    }
}

