using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class ReadFirstLine
    {
        public static void Main()

        {

            string path = @"C:\Users\EI13151\Training\Files\Table.txt";

            string[] content;

            content = File.ReadAllLines(path);

            Console.WriteLine("First line of Text1 file is");

            Console.WriteLine(content[0]);

        }
    }
}
