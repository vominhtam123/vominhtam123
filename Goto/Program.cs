using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // string VoMinhTamst = "VoMinhTam.com";
            int count = 0;
        Book_food:

            Console.WriteLine("VoMinhTam {0}",count);
            count++;
            if (count<10000)
            goto Book_food;
            Console.WriteLine("End Game");
            Console.ReadLine();
        }
    }
}
