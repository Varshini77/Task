using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Exp
    {
        public void Multicatch()
        {
            int[] array1 = { 1, 9, 8, 5, 3 };
            int[] array2 = { 5, 5, 6, 2, 1 };
            for (int i = 0; i < array1.Length; i++)
            {
                try
                {
                    Console.WriteLine(array1[i] / array2[i]);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

    }
    public class Prop
    {
        float ans;
        public void Calcu( int a, int b)
        {
            try
            {
                ans = a / b;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("---Display Properties of exceptions---");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Data);
                Console.WriteLine(e.TargetSite);
            }
            finally
            {
                Console.WriteLine("Proceed");
            }
        }
    }
    
    internal class mullti_catch
    {
        public static void Main()
        {
            Exp ex = new Exp();
            ex.Multicatch();

            Prop prop = new Prop();
            prop.Calcu(1, 0);
        }
    }
}
