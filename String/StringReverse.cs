using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
/*
 India is the best
1.tseb eth si aidni
2.aidnI si rht tseb
3.India si eht best
4.India
  India is
  India is the
  India is the best
 */

namespace String
{
    internal class StringReverse
    {
        public static string ReversString(string str)
        {
            string str1=" ";
            
            for(int i=str.Length-1; i>=0; i--)
            {
                str1 = str1+str[i];

            }
            return $"{str1}";
        }

        public static string ReverseBySingleName(string str)
        {
            string[] strarray=str.Split(' ');
            string str1 = " ";
            for(int i=0;i<strarray.Length;i++)
            {
                string str2 = "";
                string word = strarray[i];
                for(int j = word.Length-1;j>=0;j--)
                {
                    str2 = str2 + word[j];
                }
                str1= str1+" "+str2;
            }
            return $"{str1}";
        }

        public static string MiddleReverse(string str)
        {
            string[] strarray = str.Split(' ');
            string str1 = " ";
            for (int i = 1; i < strarray.Length-1; i++)
            {
             //   if (i>0 || i!= strarray.Length-1)
                {
                    Console.WriteLine(  "hiiiii"+i);
                    string str2 = "";
                    string word = strarray[i];
                    for (int j = word.Length - 1; j >= 0; j--)
                    {
                        str2 = str2 + word[j];
                    }
                    str1 = str1 + " " + str2;
                }
                

            }
            str1 = strarray[0]+" "+str1+" "+strarray[strarray.Length-1];
            
            return $"{str1}";

        }
        public static void Main(string[] args)
        {
            string str = "India is the best country";
            Console.WriteLine(ReversString(str));
            Console.WriteLine(ReverseBySingleName(str));
            Console.WriteLine(MiddleReverse(str));

        }
    }
}
