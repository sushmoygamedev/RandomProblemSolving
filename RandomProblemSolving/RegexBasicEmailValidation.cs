// TRIGGER
/*// ^[\w\.?]+@[\w]+\.[\w{2,3}]+[\.]?\w{2}$ - Basic Validation
// ^[\w\.?]+\@[\w]+\.(\w{2,3})(\.\w{2})?$ - More Accurate Basic Validation
string rxPattern = @"^[\w\.?]+\@[\w]+\.(\w{2,3})(\.\w{2})?$";
string[] testString = {
                "hello@edabit.com",
                "hello.gmail@com",
                "matt@edabit.com",
                "www.email.com",
                "test@mail.com",
                "mail.me@mail.com",
                "mail@gmail.c9.uk",
                "me@cosf.cos",
                "mail@email.com.bd",
                "test.me@mail.com",
            };
RegexBasicEmailValidation.isValidEmail(rxPattern, testString);*/

// EXTRA PATTERN LIST
// HERE ARE MORE VALIDATION PATTERN THAT I HAVE TESTED BEFORE,
// SOME ARE ACCURATE SOME ARE NOT.
// BUT PRACTICE TO GET MORE ACCURATE VALIDATION
// WITH REGULAR EXPRESSION OR REGEX.
/*
(\w+\.?\-?)+@(\w+\.?\-?)+(\.\w{2,3})

^(\w+\.?\-?)+@(\w+\.?\-?)+(\.\w{2,3})+(\.\w{2,3})?$

^(\w+\.?\-?)+@(\w+)(\.\w{2,3})(\.\w{2})?$

^(\w+\.?\-?)+@(\w+\-?\w+)(\.\w{2,3})(\.\w{2})?$

^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$

^([\w\.?\-?]+)([\@])([\w\-?]+)([\.])([\w]{2,3})([\.]?)([\w]{2})?$

^([a-z\d\.-]+)@([a-z\d-]+)\.([a-z]{2,8})(\.[a-z]{2,8})?$

^[\w\.?]+\@[\w]+\.(\w{2,3})(\.\w{2})?$
 */


using System;
using System.Text.RegularExpressions;

namespace RandomProblemSolving
{
    public class RegexBasicEmailValidation
    {
        public static void isValidEmail(string rxPattern, string[] testString)
        {
            Regex pattern = new Regex(rxPattern, RegexOptions.IgnoreCase);
            bool isValid = false;

            for (int i = 0; i < testString.Length; i++)
            {
                /*Match match = pattern.Match(testString[i]);
                if (!match.Success)
                {
                    isValid = false;
                }
                else
                {
                    isValid = true;
                }*/

                if (pattern.IsMatch(testString[i]))
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
                Console.WriteLine(testString[i] + ": " + isValid);
            }
            
            /*Match match = pattern.Match(testString);

            if (match.Success)
            {
                isValid = true;
            }*/

            /*if (pattern.IsMatch(testString))
            {
                isValid = true;
            }*/

            //Console.WriteLine(isValid);

            // THIS VALIDATION ARE NOT STRICT, JUST BASIC, HAVE TO MAKE MORE PATTERN TEST BFORE GET 100% ACCURATE AND STRICT
        }
    }
}