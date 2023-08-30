using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    
    internal class Exam27Aug
    {
        public static void Main(string[] args)
        {
           /* string str=Console.ReadLine();
            char[] ch=str.ToCharArray();

            for(int i=0;i<ch.Length;i++)
            {
                if (ch[i] >=65 && ch[i] <=90)
                {
                    int a = (char)ch[i] + 32;
                    ch[i]=(char)a;
                }
                else
                {
                    int A = (char)ch[i]-32;
                    ch[i]=(char)A;
                }
            }
            string str1=new string(ch);
            Console.WriteLine(str1);*/

            string str1=Console.ReadLine(); 
            string str2=Console.ReadLine();

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            

        }
    }
}
