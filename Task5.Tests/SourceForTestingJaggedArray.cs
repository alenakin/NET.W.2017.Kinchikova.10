using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Tests
{
    internal class SourceForTestingJaggedArray
    {
        #region Testing arrays
        private static int[][] arr1 =
        {
            new int[] { 1, 3, 5, 7, 9 },
            new int[] { 25, 2, 4, 6 },
            new int[] { 11, 22 }
        };

        private static int[][] arr2 =
        {
            new int[] { -2, 3, -5, 0, 9 },
            new int[] { -1, 10, -10, 1 },
            new int[] { 20 },
            new int[] { -20 }
        };

        private static int[][] arr3 =
        {
            new int[] { 1, 3, 5, 7, 9 },
            new int[] { 25, 2, 4, 6 },
            null,
            new int[] { 11, 22 }
        };
        #endregion

        #region Expected results for testing arrays
        private static int[][] arr1SumASC =
        {
            new int[] { 1, 3, 5, 7, 9 },
            new int[] { 11, 22 },
            new int[] { 25, 2, 4, 6 },
        };

        private static int[][] arr1MaxASC =
        {
            new int[] { 1, 3, 5, 7, 9 },
            new int[] { 11, 22 },
            new int[] { 25, 2, 4, 6 },
        };

        private static int[][] arr1MinASC =
        {
            new int[] { 1, 3, 5, 7, 9 },
            new int[] { 25, 2, 4, 6 },
            new int[] { 11, 22 },
        };

        private static int[][] arr1SumDESC = Reverse(arr1SumASC), arr1MaxDESC = Reverse(arr1MaxASC),
           arr1MinDESC = Reverse(arr1MinASC);

        private static int[][] arr2SumASC =
        {
            new int[] { -20 },
            new int[] { -1, 10, -10, 1 },
            new int[] { -2, 3, -5, 0, 9 },
            new int[] { 20 },
        };

        private static int[][] arr2MaxASC =
        {
            new int[] { -20 },
            new int[] { -2, 3, -5, 0, 9 },
            new int[] { -1, 10, -10, 1 },
            new int[] { 20 },
        };

        private static int[][] arr2MinASC =
        {
            new int[] { -20 },
            new int[] { -1, 10, -10, 1 },
            new int[] { -2, 3, -5, 0, 9 },
            new int[] { 20 },
        };

        private static int[][] arr2SumDESC = Reverse(arr2SumASC), arr2MaxDESC = Reverse(arr2MaxASC),
            arr2MinDESC = Reverse(arr2MinASC);

        private static int[][] arr3SumASC =
        {
            null,
            new int[] { 1, 3, 5, 7, 9 },
            new int[] { 11, 22 },
            new int[] { 25, 2, 4, 6 },
        };

        #endregion

        #region Cases
        private static object[] sumASCCases =
        {
            new object[] { arr1, arr1SumASC },
            new object[] { arr2, arr2SumASC }
        };

        private static object[] sumDESCCases =
        {
            new object[] { arr1, arr1SumDESC },
            new object[] { arr2, arr2SumDESC }
        };

        private static object[] maxASCCases =
        {
            new object[] { arr1, arr1MaxASC },
            new object[] { arr2, arr2MaxASC }
        };

        private static object[] maxDESCCases =
        {
            new object[] { arr1, arr1MaxDESC },
            new object[] { arr2, arr2MaxDESC }
        };

        private static object[] minASCCases =
        {
            new object[] { arr1, arr1MinASC },
            new object[] { arr2, arr2MinASC }
        };

        private static object[] minDESCCases =
        {
            new object[] { arr1, arr1MinDESC },
            new object[] { arr2, arr2MinDESC }
        };

        private static object[] nullCases =
        {
            new object[] { arr3, arr3SumASC }
        };

        #endregion

        #region Help method
        private static int[][] Reverse(int[][] array)
        {
            int[][] result = new int[array.Length][];
            for (int i = array.Length - 1, j = 0; i >= 0; i--, j++)
            {
                result[j] = array[i];
            }

            return result;
        }
        #endregion
    }
}
