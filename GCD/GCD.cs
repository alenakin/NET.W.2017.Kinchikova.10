using System;
using System.Diagnostics;

namespace Logic
{
    /// <summary>
    /// GCD class provides metods for calculating GCD
    /// </summary>
    public class GCD
    {
        private delegate int Algorithm(int a, int b);

        #region Public methods

        #region EuclideanGCD method
        /// <summary>
        /// Calculates GCD using Euclidean algorithm
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="time">Time spent on calculating</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns>GCD of a and b</returns>
        public static int EuclideanGCD(out long time, int a, int b)
        {
            return CalculateGCD(out time, EuclideanAlgorithm, a, b);
        }
        #endregion

        #region Overloadiongs for EuclideanGCD

        /// <summary>
        /// Calculates GCD using Euclidean algorithm
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns>GCD of a and b</returns>
        public static int EuclideanGCD(int a, int b)
        {
            return EuclideanGCD(out _, a, b);
        }

        /// <summary>
        /// Calculates GCD using Euclidean algorithm
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third param</param>
        /// <param name="time">Time spent on calculating</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns>GCD of a, b and c</returns>
        public static int EuclideanGCD(out long time, int a, int b, int c)
        {
            return CalculateGCD(out time, EuclideanAlgorithm, a, b, c);
        }

        /// <summary>
        /// Calculates GCD using Euclidean algorithm
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third param</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns>GCD of a, b and c</returns>
        public static int EuclideanGCD(int a, int b, int c)
        {
            return EuclideanGCD(out _, a, b, c);
        }

        /// <summary>
        /// Calculates GCD using Euclidean algorithm
        /// </summary>
        /// <param name="time">Time spent on calculating</param>
        /// <param name="numbers">Numbers for which calculate gcd</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns>GCD of numbers</returns>
        public static int EuclideanGCD(out long time, params int[] numbers)
        {
            return CalculateGCD(out time, EuclideanGCD, numbers);
        }

        /// <summary>
        /// Calculates GCD using Euclidean algorithm
        /// </summary>
        /// <param name="numbers">Numbers for which calculate gcd</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns>GCD of numbers</returns>
        public static int EuclideanGCD(params int[] numbers)
        {
            return EuclideanGCD(out _, numbers);
        }
        #endregion

        #region BinaryEuclideanGCD method
        /// <summary>
        /// Calculates GCD using binary Eucidean algorithm 
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="time">Time spent on calculating</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns>GCD(a, b)</returns>
        public static int BinaryEuclideanGCD(out long time, int a, int b)
        {
            return CalculateGCD(out time, BinaryAlgorithm, a, b);
        }
        #endregion

        #region Overloading for BinaryEuclideanGCD

        /// <summary>
        /// Calculates GCD using bunary Euclidean algorithm
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns>GCD of a and b</returns>
        public static int BinaryEuclideanGCD(int a, int b)
        {
            return BinaryEuclideanGCD(out _, a, b);
        }

        /// <summary>
        /// Calculates GCD using binary Euclidean algorithm
        /// </summary>
        /// <param name="time">Time spent on calculating</param>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third param</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns>GCD of a, b and c</returns>
        public static int BinaryEuclideanGCD(out long time, int a, int b, int c)
        {
            return CalculateGCD(out time, BinaryAlgorithm, a, b, c);
        }

        /// <summary>
        /// Calculates GCD using binary Euclidean algorithm
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third param</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns>GCD of a, b and c</returns>
        public static int BinaryEuclideanGCD(int a, int b, int c)
        {
            return BinaryEuclideanGCD(out _, a, b, c);
        }

        /// <summary>
        /// Calculates GCD using binary Euclidean algorithm
        /// </summary>
        /// <param name="time">Time spent on calculating</param>
        /// <param name="numbers">Numbers for which calculate gcd</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns>GCD of numbers</returns>
        public static int BinaryEuclideanGCD(out long time, params int[] numbers)
        {
            return CalculateGCD(out time, BinaryEuclideanGCD, numbers);
        }

        /// <summary>
        /// Calculates GCD using binary Euclidean algorithm
        /// </summary>
        /// <param name="numbers">Numbers for which calculate gcd</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns>GCD of numbers</returns>
        public static int BinaryEuclideanGCD(params int[] numbers)
        {
            return BinaryEuclideanGCD(out _, numbers);
        }
        #endregion

        #endregion

        #region Private methods

        #region Algorithms
        private static int EuclideanAlgorithm(int a, int b)
        {
            int r = a % b;
            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }

            return b;
        }

        private static int BinaryAlgorithm(int a, int b)
        {
            int k;
            for (k = 0; ((a | b) & 1) == 0; k++)
            {
                a >>= 1;
                b >>= 1;
            }

            while ((a & 1) == 0)
            {
                a >>= 1;
            }

            while ((b & 1) == 0)
            {
                b >>= 1;
            }

            while (a > 0)
            {
                int t = Math.Abs(a - b) / 2;
                if (a < b)
                {
                    b = t;
                }
                else
                {
                    a = t;
                }
            }

            return b << k;
        }
        #endregion

        #region CalculateGCD method's overloadings
        private static int CalculateGCD(out long time, Algorithm algorithm, int a, int b)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            time = 0;
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("GCD(0,0) can't be calculated");
            }

            if (a == 0)
            {
                return b;
            }

            if (b == 0)
            {
                return a;
            }

            if (a == b)
            {
                return a;
            }

            FindMaxAndMin(ref a, ref b);

            int res = algorithm(a, b);
            s.Stop();
            time = s.ElapsedMilliseconds;
            return res;
        }

        private static int CalculateGCD(out long time, Algorithm algorithm, int a, int b, int c)
        {
            int gcd = algorithm(a, b);
            return CalculateGCD(out time, algorithm, gcd, c);
        }

        private static int CalculateGCD(out long time, Algorithm algorithm, params int[] numbers)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            time = 0;
            if (numbers.Length < 2)
            {
                throw new ArgumentException("Must be 2 or more numbers");
            }

            int gcd = algorithm(numbers[0], numbers[1]);
            for (int i = 2; i < numbers.Length; i++)
            {
                gcd = algorithm(gcd, numbers[i]);
            }

            s.Stop();
            time = s.ElapsedMilliseconds;
            return gcd;
        }
        #endregion

        private static void FindMaxAndMin(ref int a, ref int b)
        {
            int a1 = Math.Abs(a);
            int b1 = Math.Abs(b);
            a = Math.Max(a1, b1);
            b = Math.Min(a1, b1);
        }

        #endregion
    }
}
