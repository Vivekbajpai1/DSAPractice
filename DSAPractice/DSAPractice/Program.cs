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
            //var arr = ReverseArray.ReverseArrayRecursion(new int[] { 10, 2, 34, 4, 5 }, 5);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);

            //}

            //check array is palindrome
            //Console.WriteLine(ReverseArray.CheckPalindrome("NAMANA", 6));


            //Problem: Get the Nth fabonacci no via recursion
            //Console.WriteLine(ReverseArray.FindNthFabonacciNo(5));

            //Problems: On Sequences
            //Problem-1: Find all the sequences of an array
            //SequenceProblems.FindAllTheSequenceInArray(new int[] { 3, 2, 1 }, 3);

            //Problem-2: Find all the sequences whose sum is k
            //SequenceProblems.FindAllSequenceWhereSumIsK(new int[] { 3, 2, 1 }, 3, 3);

            //Problem-3: Find  the first sequences whose sum is k
            SequenceProblems.FindFirstSquenceWhereSumIsK(new int[] { 3, 2, 1 }, 3, 3);

            Console.ReadKey();
        }
    }
}
