using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài7Câuđiềukiệnifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Cau dieu kien dang thieu
            /*String K = "Kteam";
            if (K == "Kteam")
            {
                Console.WriteLine("Welcome to Kteam");
            }*/



            //Cau dieu kien dang du
            //String K = "6-05";
            //if (K == "Howkteam")
            //{
            //    Console.WriteLine("Welcome to Howkteam");

            //}
            //else if (K == "kteam")
            //{
            //    Console.WriteLine("Share to be Kteam");

            //}
            //else
            //{
            //    if (K == "6-05")
            //    {
            //        Console.WriteLine("Hello Word");
            //    }
            //    Console.WriteLine("Connecting Howkteam");
            //}

            //Bai tap giai phuong trinh ax +b = 0 cua toan tu 3 ngoi
            string strA, StrB;
            int A, B;
            Console.WriteLine("Nhập dữ liệu A:");
            strA = Console.ReadLine();
            Console.WriteLine("Nhập dữ liệu B:");
            StrB = Console.ReadLine();
            if (int.TryParse(strA, out A) == false || int.TryParse(StrB, out B) == false)
            {
                Console.WriteLine("sai du lieu");

            }
            else if (A == 0)
            {
                Console.WriteLine("Phuong trinh ban vua nhap la {0}x + {1} = 0",A,B);
                Console.WriteLine("VO so ngiem khi a = 0");

            }
            else if (B == 0)
            {
                Console.WriteLine("Phuong trinh ban vua nhap la {0}x + {1} = 0", A, B);
                Console.WriteLine("Co 1 nghiem duy nhat x = 0");
            }
            else
            {
                Console.WriteLine("Phuong trinh ban vua nhap la {0}x + {1} = 0", A, B);
                double x = (double) - B / A;
                Console.WriteLine("\n Phuong trinh cos nghiem la x = {0}", x);
            }
            Console.ReadKey();
        }
    }
}
