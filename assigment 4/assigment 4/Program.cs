using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assigment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int  a, b =0;
            
            a = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= a; i++)
if (i % 2 != 0)
{

    b = b + i;
    if (i == a)
    {

        Console.WriteLine(i);
        Console.WriteLine("the sum of all odd numbers are below");
        Console.WriteLine( b);
    }
    else
    {
        Console.WriteLine(i);
    }

}
Console.ReadLine();
}

        
    }
}   