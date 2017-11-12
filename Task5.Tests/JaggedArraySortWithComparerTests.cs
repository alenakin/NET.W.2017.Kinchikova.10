using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task5.Comparers;

namespace Task5.Tests
{
    [TestFixture]
    public class JaggedArraySortWithComparerTests
    {
        #region Tests for method with IComparer
        [TestCaseSource(typeof(SourceForTestingJaggedArray), "SumASCCases")]
        public void BubbleSort_ComparerBySumASC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithComparer.BubbleSort(array, new BySumElementsASC());
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "SumDESCCases")]
        public void BubbleSort_ComparerBySumDESC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithComparer.BubbleSort(array, new BySumElementsDESC());
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "MinASCCases")]
        public void BubbleSort_ComparerByMinASC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithComparer.BubbleSort(array, new ByMinElementASC());
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "MinDESCCases")]
        public void BubbleSort_ComparerByMinDESC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithComparer.BubbleSort(array, new ByMinElementDESC());
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "MaxASCCases")]
        public void BubbleSort_ComparerByMaxASC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithComparer.BubbleSort(array, new ByMaxElementASC());
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "MaxDESCCases")]
        public void BubbleSort_ComparerByMaxDESC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithComparer.BubbleSort(array, new ByMaxElementDESC());
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "NullCases")]
        public void BubbleSort_JaggedArrayWithNullArray_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithComparer.BubbleSort(array, new BySumElementsASC());
            Assert.True(array.EqualTo(result));
        }

        [Test]
        public void BubbleSort_NullReferenceArray_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => JaggedArraySortWithComparer.BubbleSort(null, new ByMaxElementDESC()));
        }

        [Test]
        public void BubbleSort_NullReferenceComparer_ArgumentNullException()
        {
            ByMaxElementASC comparer = null;
            Assert.Throws<ArgumentNullException>(() => JaggedArraySortWithComparer.BubbleSort(new int[][] { }, comparer));
        }
        #endregion

        #region Tests for method with Comparison delegate 

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "SumASCCases")]
        public void BubbleSortDelegate_ComparerBySumASC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithComparer.BubbleSort(array, (x, y) => x.Sum().CompareTo(y.Sum()));
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "SumDESCCases")]
        public void BubbleSortDelegate_ComparerBySumDESC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithComparer.BubbleSort(array, (x, y) => -x.Sum().CompareTo(y.Sum()));
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "MinASCCases")]
        public void BubbleSortDelegate_ComparerByMinASC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithComparer.BubbleSort(array, (x, y) => x.Min().CompareTo(y.Min()));
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "MinDESCCases")]
        public void BubbleSortDelegate_ComparerByMinDESC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithComparer.BubbleSort(array, (x, y) => -x.Min().CompareTo(y.Min()));
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "MaxASCCases")]
        public void BubbleSortDelegate_ComparerByMaxASC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithComparer.BubbleSort(array, (x, y) => x.Max().CompareTo(y.Max()));
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "MaxDESCCases")]
        public void BubbleSortDelegate_ComparerByMaxDESC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithComparer.BubbleSort(array, (x, y) => -x.Max().CompareTo(y.Max()));
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "NullCases")]
        public void BubbleSortDelegate_JaggedArrayWithNullArray_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithComparer.BubbleSort(array, (x, y) => x.Sum().CompareTo(y.Sum()));
            Assert.True(array.EqualTo(result));
        }

        #endregion 
    }
}
