using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
/*
 Generic Stack,Queue,List
 */

namespace String
{
    internal class GenericExample
    {
        /* public class Product
         {
             public int Id { get; set; }
             public string Name { get; set; }
         }*/
        public static void Main(string[] args)
        {
            /*  Stack<string> stack1= new Stack<string>();
              stack1.Push("Samruddi");
              stack1.Push("Ketki");
              stack1.Push("Vinaya");
              foreach (var item in stack1)
              {
                  Console.WriteLine(item);
              }
              stack1.Pop();
              Console.WriteLine("After Poping");
              foreach (var item in stack1)
              {
                  Console.WriteLine(item);
              }

              Queue<int> q1=new Queue<int>();
              q1.Enqueue(10);
              q1.Enqueue(20);
              q1.Enqueue(30);

              foreach (var item in q1)
              {
                  Console.WriteLine(item);
              }

              List<Product> p1= new List<Product>();
              p1.Add(new Product { Id = 101, Name = "Book" });
              p1.Add(new Product { Id = 102, Name = "Pen" });
              p1.Add(new Product { Id = 103, Name = "Mouse" });

             foreach(Product i in p1)
              {
                  Console.WriteLine($"{i.Id}{i.Name}");
              }

              p1.Insert(2, new Product { Id = 100, Name = "Table" });
             /* p1.Sort();
              Console.WriteLine("After Sorting");
              foreach (Product i in p1)
              {
                  Console.WriteLine($"{i.Id}{i.Name}");
              }*/
            //Cannot directely use sort on Product (need to Implement ICompareble)*/



            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            dict1.Add(91, "India");
            dict1.Add(22, "USA");
            dict1.Add(44, "END");
            foreach(KeyValuePair<int, string> d1 in dict1)
            {
                Console.WriteLine(d1.Key);
                Console.WriteLine(d1.Value);
            }

        }      
        
    }
}
