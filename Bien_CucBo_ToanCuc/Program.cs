using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bien_CucBo_ToanCuc
{
    internal class Program
    {
        //Bien toan cuc
        static int value = 12;
        static void Main(string[] args)
        {
            //Bien cuc bo
            Console.WriteLine(value);
            value = 15;

            Review();

            Console.ReadLine();
        }
        static void Review()
        {
            value = 123;
            Console.WriteLine(value);
        }


        
    }
}
