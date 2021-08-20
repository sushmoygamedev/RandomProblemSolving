/*TRIGGER*/
/*
 char ch = 'A';
            CharacterCounterPartCode instence = new CharacterCounterPartCode();
            instence.ch = ch;
            instence.CharCode();
            instence.ch = 'b';
            instence.CharCode();
 */
using System;

namespace RandomProblemSolving
{
    public class CharacterCounterPartCode
    {
        public char ch;
        public void CharCode()
        {
            Console.WriteLine("Character: " + ch + " - " + Convert.ToInt32(ch));
            if (char.IsUpper(ch))
            {
                Console.WriteLine("CounterPart Character: " + char.ToLower(ch) + " - " + Convert.ToInt32(char.ToLower(ch)));
            }
            else
            {
                Console.WriteLine("CounterPart Character: " + char.ToUpper(ch) + " - " + Convert.ToInt32(char.ToUpper(ch)));
            }
        }
    }
}