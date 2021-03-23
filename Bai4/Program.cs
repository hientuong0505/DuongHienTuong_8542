using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            double danSo = 5000000;
            double tyLe = 0.02;

            Console.WriteLine("Nhap so dan can tinh sau N nam: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1;i<=n;i++)
            {
                danSo = danSo + danSo*tyLe;
            }
            Console.WriteLine("Tong dan so can tim: {0}", danSo);
            Console.ReadLine();
        }
    }
}
