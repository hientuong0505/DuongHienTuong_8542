using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            int h;
            Console.WriteLine("Nhap chieu cao h: "); 
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");
            for (int i = 1; i <= h; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine("-------------------");
            for (int i = 1; i <= h; i++)
            {
                for (int j = i; j < h; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-------------------");
            for(int i = 1; i <= h; i++)
            {
                for(int j = 1; j <= h; j++)
                {
                    if(i==1 || i == h)
                    {
                        Console.Write("*");
                    } else if(j == 1 || j == h)
                    {
                        Console.Write("*");
                    } else Console.Write(" ");
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
