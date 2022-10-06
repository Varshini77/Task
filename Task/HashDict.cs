using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class HashDict
    {
        public static void demo()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Apple");
            dict.Add(2, "Orange");
            dict.Add(3, "Mango");
            foreach(var obj in dict)
            {
                Console.WriteLine(obj); 
            }
            Console.WriteLine("key value of dict[1]:" + dict[1]);

        }
        public static void demo1()
        {
            Hashtable ht=new Hashtable();
            ht.Add(1, "Tamato");
            ht.Add(2, "Onion");
            ht.Add(3, "Carrot");
            // In order to print the hashtable use ICollection. 
            //note: You cannot use for loop directly
            ICollection key = ht.Keys;
            foreach(var obj in key)
            {
                Console.WriteLine(ht[obj]);
            }
            
            Console.WriteLine("Key value of ht[1]:" + ht[3]);
        }
        public static void Main()
        {
            demo();
            Console.WriteLine("---------");
            demo1();
        }


    }
}
