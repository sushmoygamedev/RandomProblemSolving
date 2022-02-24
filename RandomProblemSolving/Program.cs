using System;
using System.Collections;
using System.Linq;

namespace RandomProblemSolving
{
    class Program
    {
        #region Check for Angrams Sorted String Function
        /*public static string sortedString(string str)
        {
            char[] strChar = str.ToCharArray();
            for (int i = 0; i < strChar.Length - 1; i++)
            {
                if (strChar[i] > strChar[i + 1])
                {
                    char c = strChar[i];
                    strChar[i] = strChar[i + 1];
                    strChar[i + 1] = c;
                    //i = -1;
                }
            }
            string sortStr1Char = new string(strChar);
            return (str + ": " + sortStr1Char);
        }*/
        #endregion
        static void Main(string[] args)
        {
            #region Solving...
            /*string str = "Lorem ipsum dolor sit amet consectetur adipisicing elit.";
            string newStr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    newStr += string.Empty;
                    //i -= 1;
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        newStr += char.ToUpper(str[i]);
                    }
                    else
                    {
                        newStr += char.ToLower(str[i]);
                    }
                }
            }
            Console.WriteLine(newStr);*/

            /*for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    Console.WriteLine(i+1);
                }
            }*/

            /*string[] strSplit = str.Split(' ');
            string newStr = string.Empty;
            //string modStr = string.Empty;
            for (int i = 0; i < strSplit.Length; i++)
            {
                for (int k = 0; k < strSplit[i].Length; k++)
                {
                    if (k%2 == 0)
                    {
                       newStr += char.ToUpper(strSplit[i][k]);
                    }
                    else
                    {
                        newStr += char.ToLower(strSplit[i][k]);
                    }

                    Console.WriteLine(newStr);
                }
            }*/
            //Console.WriteLine(newStr);

            /*for (int i = 0; i < newStr.Length; i++)
            {
                if (str[i] == ' ')
                {
                    modStr += ' ';
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        modStr += (char.ToUpper(newStr[i]));
                    }
                    else
                    {
                        modStr += (char.ToLower(newStr[i]));
                    }
                }
                
                *//*if (str[i] == ' ')
                {
                    Console.WriteLine(i-1);
                    Console.WriteLine(modStr);
                }*//*
                
            }*/
            //Console.WriteLine(modStr);
            #endregion
            #region Solved.
            /*string strSomething = "something";
            string[] strList = new string[]
            {
                "is better than nothing",
                "Bob Jane",
                "something"
            };

            for (int i = 0; i < strList.Length; i++)
            {
                Console.WriteLine(strSomething + " " + strList[i]);
            }*/

            /*string[] nameList = new string[] { "Mubashir", "Matt", "C#" };
            string result = string.Empty;
            for (int i = 0; i < nameList.Length; i++)
            {
                result = nameList[i] + "Edabit";
                Console.WriteLine(result);
            }*/

            /*string[] nameList = new string[] { "Gerald", "Tiffany", "Ed" };
            foreach (var item in nameList)
            {
                Console.WriteLine("Hello " + item + "!");
            }*/

            /*string[] nameList = new string[] { "Gerald", "Tiffany", "Ed", "Mubashir" };
            foreach (string name in nameList)
            {
                if (name == "Mubashir")
                {
                    Console.WriteLine("Hello, my Love!");
                }
                else
                {
                    Console.WriteLine("Hello, " + name);
                }
            }*/

            /*string firstName = "John";
            string lastName = "Doe";
            Console.WriteLine(lastName + ", " + firstName);
            string[] name = { firstName, lastName };
            Console.WriteLine(name[1] + ", " + name[0]);*/

            /*string str = " ";
            bool flag = false;
            if (string.IsNullOrEmpty(str))
            {
                flag = true;
            }
            Console.WriteLine(flag);*/

            /*string str1 = "name";
            string str2 = "list";
            bool flag = false;
            if (str1.Length == str2.Length)
            {
                flag = true;
            }
            Console.WriteLine(flag);*/

            /*string str = "apple";
            int strLen = str.Length;
            bool flag = false;
            if (strLen % 2 == 0)
            {
                flag = true;
            }
            Console.WriteLine(flag);*/

            /*string str = "apple";
            Console.WriteLine(str.Length);*/

            /*string[] strList = new string[] { "hello", "hello, world", " ", "", ",./!@#" };
            bool flag = false;
            for (int i = 0; i < strList.Length; i++)
            {
                if (!string.IsNullOrEmpty(strList[i]))
                {
                    for (int j = 0; j < strList[i].Length; j++)
                    {
                        if (strList[i][j] == ' ')
                        {
                            flag = true;
                            break;
                        }
                    }
                }
                else
                {
                    flag = false;
                }
                Console.WriteLine(strList[i] + ": " + flag);
            }*/

            /*string[] nameList = new string[] { "Aiden", "Piet", "Bert", "Dean" };
            bool flag = false;
            for (int i = 0; i < nameList.Length; i++)
            {
                if (nameList[i][nameList[i].Length - 1] == 'n')
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                Console.WriteLine(flag);
                *//*nameList[i][nameList[i].Length - 1]*//*
            }*/

            /*string bridge = "##########";
            bool flag = true;
            for (int i = 0; i < bridge.Length; i++)
            {
                if (bridge[i] == ' ')
                {
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;
                }
            }
            Console.WriteLine(flag);*/

            /*int x = 2;
            int y = 5;
            char op = '-';
            int result = 0;
            switch (op) {
                case '-':
                    result = x - y;
                    break;
                default:
                    Console.WriteLine("given input is wrong");
                    break;
            }
            Console.WriteLine(result);*/

            /*string[] strList = new string[] { "changes", "change", "dudes", "magic" };
            for (int i = 0; i < strList.Length; i++)
            {
                Console.WriteLine(strList[i][strList[i].Length - 1]);
                if (strList[i][strList[i].Length - 1] == 's')
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }*/

            /*string[] wordList = { "clever", "meek", "hurried", "nice" };
            string wordEnding = "ly";

            for (int i = 0; i < wordList.Length; i++)
            {
                Console.WriteLine(wordList[i] + wordEnding);
            }*/

            /*string strNum = "12";
            int numStr = 34;

            Console.WriteLine(Convert.ToInt32(strNum).GetType());
            Console.WriteLine(Convert.ToString(numStr).GetType());*/

            /*char[] alphabet = { 'A', 'B', 'C', 'D', 'a', 'b', 'c', 'd' };
            for (int i = 0; i < alphabet.Length; i++)
            {
                Console.WriteLine(alphabet[i] + ": " + Convert.ToInt32(alphabet[i]));
            }*/
            /*char ch = 'S';
            Console.WriteLine(Convert.ToInt32(ch));*/

            /*string str = "Mubashir and edabits is amazing.";
            string[] strSplit = str.Split(' ');
            string result = "";

            for (int i = 0; i < strSplit.Length; i++)
            {
                if (strSplit[i] == "edabit")
                {
                    result = str;
                    break;
                }
                else
                {
                    result = (str.Replace("amazing", "not amazing"));
                }
            }
            Console.WriteLine(result);*/

            /*string[] strList = new string[] { "edabit is amazing.", "Mubashir is amazing.", "Infinity is amazing.", "Mubashir and edabit are amazing.", "Everyone is amazing.", "Swift and edabit are amazing." };
            string[] strList2 = new string[strList.Length];
            for (int i = 0; i < strList.Length; i++)
            {
                string[] strSplit = strList[i].Split(' ');
                for (int j = 0; j < strSplit.Length; j++)
                {
                    //Console.WriteLine(strSplit[j]);
                    if (strSplit[j] == "edabit")
                    {
                        strList2[i] = strList[i];
                        break;
                    }
                    else
                    {
                        strList2[i] = strList[i].Replace("amazing", "not amazing");
                    }
                }
                Console.WriteLine(strList2[i]);
            }*/

            /*string[] strList = new string[] { "forza", "kali", "always", "love", "edabit" };
            for (int i = 0; i < strList.Length; i++)
            {
                Console.WriteLine(strList[i] + ": " + strList[i][0] + "" + strList[i][strList[i].Length-1]);
            }
            string str = "forza";
            Console.WriteLine(str[str.Length-1]);*/

            /*string str1 = "venom".ToLower();
            string str2 = "VENOM".ToLower();
            bool flag = false;
            if (str1.ToLower() == str2.ToLower())
            {
                flag = true;
            }
            Console.WriteLine(flag);*/

            /*string str1 = "access";
            string str2 = "ssi";
            bool flag = false;
            if (str1.EndsWith(str2))
            {
                flag = true;
            }
            Console.WriteLine(flag);
            Console.WriteLine(str1.Length + "\n" + str2.Length);
            if (str1.Length < str2.Length)
            {
                for (int i = 1; i <= str1.Length; i++)
                {
                    if (str1[str1.Length - i] == str2[str2.Length - i])
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            else
            {
                for (int i = 1; i <= str2.Length; i++)
                {
                    if (str1[str1.Length - i] == str2[str2.Length - i])
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            Console.WriteLine(flag);*/

            /*int num = 10;
            string chR = "";
            for (int i = 0; i < num; i++)
            {
                chR += "a";
            }
            if (num < 0)
            {
                Console.WriteLine("\"\"");
            }
            else if (num > 0)
            {
                Console.WriteLine("Ed" + chR + "bit");
            }
            else
            {
                Console.WriteLine("Edbit");
            }*/

            /*string str = "SOME thing";
            if (str.ToUpper() == str)
            {
                Console.WriteLine("upper");
            } else if (str.ToLower() == str)
            {
                Console.WriteLine("lower");
            }
            else
            {
                Console.WriteLine("mixed");
            }*/

            /*int x = 0;
            int y = 0;
            string cord = "EEWE";
            for (int i = 0; i < cord.Length; i++)
            {
                switch (cord[i])
                {
                    case 'E':
                        x++;
                        break;
                    case 'W':
                        x--;
                        break;
                    case 'N':
                        y++;
                        break;
                    case 'S':
                        y--;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("x:" + x);
            Console.WriteLine("y:" + y);
            if (x == y)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }*/

            /*string str = "I LOVE MAKING CHALLENGES";
            char ch = ' ';
            string newStr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                ch = str[i];
                if (ch == 'M')
                {
                    ch = 'W';
                }
                newStr += ch;
            }
            Console.WriteLine(newStr);*/
            /*for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'M')
                {
                    Console.WriteLine(str.Replace('M', 'W'));
                }
            }*/

            /*for (int i = 1; i <= 60; i++)
            {
                if (i < 10)
                {
                    Console.Write("0" + i + " ");
                }
                else
                {
                    Console.Write(i + " ");
                }
                

                for (int j = 0; j < i; j++)
                {
                    
                    Console.Write('-');
                }
                Console.WriteLine();
            }*/

            /*string[] strList = new string[] { "Pineapple", "Orange", "Grape", "Apple" };
            string str = "Orange";
            for (int i = 0; i < strList.Length; i++)
            {
                if (strList[i] == str)
                {
                    Console.WriteLine(i);
                }
            }*/

            /*string str = "Just an example here move along";
            string[] strSplit = str.Split(' ');
            Console.WriteLine(strSplit.Length);*/

            /*string str = "on-o-mat-o-poe-ia";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '-')
                {
                    count++;
                }
            }
            Console.WriteLine(count+1);*/

            /*string str = "big fat bubble";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'b')
                {
                    count++;
                }
            }
            Console.WriteLine(count);*/

            /*string str1 = "abcde";
            string str2 = "bcdef";
            int count = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    count++;
                    
                }
            }
            Console.WriteLine(count);*/

            /*string str = "Rosie O'Donnell";
            string[] strSplit = str.Split(' ');
            Console.WriteLine(strSplit[1] +" "+ strSplit[0]);*/

            /*string n1 = "24";
            string n2 = "88";
            if (Convert.ToInt32(n1) < Convert.ToInt32(n2))
            {
                Console.WriteLine(n1);
            }
            else
            {
                Console.WriteLine(n2);
            }*/

            /*string str = "nightmare";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        count++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(count);*/

            /*string str = "ll";
            bool flag = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[0] == str[i])
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
                
            }
            Console.WriteLine(flag);*/

            /*string[] strList = new string[] { "HELLO", "HEllo", "mArmALadE", "marmalade", "MARMALADE", "ketchUP", "pickle", "MUSTARD" };
            bool flag = false;
            for (int i = 0; i < strList.Length; i++)
            {
                if (strList[i] == strList[i].ToUpper() || strList[i] == strList[i].ToLower())
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                Console.WriteLine(strList[i] + ": " + flag);
            }*/

            /*string str = "My friend Dylan got distracted in school.";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'D' || str[i] == 'd')
                {
                    count++;
                }
            }
            Console.WriteLine(count);*/

            /*int num = 10;
            string repeatR = "";
            for (int i = 0; i < num; i++)
            {
                repeatR += "r";
            }
            System.Console.WriteLine("Bu" + repeatR + "p");*/

            /*string str = "CCClaClClap!Clap!ClClClap!";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'C')
                {
                    count++;
                }
            }
            Console.WriteLine(count);*/

            /*string str = "hello";
            if (str.Length == 0)
            {
                Console.WriteLine("\"\"");
            }
            else if (str.Length <= 2)
            {
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine(str.Substring(1, str.Length - 2));
            }*/

            /*string str = "incredible";
            string stutter = str.Substring(0, 2) + "...";
            for (int i = 0; i < 2; i++)
            {
                Console.Write(stutter + ' ');
            }
            Console.Write(str + "?");*/

            /*string str = "ab";
            int repeatNum = 5;
            string str2 = string.Empty;
            for (int i = 0; i < repeatNum; i++)
            {
                str2 += str;
            }
            Console.WriteLine(str2);*/

            /*string str = "hello";
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(str[i]);
                }
            }*/

            /*string word = "oraeangagsgdge";
            bool flag = false;
            for (int i = 0; i < word.Length-1; i++)
            {
                if (word[i] == word[i+1])
                {
                    flag = true;
                }
            }
            Console.WriteLine(flag);*/

            /*string left = "seas";
            string right = "onal";
            Console.WriteLine(char.ToUpper(left[0]) + left.Substring(1) + "" + right);*/

            /*string sentence = "Edabit is really helpful!";
            for (int i = sentence.Length-1; i >= 0; i--)
            {
                Console.Write(sentence[i]);
            }*/

            /*string str = "hellothere";
            for (int i = str.Length-1; i > -1; i--)
            {
                Console.Write(char.ToUpper(str[i]));
            }*/

            /*string str = "excuse me what?";
            int repeat = 5;
            string newStr = string.Empty;
            for (int i = 0; i < repeat; i++)
            {
                newStr += str[str.Length - 1];
            }
            Console.WriteLine(str.Substring(0, str.Length - 1) + newStr);*/

            /*string str = "######+++###+##+";
            int[] count = new int[] { 0, 0 };
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case '#': count[0]++; break;
                    case '+': count[1]++; break;
                    default:
                        break;
                }
            }
            for (int i = 0; i < count.Length; i++)
            {
                Console.WriteLine(count[i]);
            }*/

            /*string word = "mice";
            int repeat = 5;
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < repeat; j++)
                {
                    Console.Write(word[i]);
                }
            }*/

            /*string[] wordList = { "Ryan", "Kieran", "Jason", "Matt" };
            string[] wordList2 = new string[wordList.Length];
            for (int i = 0; i < wordList.Length; i++)
            {
                if (wordList[i].Length == 4)
                {
                    wordList2[i] += wordList[i];
                    Console.WriteLine(wordList2[i]);
                }
            }*/

            /*string str = "zpzpzpp";
            int countX = 0;
            int countY = 0;
            bool flag = false;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'x':
                        countX++;
                        break;
                    case 'o':
                        countY++;
                        break;
                    default:
                        break;
                }
                if (str[i] != 'x' || str[i] != 'o')
                {
                    if (countX == countY)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                else
                {
                    flag = false;
                }
            }
            Console.WriteLine(flag);
            Console.WriteLine(countX);
            Console.WriteLine(countY);*/

            /*string str = "space";
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                newStr += str[i] + " ";
            }
            Console.WriteLine( "\"" +newStr.Trim(' ') + "\"");*/

            /*string str = "hello";
            char[] strChar = str.ToCharArray();
            Array.Sort(strChar);
            Console.WriteLine(strChar);*/

            /*string str = "reviver";
            string strRev = string.Empty;
            bool flag = false;
            for (int i = 1; i < str.Length+1; i++)
            {
                strRev += (str[str.Length-i]);
            }
            *//*for (int i = str.Length-1; i > -1; i--)
            {
                strRev += str[i];
            }*//*
            if (str == strRev)
            {
                flag = true;
            }
            Console.WriteLine(flag);*/

            /*string str = "the aardvark";
            string newStr = "";
            char[] chars = str.ToCharArray();
            char ch = '#';
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                        newStr += ch;
                        break;
                    default:
                        newStr += str[i];
                        break;
                }
            }
            Console.WriteLine(newStr);*/

            /**
             * Sorting element with single loops
            */
            // SORT NUMBER
            /*int[] numList = new int[] { 1, 3, 99, 0, 2, 3, 5, 6, 4, 89, 0 };
            int temp;
            for (int i = 0; i < numList.Length-1; i++)
            {
                if (numList[i] > numList[i+1])
                {
                    temp = numList[i];
                    numList[i] = numList[i+1];
                    numList[i+1] = temp;
                    i = -1;
                }
            }
            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }*/

            // SORT STRING ARRAY
            /*string str = "hello";
            char[] strChar = str.ToCharArray();
            for (int i = 0; i < strChar.Length-1; i++)
            {
                if (strChar[i] > strChar[i+1])
                {
                    char ch = strChar[i];
                    strChar[i] = strChar[i + 1];
                    strChar[i + 1] = ch;
                    i = -1;
                }
            }
            string newStr = new string(strChar);
            Console.WriteLine(newStr);*/

            /**
             * Sorting element with double loops
            */
            // SORT NUMBER
            /*int[] numList = new int[] { 1, 9, 6, 7, 5, 9 };
            int temp;
            for (int i = 0; i < numList.Length - 1; i++)
            {
                for (int j = i+1; j < numList.Length; j++)
                {
                    if (numList[i] > numList[j])
                    {
                        temp = numList[i];
                        numList[i] = numList[j];
                        numList[j] = temp;
                    }
                }
            }
            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }*/
            // SORT STRING ARRAY
            /*string str = "javascript";
            char[] strChar = str.ToCharArray();
            for (int i = 0; i < strChar.Length-1; i++)
            {
                for (int j = i+1; j < strChar.Length; j++)
                {
                    if (strChar[i] > strChar[j])
                    {
                        char c = strChar[i];
                        strChar[i] = strChar[j];
                        strChar[j] = c;
                    }
                }
            }
            foreach (char c in strChar)
            {
                Console.Write(c);
            }*/
            //OPTIONAL [WITH CUSTOM ARRAY]
            /*string str = "geek";
            char[] chars = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                chars[i] = str[i]; // building char array
            }
            for (int i = 0; i < chars.Length-1; i++)
            {
                for (int j = i+1; j < chars.Length; j++)
                {
                    if (chars[i] > chars[j])
                    {
                        char c = chars[i]; // a temp variable to store first char in the string array
                        chars[i] = chars[j]; // if condition true swap the element position of previous char
                        chars[j] = c; // after swaping the next char will place after previous char in temp
                    }
                }
            }
            string sortedStr = new string(chars);
            Console.WriteLine(sortedStr);*/

            /*string first = "apple";
            string word = "banana";
            string last = "azure";
            string[] wordList = new string[] { first, word, last };
            string[] newWordList = new string[wordList.Length];
            for (int i = 0; i < wordList.Length; i++)
            {
                newWordList[i] = wordList[i];
            }
            for (int i = 0; i < newWordList.Length; i++)
            {
                for (int j = i+1; j < newWordList.Length; j++)
                {
                    if (newWordList[i].CompareTo(newWordList[j])>0)
                    {
                        string temp = newWordList[i];
                        newWordList[i] = newWordList[j];
                        newWordList[j] = temp;
                    }
                }
            }
            foreach (var item in newWordList)
            {
                Console.WriteLine(item);
            }*/

            /*int[] numList = new int[] { 1, 2, 2, 2, 3, 2, 5, 2, 6, 6, 3, 7, 1, 2, 5 };
            //Sorting Element
            for (int i = 0; i < numList.Length - 1; i++)
            {
                for (int k = i+1; k < numList.Length; k++)
                {
                    if (numList[i] > numList[k])
                    {
                        int temp = numList[i];
                        numList[i] = numList[k];
                        numList[k] = temp;
                    }
                }
            }
            //Output Sorted Array
            foreach (int num in numList)
            {
                Console.WriteLine(num);
            }
            //Seperator
            for (int i = 0; i < 20; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
            // Remove Duplicates
            int[] newNumList = new int[numList.Length];
            int j = 0;
            for (int i = 0; i < numList.Length-1; i++)
            {
                if (numList[i] != numList[i+1])
                {
                    newNumList[j] = numList[i];
                    j++;
                }
            }
            newNumList[j++] = numList[numList.Length - 1];
            //Output After Removing
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(newNumList[i]);
            }*/

            /*string[] wordList = new string[] { "John", "Taylor", "John" };
            //sorting with double loop
            for (int i = 0; i < wordList.Length - 1; i++)
            {
                for (int j = i + 1; j < wordList.Length; j++)
                {
                    if (wordList[i].CompareTo(wordList[j]) > 0)
                    {
                        string word = wordList[i];
                        wordList[i] = wordList[j];
                        wordList[j] = word;
                    }
                }
            }
            //sorting with single loop
            for (int i = 0; i < wordList.Length - 1; i++)
            {
                if (wordList[i].CompareTo(wordList[i + 1]) > 0)
                {
                    string word = wordList[i];
                    wordList[i] = wordList[i + 1];
                    wordList[i + 1] = word;
                    //i = -1;
                }
            }
            foreach (string word in wordList)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            // remove duplicates
            string[] newWordList = new string[wordList.Length];
            int k = 0;
            for (int i = 0; i < wordList.Length - 1; i++)
            {
                if (wordList[i] != wordList[i + 1])
                {
                    newWordList[k] = wordList[i];
                    k++;
                }
            }
            newWordList[k++] = wordList[wordList.Length - 1];
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(newWordList[i]);
            }*/

            /*string str = "https://www.reddit.com/r/funny/";
            for (int i = str.Length-2; i > -1; i--)
            {
                //Console.Write(str[i]);
                if ()
                {

                }
            }*/

            /*string str = "341s12";
            bool flag = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Length == 5 && str.All(char.IsDigit))
                {
                    flag = true;
                }
            }
            Console.WriteLine(flag);*/

            /*string str = "https://www.reddit.com/r/funny/";
            string[] strArr = str.Split('/');
            Console.WriteLine(strArr[strArr.Length-2]);*/

            /*string str = "R!=:~0o0./c&}9k`60=y";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    Console.WriteLine(str[i]);
                }
            }*/

            /*string str = "I have never seen a thin person drinking Diet Coke.";
            string strNew = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'A':
                    case 'a':
                    case 'E':
                    case 'e':
                    case 'I':
                    case 'i':
                    case 'O':
                    case 'o':
                    case 'U':
                    case 'u':
                        Console.Write(string.Empty);
                        //strNew += string.Empty;
                        break;
                    default:
                        Console.Write(str[i]);
                        //strNew += str[i];
                        break;
                }
            }
            //Console.WriteLine(strNew);*/

            /*string str = "asd";
            int[] index = new int[str.Length];
            int j = 0;
            string result = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    index[j] = i;
                    j++;
                }

            }

            for (int i = 0; i < j; i++)
            {
                if (i == j - 1)
                {
                    result += index[i];
                }
                else
                {
                    result += index[i] + ", ";
                }

            }
            Console.WriteLine("[" + result + "]");*/

            /*string str = "sPoNtAnEoUs";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    Console.Write(char.ToLower(str[i]));
                }
                else
                {
                    Console.Write(char.ToUpper(str[i]));
                }
            }*/

            /*string str = "This goes boom!!!";
            if (str.Contains("bomb"))
            {
                Console.WriteLine("Duck!!!");
            }
            else
            {
                Console.WriteLine("There is no bomb, relax.");
            }*/

            /*char ch = 'A';
            Console.WriteLine(Convert.ToInt32(ch));
            Console.WriteLine(Convert.ToInt32(char.ToLower(ch)));*/

            /*string strFrac = "7/4";
            string[] strSplit = strFrac.Split('/');
            float val0 = int.Parse(strSplit[0]);
            float val1 = int.Parse(strSplit[1]);
            float result = 0;
            for (int i = 0; i < strFrac.Length; i++)
            {
                if (strFrac[i] == '/')
                {
                    result = val0 / val1;
                }
            }
            Console.WriteLine(result);
            if (result > 1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }*/

            /*string str1 = "bush";
            string str2 = "hubris";
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
            {
                Console.WriteLine(true);
            }
            else
            {
                if (str1[0] == str2[str2.Length - 1] && str1[str1.Length - 1] == str2[0])
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }*/

            /*string str = "PasSword";
            string strL = str.ToLower();
            Console.WriteLine(strL);
            char[] chars = strL.ToCharArray();
            Array.Sort(chars);
            Console.WriteLine(chars);

            bool flag = true;
            for (int i = 0; i < chars.Length - 1; i++)
            {
                if (chars[i] == chars[i+1])
                {
                    flag = false;
                }
                
            }
            Console.WriteLine(flag);*/

            /*string strNum = "";
            string mask = string.Empty;
            for (int i = 0; i < strNum.Length-4; i++)
            {
                mask += "#";
            }
            if (strNum.Length > 4)
            {
                Console.WriteLine(mask + strNum.Substring(strNum.Length - 4));
            }
            else
            {
                if (string.IsNullOrEmpty(strNum))
                {
                    Console.WriteLine("\"\"");
                }
                else
                {
                    Console.WriteLine(strNum);
                }
            }*/

            /*string str = "inhabitant";
            if (str.Length%2 == 0)
            {
                //Console.WriteLine(str[str.Length / 2 - 1] +"" + str[str.Length / 2]);
                Console.WriteLine(str.Substring(str.Length/2-1,2));
            }
            else
            {
                Console.WriteLine(str[str.Length / 2]);
            }*/

            /*string str = "I am finding Nemo !";
            string[] strSplit = str.Split(' ');
            string result = string.Empty;
            for (int i = 0; i < strSplit.Length; i++)
            {
                if (strSplit[i] == "Nemo")
                {
                    result = ("I found Nemo at " + (i+1) + "!");
                    break;
                }
                else
                {
                    result = ("I can't find Nemo :(");
                }
            }
            Console.WriteLine(result);*/

            /*string str = "Butterflies are beautiful!".ToUpper();
            string scottishScreaming = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'a':
                    case 'A':
                    case 'i':
                    case 'I':
                    case 'o':
                    case 'O':
                    case 'u':
                    case 'U':
                        scottishScreaming += "e".ToUpper();
                        break;
                    default:
                        scottishScreaming += str[i];
                        break;
                }
            }
            Console.WriteLine(scottishScreaming);*/

            /*int year = 1756;
            Console.WriteLine(year/100+1);*/

            /*for (int i = 1000; i < 2021; i++)
            {
                if (i % 100 == 0)
                {
                    Console.WriteLine(i + "-" + (i / 100));
                }
                else
                {
                    Console.WriteLine(i + "-" + (i / 100 + 1));
                }
            }*/

            /*string str = "I just!!! can!!! not!!! believe!!! it!!!";
            Console.WriteLine(str.Trim(str[str.Length-1]) + str[str.Length-1]);*/

            //string str = "There are no stupid questions";
            /*string[] strSplit = str.Split(' ');
            for (int i = 0; i < strSplit.Length; i++)
            {
                Console.Write(char.ToUpper(strSplit[i][0]) + strSplit[i].Substring(1));
            }*/
            //ArrayList arrayList = new ArrayList();

            /*int j = 0;
            string[] arrayList = new string[5];
            
            string Temp = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    Temp += str[i];
                    if (i == (str.Length - 1))
                    {
                        
                        arrayList[j] = (Temp);
                        j++;
                    }
                    continue;
                }
                
                arrayList[j] = (Temp);
                j++;
                Temp = "";
            }
            Console.WriteLine(j);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }*/

            /*string str = "abcd";
            string newStr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                newStr += (char.ToUpper(str[i]));
                for (int j = 0; j < i; j++)
                {
                    newStr+=(str[i]);
                }
                newStr += ("-");
            }
            Console.WriteLine(newStr.Trim('-'));*/

            /*string str = "Not a palindrome";
            string modStr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetterOrDigit(str[i]))
                {
                    modStr += char.ToLower(str[i]);
                }
            }

            Console.WriteLine(modStr);
            string strRev = string.Empty;

            for (int i = modStr.Length-1; i > -1; i--)
            {
                strRev += modStr[i];
            }

            if (modStr == strRev)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }*/

            /*string str1 = "very"; //5
            string str2 = "fragile"; //3
            int sum = 0;

            if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    if (str1[i] > str2[i])
                    {
                        sum += (Convert.ToInt32(str1[i]) - Convert.ToInt32(str2[i]));
                    }
                    else
                    {
                        sum += (Convert.ToInt32(str2[i]) - Convert.ToInt32(str1[i]));
                    }
                }
                Console.WriteLine(sum + (str1.Length - str2.Length));
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str2[i] > str1[i])
                    {
                        sum += (Convert.ToInt32(str2[i]) - Convert.ToInt32(str1[i]));
                    }
                    else
                    {
                        sum += (Convert.ToInt32(str1[i]) - Convert.ToInt32(str2[i]));
                    }
                }
                Console.WriteLine(sum + (str2.Length - str1.Length));
            }*/

            /*string str = "Two seats were vacant.";
            string revWord = string.Empty;
            string[] strSplit = str.Split(' ');

            for (int i = 0; i < strSplit.Length; i++)
            {
                *//*for (int j = strSplit[i].Length-1; j > -1; j--)
                {
                    Console.Write(strSplit[i][j]);
                }*//*
                if (strSplit[i].Length >= 5)
                {
                    for (int j = strSplit[i].Length; j > 0; j--)
                    {
                        revWord += strSplit[i][j - 1];
                        
                    }
                    revWord += " ";
                }
                else
                {
                    revWord += strSplit[i] + " ";
                }
                
                
            }
            Console.WriteLine(revWord.Trim(' '));*/

            /*string str = "I like chorizos, but not sausages";
            string strNew = string.Empty;
            string[] strSplit = str.Split(' ');
            for (int i = 0; i < strSplit.Length; i++)
            {
                if (strSplit[i] == "chorizos," || strSplit[i] == "sausages")
                {
                    strNew += "Wursts";
                }
                else
                {
                    strNew += strSplit[i];
                    
                }
                strNew += " ";
                
            }
            Console.WriteLine(strNew);*/

            /*string str = "OOOOOOOOO---O";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'O')
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);*/

            /*string[] beads = new string[]
            {
                "O---OOOOOOOOO", "OOO---OOOOOOO", "OOOOOOO---OOO", "---OOOOOOOOOO", "OOOOOOOO---OO", "OO---OOOOOOOO", "OOOOOOO---OOO"
            };

            int count = 0;
            int[] beadsCount = new int[beads.Length];
            string result = string.Empty;
            for (int i = 0; i < beads.Length; i++)
            {
                for (int j = 0; j < beads[i].Length; j++)
                {
                    if (beads[i][j] == 'O')
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    
                }
                beadsCount[i] = count;
                count = 0;

                result += beadsCount[i].ToString();
                
            }
            Console.Write(result.TrimStart('0'));*/

            /*string str = 2131.ToString();
            if (str.Length < 2)
            {
                Console.WriteLine("Incompatible.");
            }
            else
            {
                if (str[0] == str[str.Length - 1])
                {
                    Console.WriteLine("Two's a pair.");
                }
                else
                {
                    Console.WriteLine(str[str.Length - 1] + str.Substring(1, str.Length - 2) + str[0]);
                }
            }*/

            #region Check for Angrams
            /*string str1 = "cristian".ToLower();
            string sortStr1Char = (sortedString(str1));
            Console.WriteLine(sortStr1Char);
            *//*char[] str1Char = str1.ToCharArray();
            for (int i = 0; i < str1Char.Length-1; i++)
            {
                if (str1Char[i] > str1Char[i+1])
                {
                    char c = str1Char[i];
                    str1Char[i] = str1Char[i + 1];
                    str1Char[i + 1] = c;
                    //i = -1;
                }
            }
            string sortStr1Char = new string(str1Char);
            Console.WriteLine(str1 + ": " + sortStr1Char);*//*

            string str2 = "Cristina".ToLower();
            string sortStr2Char = (sortedString(str2));
            Console.WriteLine(sortStr2Char);
            *//*char[] str2Char = str2.ToCharArray();
            for (int i = 0; i < str2Char.Length - 1; i++)
            {
                if (str2Char[i] > str2Char[i + 1])
                {
                    char c = str2Char[i];
                    str2Char[i] = str2Char[i + 1];
                    str2Char[i + 1] = c;
                    //i = -1;
                }
            }
            string sortStr2Char = new string(str2Char);
            Console.WriteLine(str2 + ": " + sortStr2Char);*//*

            bool flag = false;
            for (int i = 0; i < sortStr1Char.Length; i++)
            {
                if (sortStr1Char[i] == sortStr2Char[i])
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            Console.WriteLine(flag);*/
            #endregion
            #endregion
            #region Test
            /*string str = "abcd";
            string strNew = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                strNew += str[i];
                if (str[i] == str[str.Length - 1])
                {
                    for (int j = 0; j < i; j++)
                    {
                        strNew += (str[i]);
                    }
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        strNew += (str[i]);
                    }
                    strNew += ("-");
                }
                
                *//*Console.Write(str[i]);
                if (str[i] == str[str.Length - 1])
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(str[i]);
                    }
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(str[i]);
                    }
                    Console.Write("-");
                }*//*

            }
            Console.WriteLine(strNew);*/
            #endregion

            
        }
    }
}