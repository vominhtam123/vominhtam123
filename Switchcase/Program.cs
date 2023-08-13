using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //int k = 7;
            //switch (k)
            //{
            //    case 0:
            //        console.writeline("hello ae");
            //        break;
            //    case 3:
            //        console.writeline("ae phu yen mai dinh ^_^");
            //        break ;
            //    case 4:
            //        console.writeline("minh tam vo");
            //        break;
            //        default: console.writeline("khong the try cap");
            //        break;
            //}

            int Year;
            string Can = "", Chi = "";
            Console.WriteLine("Chương trình tính năm âm lịch từ năm dương lịch:");
            Year = Int32.Parse(Console.ReadLine());

            switch(Year % 10)
            {
                case 0:
                    Can = "Canh";
                    break;
                case 1:
                    Can = "Tân";
                    break ;
                case 2:
                    Can = "Nhm";
                    break;
                case 3:
                    Can = "Quý";
                    break;
                case 4:
                    Can = "Giáp";
                    break;
                case 5:
                    Can = "Ất";
                    break;
                case 6:
                    Can = "Bính";
                    break;
                case 7:
                    Can = "Đinh";
                    break;
                case 8:
                    Can = "Mậu";
                    break;
                case 9:
                    Can = "Kỳ";
                    break;


            }
            switch (Year % 12)
            {
                case 0:
                    Chi = "Thân";
                    break;
                case 1:
                    Chi = "Dậu";
                    break;

                case 2:
                    Chi = "Tuất";
                    break;
                case 3:
                    Chi = "Hợi";
                    break;
                case 4:
                    Chi = "Tý";
                    break;
                case 5:
                    Chi = "Sửu";
                    break;
                case 6:
                    Chi = "Dần";
                    break;
                case 7:
                    Chi = "Mẹo";
                    break;
                case 8:
                    Chi = "Thìn";
                    break;
                case 9:
                    Chi = "Tý";
                    break;
                case 10:
                    Chi = "Ngọ";
                    break;
                case 11:
                    Chi = "Mùi";
                    break;
            }
            Console.WriteLine("Năm {0} có năm âm lịch là : {1} {2}", Year, Can, Chi);
            Console.ReadLine();

        }
    }
}
