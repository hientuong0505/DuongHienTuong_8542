using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0;
            Console.WriteLine("Nhap so N: ");
            n = int.Parse(Console.ReadLine());
            int temp = n;

            while(temp != 0)
            {
                sum += temp % 10;
                temp /= 10;
            }
            Console.WriteLine("Tong cac chu so: {0}",sum);
            Console.ReadLine();
        }
    }
}
