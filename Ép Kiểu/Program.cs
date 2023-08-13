using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ép_Kiểu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Đây là chương trình tính tổng hiệu tích thương ^_^");
            
            int A, B;
            int Tong, Hieu, Tich;
            float Thuong;
            string stA, stB;
            Console.WriteLine("Vui long nhap stA:");
            stA = Console.ReadLine();
            Console.WriteLine("Vui long nhap stB:");
            stB = Console.ReadLine();

            A = int.Parse(stA);
            B = int.Parse(stB);

            Tong = A + B;
            Hieu = A - B;
            Tich = A * B;
            Thuong = (float)A/B ;
            Console.WriteLine("Tong = "+Tong);
            Console.WriteLine("Hieu = "+Hieu);
            Console.WriteLine("Tich = "+Tich);
            Console.WriteLine("Thuong = "+Thuong);



            Console.ReadKey();

        }
    }
}
