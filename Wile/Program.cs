using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            //int T=0;
            //int V=0;
            //int TT = 200;
            //int VV = 100;
            //int minRandomValue = 0;
            //int maxRandomValue = 100;

            //Random random = new Random();

            //while (T < VV)
            //{
            //    // reset bien V nay ve lai ban dau va viet lai
            //    V = 0;
            //    while (V < TT)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        int DN = random.Next(minRandomValue,maxRandomValue);
            //        Console.Write("{0,8}", DN);
            //        V++;
            //    }
            //    Console.WriteLine();
            //    T++;
            //}





            int doc = 10;
            int ngan = 40;
            int x = 0;
            int y = 0;

            while (x <= doc)
            {
                while (y <= ngan)
                {
                    if (x == 0 || x == doc || y == 0 || y == ngan)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    y++;
                }
                y = 0;
                Console.WriteLine();
                x++;
            }
            Console.ReadLine();
        }

    }
}
