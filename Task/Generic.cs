using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
   
    internal class Generic
    {
        public delegate T Samp_del<T>(T a);

        class AreaCal
        {
            ///<summary>
            ///Method for claculating area of different shape
            ///</summary>
            ///<param name="a"></param>
            public int Square(int a)
            {
                return a * a;
            }
            public int Cube(int a)
            {
                return (6 * a * a);
            }
            public int Circle(int a)
            {
                return (int)(3.14 * a * a);
            }
            ///<summary>
            ///Methods for double value for calculating different shapes
            ///</summary>
            ///<param name="a"></param>
            public double Square(double a)
            {
                return Math.Round((a*a),2);
            }
            public double Cube(double a)
            {
                return Math.Round((6 * a * a), 6);
            }
            public double Circle(double a)
            {
                return Math.Round((3.14 *a*a), 2);
            }
        }
        static void Main(string[] args)
        {
            AreaCal areaCal = new AreaCal();
            Samp_del<int> sd = new Samp_del<int>(areaCal.Square);
            Console.WriteLine("Area of Sqaure in int: " + sd(13));
            sd = areaCal.Cube;
            Console.WriteLine("Area of circle in int:" +sd(13));
            sd = areaCal.Circle;
            Console.WriteLine("Area of Circle in int:" + sd(13));
            Console.WriteLine("-----");
            Samp_del<double> sd1 = new Samp_del<double>(areaCal.Square);
            Console.WriteLine("Area of square in double:" + sd1(10.75));
            sd1= areaCal.Cube;
            Console.WriteLine("Area of Cube in double:" + sd1(10.75));
            sd1= areaCal.Circle;
            Console.WriteLine("Area of circle in double:" +sd1(10.75));
        }
    }
}
