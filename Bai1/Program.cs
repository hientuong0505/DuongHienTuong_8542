using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongHienTuong_8542
{
    class Program
    {
        static void Main(string[] args)
        {
            //Duong Hien Tuong
            //2421208542
            //CS 414 DIS


            int n;
            //Tong cac so tu nhien N
            int sum = 0;
            Console.WriteLine("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                sum += i;
            }
            Console.WriteLine("Tong cac so nho hon N: {0}",sum);

            //Tong cac so tu nhien le N
            int sum1 = 0;
            for(int i=0;i<n;i++)
            {
                if(i%2 != 0)
                {
                    sum1 += i;
                }
            }
            Console.WriteLine("Tong cac so nho hon N: {0}", sum1);
            
            //Tong cac so chan N
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    sum2 += i;
                }
            }
            Console.WriteLine("Tong cac so nho hon N: {0}", sum2);
            Console.ReadLine();
        }
    }
}
