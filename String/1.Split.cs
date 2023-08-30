using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
/*
1.	WAP to split string into 2 tokens where string is “HELLO$WORLD”
2.	Write a C# program to find first occurrence of a character in a given string.
3.	Write a C# program to count occurrences of a character in given string.
4.	Write a C# program to trim leading white space characters in a string.
5.	Write a C# program to count total number of words in a string. 
6.	Write a C# program to remove all occurrences of a character from string
7.	Write a C# program to trim trailing white space characters in a string.
9.	Write a C# program to count total number of vowels and consonants in a string.
 */

namespace String
{
    public class _1
    {
        public static void Main(string[] args)
        {
            string str = "HELLO$WORLD";
            string[] sarray = str.Split('$');
            foreach (string s in sarray)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(str.IndexOf('L') + "=1st Occurance of L");//2

            char[] ch = str.ToCharArray();
            int cnt = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'L')
                {
                    cnt++;
                }
            }//3
            Console.WriteLine($"Occurance of L={cnt}");
            string str2 = "  Hello1";
            Console.WriteLine(str2.TrimStart());//4
            int cntwords = 0;
            for (int i = 0; i < sarray.Length; i++)
            {
                cntwords++;
            }
            Console.WriteLine($"Total Words in String={cntwords}");//5

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'L')
                {
                    ch[i] = '\0';
                }
            }//6



             foreach(char s in ch)
             {

                 Console.WriteLine(s);

             }
           /*  for(int i=0;i<ch.Length;i++)
             {
                 if (ch[i] == ' ')
                 {
                     continue;
                 }
                 else
            {
                Console.WriteLine(ch[i]);
            }
        }*/

            string str3 = "World2 ";
            Console.WriteLine(str3.TrimEnd());//7

           /* int cntvc = 0;
            for(int i=0;i<ch.Length;i++)
            {

            }*/
        }
    }
}





