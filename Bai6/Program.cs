using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int soAm = 0, soDuong = 0, soKhong = 0;
            Console.WriteLine("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", (i + 1));
                a[i] = int.Parse(Console.ReadLine());
            }

            foreach(int item in a)
            {
                if(item > 0)
                {
                    soDuong++;
                }
            }

            Console.WriteLine("Cac so Duong co trong mang: {0}", soDuong);
            foreach (int item in a)
            {
                if (item < 0)
                {
                    soAm++;
                }
            }

            Console.WriteLine("Cac so Am co trong mang: {0}", soAm);
            foreach (int item in a)
            {
                if (item == 0)
                {
                    soKhong++;
                }
            }
            Console.WriteLine("Cac so 0 co trong mang: {0}", soKhong);

            Console.ReadLine();
        }
    }
}
