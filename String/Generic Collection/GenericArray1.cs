using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 1.WAP to create an array of 5 integers. Initialize 5 values. Display using foreach loop.
2.WAP to create an array of 5 strings to store students name, sort names in ascending order & display using foreach loop.
3.Create matrix of 3* 3 & calculate addition & display the details
4.WAP to create jagged array, initialized data & display the details
5.WAP to store rain fall in a week using 1D array , accept & display the rain fall.
 */


namespace String.Generic_Collection
{
    internal class GenericArray1
    {
      
        public static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
            foreach(int i in list1)
            {
                Console.WriteLine(i);
            }//1

            List<string> list2 = new List<string>() { "Payal", "Abhi", "Suyog", "Ketki", "Aishwarya" };
            foreach(string s in list2)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("After Sorting");
            list2.Sort();
            foreach (string s in list2)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Jagged Array");
            int[][] jArray = new int[3][];
            jArray[0] =new int[]{10,20,30,40};
            jArray[1] = new int[] { 50,60,70 };
            jArray[2] = new int[] { 80,90 };
           

           for(int i=0;i<jArray.Length;i++)
            {
                for(int j = 0; j < jArray[i].Length;j++)
                {
                    Console.WriteLine(jArray[i][j]);
                }
            }




        }

    }
}
