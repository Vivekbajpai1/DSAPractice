using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.RecursionProblems
{
    public static  class PrintNameFiveTimes
    {
        static int count = 5;
        static string name;
        static int no = 0;
        public static void  PrintName(string Name)
        {
            name = Name;
            PrintFiveTimes();
        }

        static void PrintFiveTimes()
        {
            if(count>0)
            {
                Console.WriteLine(name);
                count--;
                PrintFiveTimes();
            }
            else
            {
                return;
            }
        }

        public static void PrintOneToN(int n)
        {
            if (no<n)
            {
                no++;
                Console.WriteLine(no);
                PrintOneToN(n);
                
            }
        }
        public static void PrintNToOne(int n)
        {
            if (n>0)
            {
                Console.WriteLine(n);
                n--;
                PrintNToOne(n);

            }
        }

        public static void PrintNtoOneBacktracking(int i, int n)
        {
            if (i > n)
            {
                return;
            }

            PrintNtoOneBacktracking(i + 1, n);
            Console.WriteLine(i);
        }


    }
}
