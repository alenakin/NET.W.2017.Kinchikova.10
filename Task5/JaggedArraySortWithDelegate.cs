﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /// <summary>
    /// JaggedArraySort class contains method for sorting jagged arrays.
    /// Realisation using delegate
    /// </summary>
    public class JaggedArraySortWithDelegate
    {
        #region Public methods
        /// <summary>
        /// Sorts a jagged array using a bubble sort, according to a specified criteria. Uses comparer
        /// </summary>
        /// <param name="array">Jagged array to sort</param>
        /// <param name="comparer">The criterion by which the sorting will occur</param>
        /// <exception cref="ArgumentNullException">array or comparer is null</exception>
        public static void BubbleSort(int[][] array, IComparer<int[]> comparer)
        {
            if (comparer == null)
            {
                throw new ArgumentNullException();
            }

            BubbleSort(array, comparer.Compare);
        }

        /// <summary>
        /// Sorts a jagged array using a bubble sort, according to a specified criteria. Uses delegate
        /// </summary>
        /// <param name="array">Jagged array to sort</param>
        /// <param name="comparison">The criterion by which the sorting will occur</param>
        /// <exception cref="ArgumentNullException">array or comparison is null</exception>
        public static void BubbleSort(int[][] array, Comparison<int[]> comparison)
        {
            if (array == null || comparison == null)
            {
                throw new ArgumentNullException();
            }

            bool swapped;
            for (int i = 0; i < array.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] == null)
                    {
                        continue;
                    }

                    if (array[j + 1] == null
                        || comparison(array[j], array[j + 1]) == 1)
                    {
                        SwapArrays(ref array[j], ref array[j + 1]);
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }
        #endregion

        #region Private methods
        private static void SwapArrays(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
        #endregion 
    }
}
