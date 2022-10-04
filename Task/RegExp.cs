using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task
{
    internal class RegExp
    {
        public static void Main()
        {
            mobile();
        }
        public static void mobile()
        {
            Console.WriteLine("mobile validation");
            Console.WriteLine("Enter mobile number:");
            //string mobile = "1234-456-8900";
            var mobile = (Console.ReadLine());
            var validate_mobile = Regex.IsMatch(mobile, @"^[987]\d{9}$");
            Console.WriteLine(validate_mobile);


        }
    }
}
