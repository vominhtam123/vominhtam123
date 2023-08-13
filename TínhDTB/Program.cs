using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TínhDTB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            double Toanhk1, Toanhk2;
            double S;
            Console.WriteLine("Day la chuong trinh tinh diem tong ket cua moi mon");
            Console.WriteLine("Day la diem hk1:");
            Toanhk1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Day la diem hk2:");
            Toanhk2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Tong Diem Cuoi nam:");
            S = (double)(Toanhk1 + Toanhk2*2) / 3;
            Console.WriteLine("Diem tong cuoi nam la: {0}", S);


            Console.ReadKey();

        }
    }
}
