using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_SalehKiani_972164024
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your 10 numbers");
            int a = new int();
            int max=new int();
            max = 0;
            for(int b=0;b<10;b++)
            {
                a = Int32.Parse(Console.ReadLine());
                if (a > max)
                    max = a;
            }
            Console.WriteLine("The Biggest Number is {0}",Convert.ToString(max));
            Console.ReadLine();
        }
    }
}
