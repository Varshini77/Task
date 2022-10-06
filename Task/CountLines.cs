using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class CountLines
    {
        public static void Main()

        {

            string path = @"C:\Users\EI13151\Training\Files\Table.txt";

            int count = File.ReadAllLines(path).Length;

            Console.WriteLine("Number of lines Text1 file: " + count);

        }
    }
}
