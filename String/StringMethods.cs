using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 9.	Write a C# program to count total number of vowels and consonants in a string
10.	Write a C# program to find reverse of a string.
String str=new String(ch)//Convert character array to string
 */

namespace String
{
    internal class StringMethods
    {
        public static string CountVowelsConsonants(string str)
        {
            int cntv=0,cntc=0;
            char[] ch=str.ToCharArray();

            for(int i=0; i<ch.Length; i++)
            {
                if (ch[i] =='a' || ch[i] =='e' || ch[i]=='i' || ch[i]=='o' || ch[i]=='u')
                {
                    cntv++;
                }
                else
                {
                    cntc++;
                }
            }

            return $"Vowels Count={cntv} and Consonant count={cntc}";
        }

       /* public static string ReverseArray(string str)
        {
            char[] ch= str.ToCharArray();
            for(int i=ch.Length-1; i>=0;i--)
            {
                str = ch[i];
            }
        }*/
        public static void Main(string[] args)
        {
            string str = "Payal Gujar";
            Console.WriteLine(CountVowelsConsonants(str));

        }
    }
}
