using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // Khai baovaf khoi tao cung cap vung nho cho mang

            String[] Array = new string[4] {"Tam", "Van", "phat", "Diem"};
            for (int i = 0; i < 4; i++)
            {
                //Console.WriteLine("Ten SV[{0}]: {1} ", i, Array);
                Array[i] = Console.ReadLine();
               // Console.WriteLine(Array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                
                Console.WriteLine(Array[i]);
            }
            Console.ReadKey();

        }
    }
}
#endregion