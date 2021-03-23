using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bang cuu chuong tu 2->9");
            Console.WriteLine("--------------------------");
            for (int i = 2; i <= 9; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    Console.WriteLine("{0}*{1} = {2}", i, j, i * j);
                }
                Console.WriteLine("--------------------------");
            }

            Console.ReadLine();
        }
    }
}
