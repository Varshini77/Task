using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Paramarray
    {
        public static void Main()
        {
            int result = product(1,2,3);
            Console.WriteLine(result);
            int[] num = new int[] { 4,5,6 };
            int a = product(num);
            Console.WriteLine(a);

        }
        public static int product(params int[] num)
        {
            int product = 1;
            foreach(int i in num)
            {
                product= product * i;
            }
            return product;
        }
    }
}
