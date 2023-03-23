using System;

namespace RandomProblemSolving
{
    public class PluralSingular
    {
        public bool isPlural()
        {
            string[] wordList = new string[] { "dudes", "flowers", "checks", "varies", "efforts", "mood", "whiteboard", "cow", "word", "love" };
            bool hasS = true;

            foreach (string word in wordList)
            {
                if (word[word.Length - 1] == 's')
                {
                    hasS = true;
                }
                else
                {
                    hasS = false;
                }
                Console.WriteLine(word + ": " + hasS);
            }
            return hasS;

            /*foreach (char ch in str)
            {
                if(str[str.Length - 1] == 's')
                {
                    if (ch == 's')
                    {
                        isPlural = true;
                    }
                } else
                {
                    isPlural = false;
                }
            }

            Console.WriteLine(isPlural);*/

            /*for(int i = 0; i < str.Length; i++)
            {
                if (str[str.Length-1] == 's')
                {
                    isPlural = true;
                } else
                {
                    isPlural = false;
                }
                
            }
            Console.WriteLine(isPlural);*/


            /*if(str.EndsWith('s')) {
                isPlural = true;
            }
            else
            {
                isPlural = false;
            }
            Console.WriteLine(isPlural);*/
        }
    }
}
/*
 // RUN
PluralSingular instance = new PluralSingular();
            instance.isPlural();
 */