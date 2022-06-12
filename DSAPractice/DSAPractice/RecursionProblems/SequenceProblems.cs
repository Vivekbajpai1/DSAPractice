using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.RecursionProblems
{
    public static class SequenceProblems
    {
        static int length;
        static int[] arr;
        static int sum;

        public static void FindAllTheSequenceInArray(int[] Arr, int Length)
        {
            length = Length;
            arr = Arr;
            PrintSequence(0, new List<int>());
        }

        private static void PrintSequence(int index, List<int> list)
        {
            if(index >= length)
            {
                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                return;
            }

            list.Add(arr[index]);
            PrintSequence(index + 1, list);
            list.Remove(arr[index]);
            PrintSequence(index + 1, list);
        }

        public static void FindAllSequenceWhereSumIsK(int[] Arr, int Length,int Sum)
        {
            arr = Arr;
            length = Length;
            sum = Sum;
            FindSequencesWhereSumIsK(0, new List<int>(), 0);
        }

        private static void FindSequencesWhereSumIsK(int index, List<int> list, int k)
        {
            if(index >= length)
            {
                if(sum == k)
                {
                    foreach (var item in list)
                    {
                        Console.Write(item+ " ");
                    }
                    Console.WriteLine();
                }
                return;
            }

            list.Add(arr[index]);
            k += arr[index];
            FindSequencesWhereSumIsK(index + 1, list, k);
            list.Remove(arr[index]);
            k -= arr[index];
            FindSequencesWhereSumIsK(index + 1, list, k);
        }

        public static void FindFirstSquenceWhereSumIsK(int[] Arr, int Length, int Sum)
        {
            arr = Arr;
            length = Length;
            sum = Sum;
            FindFirstSquenceWhereSumIsK(0, new List<int>(), 0);
        }

        private static bool FindFirstSquenceWhereSumIsK(int index, List<int> list, int k)
        {
            if(index >= length)
            {
                if(sum == k)
                {
                    foreach (var item in list)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                    return true;
                }
                return false;
            }

            list.Add(arr[index]);
            k += arr[index];
            if(FindFirstSquenceWhereSumIsK(index + 1, list, k))
            {
                return true;
            }

            list.Remove(arr[index]);
            k -= arr[index];

            if (FindFirstSquenceWhereSumIsK(index + 1, list, k))
            {
                return true;
            }

            return false;
        }
    }
}
