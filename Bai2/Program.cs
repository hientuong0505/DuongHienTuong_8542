using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum=0;
            Console.WriteLine("Kiem tra so hoan hao");
            Console.WriteLine("--------------------");

            Console.WriteLine("Nhap mot so can kiem tra: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Cac uoc so duong cua so da cho: ");
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    Console.WriteLine("{0}  ", i);
                }
            }
            Console.WriteLine("Tong cua cac uoc so: {0}", sum);

            if (sum == n)
                Console.WriteLine("So da cho la so hoan hao.");
            else
                Console.WriteLine("So da cho khong phai la so hoan hao.");              

            Console.ReadLine();
        }
    }
}
