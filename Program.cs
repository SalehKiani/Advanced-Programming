using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HW1_SalehKiani_972164024
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = new int();
            c = 1;
            functions functions1 = new functions();
            while (c != 0)
            {
                Console.Clear();
                Console.WriteLine("which one do you want?\n\n1.biggest number\n2.today's date\n0.Exit");
                c = Int32.Parse(Console.ReadLine());
                if (c == 1)
                {
                    Console.WriteLine("please enter your 10 numbers");
                    int[] a = new int[10];
                    for (int b = 0; b < 10; b++)
                    {
                        a[b] = Int32.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("\n\nthe biggest number is {0}", functions1.biggest(a));
                    Thread.Sleep(4000);
                }
                else if (c == 2)
                {
                    Console.WriteLine("\n\n\nToday is {0}", functions1.date());
                    Thread.Sleep(4000);
                }
            }
            if (c == 0)
            {
                Console.Clear();
                Console.ReadLine();
            }
        }
}
    class functions
    {
        public String date()
        {
            return DateTime.Now.ToString("d/M/yyyy");
           
        }


        public String biggest(int[] a)
        {
            int max = new int();
            max = 0;
            for (int b = 0; b < 10; b++)
            {
                if (a[b] > max)
                    max = a[b];
            }
            return max.ToString();
        }
    }
}
