using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class _2D_Matrix
    {
      static void Main(string[] args)
        {
            int i = 0;
            int j = 0;

            int row = 2;
            int col = 2;

            int[,] a = new int[3, 3];
            int[,] b = new int[3, 3];
            int[,] c= new int[3, 3];
            Console.WriteLine("Enter matrix 1 elements:");
            for(i = 0; i < row; i++)
                {
                for(j = 0; j < col; j++)
                {
                    a[i,j]= int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("Enter matrix 2 elements:");
            for(i = 0; i < row; i++)
            {
                for(j=0; j < col; j++)
                {
                    b[i,j]= int.Parse(Console.ReadLine());
                }
            }
            for(i = 0; i < row; i++)
            {
                for(j=0; j < col; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            Console.WriteLine("\n Matrix a:");
            for(i = 0; i < row; i++)
             {
               for( j = 0; j < col; j++)
                {
                  Console.Write(a[i, j] +"\t");
                }
                  Console.WriteLine();
                }
            Console.WriteLine("\nMatrix b:");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nAddition of 2 matrix:");
            for(i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
