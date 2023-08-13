using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDLobjectandvar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            object obj = "Howkteam";
            Console.WriteLine(obj);

            //cach su dungj boxing and unboxing

            int value = 123;
            object objvalue = value;
            int newvalue = (int)objvalue;
            Console.WriteLine(newvalue);

            //Cach su dung var
            //var là khởi tạo ngay sau khi khai báo biến không phải là 1 kdl

            var varint = "123";
            int a = 123;
            Console.WriteLine(a);
            Console.WriteLine(varint);



            Console.ReadKey();
        }
    }
}
