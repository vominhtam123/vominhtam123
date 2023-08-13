using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CautrucHam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1; i++)
            {
                Dimaria();
            }
            Console.WriteLine(Smart());


            Console.WriteLine(Value());

            Console.WriteLine(Category(10,43));


            Console.Write("Ten cua ban la:");
            string T =Console.ReadLine();
            Console.Write("Tuoi: ");
            int age= int.Parse(Console.ReadLine());

            Work(T,age);

            Console.ReadKey();
        }
        static void Dimaria ()
        {
           
            Console.WriteLine("I love you");
        }

        static int Smart()
        {
            return 10;
        }
        static int Value1 = 5;
        static int Value2 = 6;

        static int Value()
        {
            return Value1* Value2;
        }



        // Parameter


        static int Category (int T1, int T2)
        {
            return T1 + T2;
        }

        static void Work(string T, int age)
        {
            if (age > 18)
            {
                Console.WriteLine("Ten cua ban :{0} Tuoi: {1}", T, age);
            }
            else
            {
                Console.WriteLine("Ban chua du tuoi");
            }
        }
    }
}
