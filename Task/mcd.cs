using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class mcd
    {
        public static void Main()

        {
            string source = @"C:\Users\EI13151\Training\Files\text1.txt";
            string target = @"C:\Users\EI13151\Training\text1.txt";
            //File.Move(source,target);
            //File.Copy(target, source);
            File.Delete(target);
        }
    }
}

