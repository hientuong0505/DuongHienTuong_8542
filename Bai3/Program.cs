using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, daoNghich = 0, temp;
            Console.WriteLine("Nhap so n can dao: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                temp = n % 10;
                daoNghich = daoNghich * 10 + temp;
                n /= 10;
            }
            Console.WriteLine("So dao cua so n: " + daoNghich);
            Console.ReadLine();
        }
    }
}
