using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dt1, dt2, dt3;
            do{
                Console.WriteLine("整数入力");
                dt1 = int.Parse(Console.ReadLine());
            } while (dt1 < 1);
            dt3 = dt1;
            dt2 = 2;
            while (dt3 - dt2 >= 0)
            {
                if (dt1 % dt3 == 0) { Console.WriteLine("{0}",dt3);}
                dt3 = dt1 / dt2;
                dt2++;
            }
            while (0 != dt3)
            {
                if (dt1 == dt1 / dt3 * dt3) { Console.WriteLine("{0}",dt3);}
                dt3--;
            }
        }
    }
}
