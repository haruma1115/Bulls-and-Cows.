using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            int x = rnd.Next(1, 100);
            int y = 0;

            do
            {
                Console.WriteLine("請輸入1~100之間的整數");
                string guest = Console.ReadLine();
                y = Convert.ToInt32(guest);
                if (x == y) Console.WriteLine("猜對了");
                else 
                if (y > x) Console.WriteLine("太大了");
                else
                    if (y < x)Console.WriteLine("太小了");
             } while (x != y);
            Console.Read();
                                    
















            ///Random rnd = new Random();
            ///int[] x = new int[5];  ///陣列5個數
            ///for (int i = 0; i < 5; i++)
            ///{
            ///x[i] = rnd.Next(1,100);
            /// Console.WriteLine(x[i]);
            ///     }

            ///Console.Read();
        }
    }
}
