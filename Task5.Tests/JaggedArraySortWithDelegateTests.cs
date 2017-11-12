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
    public class JaggedArraySortWithDelegateTests
    {
        #region Tests for method with IComparer
        [TestCaseSource(typeof(SourceForTestingJaggedArray), "sumASCCases")]
        public void BubbleSort_ComparerBySumASC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithDelegate.BubbleSort(array, new BySumElementsASC());
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "sumDESCCases")]
        public void BubbleSort_ComparerBySumDESC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithDelegate.BubbleSort(array, new BySumElementsDESC());
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "minASCCases")]
        public void BubbleSort_ComparerByMinASC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithDelegate.BubbleSort(array, new ByMinElementASC());
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "minDESCCases")]
        public void BubbleSort_ComparerByMinDESC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithDelegate.BubbleSort(array, new ByMinElementDESC());
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "maxASCCases")]
        public void BubbleSort_ComparerByMaxASC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithDelegate.BubbleSort(array, new ByMaxElementASC());
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "maxDESCCases")]
        public void BubbleSort_ComparerByMaxDESC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithDelegate.BubbleSort(array, new ByMaxElementDESC());
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "nullCases")]
        public void BubbleSort_JaggedArrayWithNullArray_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithDelegate.BubbleSort(array, new BySumElementsASC());
            Assert.True(array.EqualTo(result));
        }

        [Test]
        public void BubbleSort_NullReferenceArray_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => JaggedArraySortWithDelegate.BubbleSort(null, new ByMaxElementDESC()));
        }

        [Test]
        public void BubbleSort_NullReferenceComparer_ArgumentNullException()
        {
            ByMaxElementASC comparer = null;
            Assert.Throws<ArgumentNullException>(() => JaggedArraySortWithDelegate.BubbleSort(new int[][] { }, comparer));
        }
        #endregion

        #region Tests for method with Comparison delegate 

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "sumASCCases")]
        public void BubbleSortDelegate_ComparerBySumASC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithDelegate.BubbleSort(array, (x, y) => x.Sum().CompareTo(y.Sum()));
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "sumDESCCases")]
        public void BubbleSortDelegate_ComparerBySumDESC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithDelegate.BubbleSort(array, (x, y) => -x.Sum().CompareTo(y.Sum()));
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "minASCCases")]
        public void BubbleSortDelegate_ComparerByMinASC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithDelegate.BubbleSort(array, (x, y) => x.Min().CompareTo(y.Min()));
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "minDESCCases")]
        public void BubbleSortDelegate_ComparerByMinDESC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithDelegate.BubbleSort(array, (x, y) => -x.Min().CompareTo(y.Min()));
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "maxASCCases")]
        public void BubbleSortDelegate_ComparerByMaxASC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithDelegate.BubbleSort(array, (x, y) => x.Max().CompareTo(y.Max()));
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "maxDESCCases")]
        public void BubbleSortDelegate_ComparerByMaxDESC_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithDelegate.BubbleSort(array, (x, y) => -x.Max().CompareTo(y.Max()));
            Assert.True(array.EqualTo(result));
        }

        [TestCaseSource(typeof(SourceForTestingJaggedArray), "nullCases")]
        public void BubbleSortDelegate_JaggedArrayWithNullArray_EqualToResult(int[][] array, int[][] result)
        {
            JaggedArraySortWithDelegate.BubbleSort(array, (x, y) => x.Sum().CompareTo(y.Sum()));
            Assert.True(array.EqualTo(result));
        }

        #endregion 
    }
}
