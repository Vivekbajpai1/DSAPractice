using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.RecursionProblems
{
    public static class ParameterizedRecursion
    {

        public static int FindSumOfnNumbers(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return n + FindSumOfnNumbers(n - 1);
        }

        public static int FindFactorialOfGivenNo(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * FindFactorialOfGivenNo(n - 1);
        }
    }
}
