using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 1.Create List And Remove Duplicate from it 
 3.Convert Array to List in Various Ways//forloop,AddRange
4.Convert List to Array
 */

namespace String.Generic_Collection
{
    internal class ListMethods
    {
        public static void DuplicateRemove(List<string> list)
        {

            for(int i=0; i<list.Count; i++)
            {
               for(int j=i+1; j<list.Count; j++)
                {
                    if (list[i].Equals(list[j]))
                    {
                        list.RemoveAt(j);
                        
                    }
                }
            }
        }

        public static void ListFrequency(List<string> list)
        {
            
            Dictionary<string,int> d1= new Dictionary<string,int>();

            for(int i=0;i<list.Count;i++)
            {
                int cnt = 1;
                for (int j = i+1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        cnt++;
                        list.RemoveAt(j);
                    }
                  

                }
                // int cnt = list[i].Count();
                d1.Add(list[i], cnt);

            }
            foreach(KeyValuePair<string,int> item in d1)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            

        }

        public static void ConvertArraytoList(int[] array)
        {
            List<int> list1= new List<int>();
           /* for(int i=0;i<array.Length;i++)
            {
                list1.Add(array[i]);
            }
            foreach(int i in list1)
            {
                Console.WriteLine(i);
            }*/ // Using For Loop

            list1.AddRange(array);
            foreach(int item in list1)
            {
                Console.WriteLine(item);
            }//Using addRange
        }



        public static void ConvertListtoArray(List<string> list)
        {
            string[] array= new string[list.Count];
           /* for(int i=0;i<list.Count;i++)
            {
                array[i]= list[i];
            }
            foreach(string i in array)
            {
                Console.WriteLine(i);
            }*///Using for

            array= list.ToArray();
            foreach (string i in array)
            {
                Console.WriteLine(i);
            }

            }




        public static void Main(string[] args)
        {
            List<string> list = new List<string>() {"Pune","Pune","Mumbai","Nashiq","Mumbai","Pune","satara","satara"};
            // DuplicateRemove(list);
             foreach(string i in list)
             {
                 Console.WriteLine(i);
             }
            ListFrequency(list);
           /* int[] array = new int[5] { 1, 2, 3, 4, 5 };
            ConvertArraytoList(array);
            ConvertListtoArray(list);*/



        }
    }
}
