using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.RecursionProblems
{
    public static class ReverseArray
    {
        static int[] arr;
        static int length;

        public static int[] ReverseArrayRecursion(int[] Arr, int Length)
        {
            arr = Arr;
            length = Length;
            Reverse(0);
            return arr;
        }

        static void Reverse(int n)
        {
            if (n >= length/2)
                return;
            swap(n, length-n-1);
            Reverse(n+1);
        }

        private static void swap(int v1, int v2)
        {
            int temp = arr[v1];
            arr[v1] = arr[v2];
            arr[v2] = temp;
        }
    }
}
