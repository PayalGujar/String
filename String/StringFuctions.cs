using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Concat,Trim,TrimEnd,TrimStart
namespace String
{
    internal class StringFuctions
    {
        public static void Main(string[] args)
        {
            string str1 = "Payal ";
            string str2 = " Gujar";

            string str3 = string.Concat(str1.TrimEnd()," ", str2.TrimStart());
            Console.WriteLine(str3);
            Console.WriteLine(str3.Trim());//Concated String and Trim Both side

            Console.WriteLine(str3.ToUpper() + "In Upper Case");
            Console.WriteLine(str3.ToLower() + "In Lower Case");

            Console.WriteLine(str3.IndexOf('a'));//1st occurance of a
            Console.WriteLine(str3.LastIndexOf('a'));//Last Index of a

            string[] sarray = str3.Split(' ');
            Console.WriteLine(sarray[0]);
            Console.WriteLine(sarray[1]);

            char[] ch = str1.ToCharArray();
            foreach (char c in ch) Console.WriteLine(c);
            foreach (string s in sarray) Console.WriteLine(s);
            //Convert sarray to Character array using ToCharArray
           /* for(int i=0;i<sarray.Length; i++)
            {
                
                
            }*/

            





        }
    }
}
