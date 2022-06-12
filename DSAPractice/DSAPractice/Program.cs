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

            //Console.WriteLine(ParameterizedRecursion.FindFactorialOfGivenNo(5));

            //Reverse the array using recursion.
            var arr = ReverseArray.ReverseArrayRecursion(new int[] { 10, 2, 34, 4, 5 }, 5);
            foreach (var item in arr)
            {
                Console.WriteLine(item);

            }


            Console.ReadKey();
        }
    }
}
