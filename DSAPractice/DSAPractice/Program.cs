using DSAPractice.RecursionProblems;
using System;

namespace DSAPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //print name five times
            //PrintNameFiveTimes.PrintName("Vivek Bajpai");
            //PrintNameFiveTimes.PrintOneToN(10);
            //PrintNameFiveTimes.PrintNToOne(10);
            //PrintNameFiveTimes.PrintNtoOneBacktracking(1, 10);


            ////////Parameterized function recursion.
            //Console.WriteLine(ParameterizedRecursion.FindSumOfnNumbers(5));

            Console.WriteLine(ParameterizedRecursion.FindFactorialOfGivenNo(5));

            Console.ReadKey();
        }
    }
}
