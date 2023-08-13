using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vonglap_for
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int j = 0;
            //int n = 100;
            //for(int i = 0; i < n; i++, j+=1,Console.WriteLine("Day la @#:{0}",i))
            //{
            //    Console.WriteLine("---------------------------------");
            //    Console.WriteLine("i={0} | j={1} | j*i={2}",i,j,i*j);
            //}

            int N = 10;
            int M = 20;

            char drawChar = '*';
            char insideChar = ' ';


            // Vẽ từ trên xuống
            for (int i = 0; i < N; i++)
            {
                // Vẽ từ trái sang
                for (int j = 0; j < M; j++)
                {
                    /*
                     * Nếu đang ở tọa độ là cạnh trên hoặc dưới i % (N - 1) == 0
                     * hoặc đang ở cạnh trái hoặc phải (j % (M - 1) == 0)
                     * mà không nằm ở cạnh trên hoặc dưới (i % (N - 1) != 0)
                     * ((i % (N - 1) != 0) && (j % (M - 1) == 0))
                     * thì vẽ ra ký tự của hình chữ nhật
                     * ngược lại vẽ ra ký tự không thuộc hình chữ nhật
                    */

                    if (i == 0 || i == (N - 1) || j == 0 || j == (M - 1))
                    {
                        Console.Write(drawChar);    // lúc này là ký tự *
                    }
                    else
                    {
                        Console.Write(insideChar);  // lúc này là ký tự rỗng ' '
                    }
                }
            }
                Console.Write("");

            Console.ReadKey();
        }
    }
}
