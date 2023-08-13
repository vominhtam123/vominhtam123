using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài4Biến
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            int Kieusonguyen = 5;
            double Kieusothuc = 7.6;
            string  Kieuchuoi = "MinhTamVo-IT";
            bool Kieuluanli = false;
            char Kieukitu = 'T';



            //Console.WriteLine("So nguyên = {0}",Kieusonguyen);

            int ba = 9;
            int ma = 213;
            int na = ba + ma;
            Console.WriteLine("Ba + Ma = Na : {0} + {1} ={2}",ba,ma,na);

            Console.ReadKey();

        }
    }
}
