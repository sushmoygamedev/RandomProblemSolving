// TRIGGER
/*
string str = "R!=:~0o0./c&}9k`60=y";
            LettersOnly instenceString = new LettersOnly();
            instenceString.str = str;
            Console.WriteLine(instenceString.isLetterString());

            string[] strArray = new string[]
            {
                "R!=:~0o0./c&}9k`60=y",
                "^,]%4B|@56a![0{2m>b1&4i4",
                "^U)6$22>8p).",
                ",1|2)\")A^1<[_)?^\"]l[a`3+%!d@8-0_0d.*}i@&n?=",
                "I5n!449+c@e*}@@1]p{2@`,~t:i0o%n<3%8",
                "!)\"P[s9)\"69}yc3+?1]+33>3ho",
                ":~;G{o}o{+524<df~:>}e24{l8:_l]a:?@]%s7",
                "&&S~]@8>1-0!h#r),80<_>!}|e>_k:",
                ")^/|,!!09]=/1<G2?`=[l{a}d9]^i7a0|t6_o2*r",
                "]8;]V9e{=0r!.5t>i<^_g\"4o\"5~",
                "%%)?\"?B#>/_4a#,;t8|m8675a(n",
                "97H^)~a8567ll*o?\"6%)w63e37e<n?@="
            };

            LettersOnly instenceArrayList = new LettersOnly();
            instenceArrayList.strArray = strArray;
            Console.WriteLine(instenceArrayList.isLetterArrayList()); 
*/

using System;

namespace RandomProblemSolving
{
    public class LettersOnly
    {
        public string str;
        public string isLetterString()
        {
            string extractedStr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    extractedStr += str[i];
                }
            }
            return (extractedStr);
        }

        public string[] strArray;
        public string isLetterArrayList()
        {
            string[] strNewArray = new string[strArray.Length];

            for (int i = 0; i < strArray.Length; i++)
            {
                for (int j = 0; j < strArray[i].Length; j++)
                {
                    if (char.IsLetter(strArray[i][j]))
                    {
                        strNewArray[i] += strArray[i][j];
                    }
                }
                Console.WriteLine(strArray[i] + ": " + "[" + strNewArray[i] + "]");
            }
            return null;
        }
    }
}