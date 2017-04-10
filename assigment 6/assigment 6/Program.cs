using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assigment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            for (int  i = a; a <= b; a++) {
                if (a % 2 != 0) {
                    c = c + a;
                    if (a >= b)
                    {
                        Console.WriteLine(a);
                        Console.WriteLine("the sum is ");
                        Console.WriteLine(c);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(a);
                       // Console.ReadLine();
                    }
                }
              
            }
        }
    }
}
