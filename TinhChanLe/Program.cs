using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhChanLe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Day la bai toan xac dinh so chan le")
            Console.WriteLine("Day la so a: ");
            int a =int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Day la so chan :", a);
            }
            else
            {
                Console.WriteLine("Day la so le :", a);
            }

            Console.ReadKey();
        }
    }
}
