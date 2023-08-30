using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Methods in HashSet
Remove(element);
clear();
 */

namespace String.Generic_Collection
{
    internal class ExampleHashSet
    {
        public static void Main(string[] args)
        {
            HashSet<string> h1=new HashSet<string>();
            h1.Add("Pune");
            h1.Add("Mumbai");
            h1.Add("Satara");
            h1.Add("Pune");

            HashSet<string> h2=new HashSet<string>();
            h2.Add("Nashik");
            h2.Add("Pune");
            h2.Add("Mumbai");
            h2.Add("Dhule");

            h1.UnionWith(h2);
            Console.WriteLine("UNION");
            foreach(string s in h1)
            {
                Console.WriteLine(s);   
            }
            Console.WriteLine(".......................................................................");
            h1.IntersectWith(h2);
            Console.WriteLine("INTERSECTION");
            foreach (string s in h1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("...........................................................................");
            h1.ExceptWith(h2);
            Console.WriteLine("EXCEPT");
            foreach (string s in h1)
            {
                Console.WriteLine(s);
            }
        }
    }
}
