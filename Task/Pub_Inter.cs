using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Inter
    {
        public int stdid;
        public string stdname;
        public string stddep;

        public void std_details(int id, string name, string dep)
        {
            stdid = id;
            stdname = name;
            stddep = dep;
            Console.WriteLine($"{stdid}:{stdname}:{stddep}");
        }
    }
    internal class Pub_Inter
    { 
        public static void Main()
        {
            Inter inter = new Inter();
            inter.std_details(151, "Varshini", "Full stack developer");
        }
    }
}
