using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class add
    {
        public add(int a, int b)
        {
            Console.WriteLine($"Out put of add in int: {a + b}");
        }
        public add(float a, float b)
        {
            Console.WriteLine($"Out put of add in float: {a + b}");
        }
        public add(string a, string b)
        {
            Console.WriteLine($"Out put of add in string: {a + b}");
        }
    }
        internal class Const_Overload
        {
            public static void Main()
            {
                add ad = new add(2, 4);
                add ft = new add(3.1f, 5.2f);
                add st = new add("Hello", "World");
            }
        }
    }


