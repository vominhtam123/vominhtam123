using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 7;

            Console.WriteLine("Gia tri ban dau la: {0}",value);
            New(out value);
            Console.WriteLine("Gia tri sau la: {0}", value);

            Console.ReadKey();

        }
        static void New( out int value)
        {
            value = 10;
            value++;
        }
    }
}
