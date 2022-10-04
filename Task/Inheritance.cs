using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Bonus
    {
        protected int bonus;
    }
    public class staff : Bonus
    {
        protected int salary = 6000;
        protected void Getbonus1()
        {
            Console.WriteLine($"Bonus of Staff with Salary {salary} is : ");
            bonus = 3 * salary;
            Console.WriteLine(bonus);

        }
    }
    public class Nonstaff : staff
    {
        protected int salary = 3000;
        public void Getbonus2()
        {

            Console.WriteLine($"Bonus of NonStaff with Salary {salary} is : ");
            bonus = 2 * salary;
            Console.WriteLine(bonus);
            Getbonus1();

        }

    }

    internal class Inheritanc
    {
        public static void Main()
        {
            staff s = new staff();
            //s.Getbonus1();

            Nonstaff n = new Nonstaff();
            n.Getbonus2();
        }
    }
}
