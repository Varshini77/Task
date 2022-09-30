using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Student
    {
        public static void Main()
        {
            int sid;
            string sname;
            string sdep;
            studentdetails(out sid, out sname, out sdep);
            Console.WriteLine("student id is :{0}", sid);
            Console.WriteLine("student name is :{0}", sname);
            Console.WriteLine("student department is:{0}",sdep);

        }
        public static void studentdetails(out int id, out string name, out string dep)
        {
            id = 11;
            name = "Kavya";
            dep = "CSE";
        }
        
      


    }
}
