using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 8.	Write a C# program to toggle case of each character of a string.
9.	Write a C# program to count total number of vowels and consonants in a string.
10.	Write a C# program to find reverse of a string.
11.	Write a C# program to reverse order of words in a given string.
12.	Write a C# program to find highest frequency character in a string.
13.	Write a C# program to find total number of alphabets, digits or special character in a string
21.	Accept sentence replace each vowel by next consecutive character
22.	Create an array of 10 names sort in descending order
15.	Write a C# program to find the duplicate words and their number of occurrences in a string
17.	Write a C# program to reverse a given string with preserving the position of spaces
18.	WAP to find longest word in the given sentence
20.	Accept email_id from user and check valid or not(should contain @,.)
 */

namespace String
{
    internal class stringFunctions
    {
        public static string ToggleCharacter(string str)
        {
            char[] ch=str.ToCharArray();
            for(int i=0;i<ch.Length;i++)
            {
                
                if (ch[i] >= 65 && ch[i] <= 90)
                {
                    int a = (int)ch[i]+32;
                    ch[i]= (char)a;

                }
                else 
                {
                    int A = (int)ch[i]-32;
                    ch[i]= (char)A;
                }
            }
            string str1=new string(ch);
            return str1;
        }

        public static string CountVowelsConsonants(string str)
        {
            int cntv = 0, cntc = 0;
            char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u' || ch[i]=='A' || ch[i]=='E' || ch[i] =='I' || ch[i]=='O' || ch[i]=='U')
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

        public static string ReversString(string str)
        {
            string str1 = " ";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                str1 = str1 + str[i];

            }
            return $"{str1}";
        }

        public static string WordsReverse(string str)
        {
            string[] str1 = str.Split(' ');
            string word = " ";
            for (int i=str1.Length-1;i>=0;i--)
            {
                word = word+" "+str1[i];
            }
            return $"{word}";

        }

        public static string FrequencyOfString(string str)
        {
            string[] strarray = str.Split(' ');
            
            int cnt = 0;
            int max=0;
            string str1 = "";

            for (int i=0;i<strarray.Length;i++)
            {
                cnt = strarray[i].Length;
                if(cnt > max)
                {
                    max = cnt;
                    str1 = strarray[i];
                }
             
            }
            
            return $"{max}{str1}";
        }//Same for longest word

        public static string FindNumAlphabetsDigitsSymbol(string str)
        {
            int cntA = 0, cntD = 0, cntS = 0;
            char[] ch=str.ToCharArray();
            for(int i=0;i<str.Length;i++)
            {
                if ((ch[i] >= 'A' && ch[i]<='Z')|| (ch[i] >= 'a' && ch[i] <= 'z'))
                {
                    cntA++;
                }
                else if(str[i]>='0' && str[i]<='9')
                {
                    cntD++;
                }
                else
                {
                    cntS++;
                }
            }
            return $"Alphabets Count={cntA}\nDigits Count={cntD}\nSymbol Count={cntS}";
        }

        public static string CheckAnagram(string str1,string str2)
        {
            
            char[] ch1= str1.ToLower().ToCharArray();
            char[] ch2= str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);
            string str3 = new string(ch1);
            string str4 = new string(ch2);
           
            if(str3==str4)
            {
                Console.WriteLine("String is Anagram");

            }
            else
            {
                Console.WriteLine("String is not Anagram");
            }

            return $"{str3} {str4}";


        }

        public static string ReplaceVowelByNextCharacter(string str)
        {
            char[] ch=str.ToLower().ToCharArray();
            for(int i=0;i<ch.Length;i++)
            {
                if (ch[i]=='a' || ch[i]=='e' ||ch[i]=='i'|| ch[i]=='o' || ch[i]=='u')
                {
                    int a = (int)ch[i] + 1;
                    ch[i] = (char)a;
                }
            }
            string str2= new string(ch);

            return $"{str2}";

        }

        public static string SortArrayNames(string[] array)
        {
            int a=0;
           for(int i=0;i<array.Length;i++)
            {
                for(int j=i+1;j<array.Length;j++)
                {
                    a = array[i].CompareTo(array[j]);
                    if (a == 1)
                    {
                        string temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            foreach(string s in array)
            {
                Console.WriteLine(s);
            }
            return "after Sorting";

        }

        public static void FindDuplicate(string str)
        {
            string[] strarray = str.Split();
            for(int i=0;i<strarray.Length;i++)
            {
                int cnt = 1;
                for (int j=i+1;j<strarray.Length;j++)
                {
                   
                    if (strarray[i].Equals(strarray[j]))
                    {
                        cnt++;
                        Console.WriteLine($"Duplicate{strarray[i]} {cnt}");

                    }
                   
                }
            }

        }//Error




        public static string ReverseStringwithSpaces(string str)
        {
            string str1 = "";
            for(int i=str.Length-1;i>=0;i--)
            {
                str1=str1+str[i];
            }

            return str1;
        }


       public static void EmailVerify(string str)
        {
            char[] ch=str.ToCharArray();
            bool isCorrect = false;
            for(int i=0;i<ch.Length;i++)
            {
                if (ch[i] == '@' && ch[i] == '.')
                {
                    isCorrect = true;
                }
            }
            if(isCorrect)
            {
                Console.WriteLine("Correct");
            }
        }


        public static void Main(string[] args)
        {
            /* string str = "IiNDia";
             Console.WriteLine(ToggleCharacter(str));
             Console.WriteLine(CountVowelsConsonants(str));
             Console.WriteLine(ReversString(str));
             string str1 = "India is the Best";
             Console.WriteLine(WordsReverse(str1));
             Console.WriteLine(FrequencyOfString(str1));
             string str2 = "ABCabc12345*&#42";
             Console.WriteLine(FindNumAlphabetsDigitsSymbol(str2));
             string a1 = "Silent";
             string a2 = "Listen";
             Console.WriteLine(CheckAnagram(a1, a2));
            string str = "abcdu";
            Console.WriteLine(ReplaceVowelByNextCharacter(str));
            string[] str = { "Payal", "Kajal", "Abhi" ,"Samruddhi","Sanket","ketki","Aishwarya"};
            Console.WriteLine(SortArrayNames(str));
            string str = "India is India best a best Country India";
            FindDuplicate(str);
            Console.WriteLine(ReverseStringwithSpaces(str));*/
            string str = "payalgujar@gmail.com";
            string str2 = "Kajalgmail.com";
            EmailVerify(str);
            EmailVerify(str2);
            
            

        }
    }
}

