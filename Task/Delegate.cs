using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Task;

namespace Task
{
    public delegate void Bank(string name, float i);
    public delegate void Bank1(string name, float i);
    public delegate void Bank2(string name, float i);
    public class Bank_details
    {
        public int p;
        public int t;
        public Bank_details()
        {
            Console.WriteLine("Enter the Principal Amount");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Time Period");
            t = Convert.ToInt32(Console.ReadLine());
        }

        public void GetSbi(string name, float i)
        {
            float simple_int = (i * p * t * 365) / 100;
            Console.WriteLine($"SBI Rate of intrest is: {i}%");
            Console.WriteLine($"Simple Intrest : Rs .{simple_int}/-");
        }
        public void GetHdfc(string name, float i)
        {
            float simple_int = (i * p * t * 365) / 100;
            Console.WriteLine($"HDFC Rate of intrest is: {i}%");
            Console.WriteLine($"Simple Intrest : Rs .{simple_int}/-");
        }
        public void GetKmb(string name, float i)
        {
            float simple_int = (i * p * t * 365) / 100;
            Console.WriteLine($"Kotak Rate of intrest is: {i}%");
            Console.WriteLine($"Simple Intrest : Rs .{simple_int}/-");
        }
        public void GetAxis(string name, float i)
        {
            float simple_int = (i * p * t * 365) / 100;
            Console.WriteLine($"Axix Rate of intrest is: {i}%");
            Console.WriteLine($"Simple Intrest : Rs .{simple_int}/-");
        }
        public void GetIcici(string name, float i)
        {
            float simple_int = (i * p * t * 365) / 100;
            Console.WriteLine($"ICICI Rate of intrest is: {i}%");
            Console.WriteLine($"Simple Intrest : Rs .{simple_int}/-");
        }
    }
    internal class Delegate
    {
        public static void Main()
        {
            Bank_details bank_Details = new Bank_details();
            Bank bank = bank_Details.GetSbi;
            bank("sbi", 2.70f);
            Bank1 bank1 = bank_Details.GetHdfc;
            bank1 += bank_Details.GetAxis;
            bank1 += bank_Details.GetIcici;
            bank1("Kotak", 3.25f);
            Bank2 bank2 = bank_Details.GetKmb;
            bank2("Mahindra", 3.50f);

        }
    }

}




