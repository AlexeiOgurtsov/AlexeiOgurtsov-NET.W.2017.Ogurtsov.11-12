using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class Search
    {
        /// <summary>
        /// Search of element by binary search
        /// </summary>
        /// <typeparam name="T">Type of objects</typeparam>
        /// <param name="array">Sorted array of objects</param>
        /// <param name="value">Element to be searched</param>
        /// <param name="comparer">Logic of compearing elements</param>
        /// /// <exception cref="ArgumentNullException"> Array is null</exception>
        /// <returns>Index of element</returns>
        public static int BinarySearch<T>(T[] array, T value) => BinarySearch(array, value, null);
        
        /// <summary>
        /// Search of element by binary search
        /// </summary>
        /// <typeparam name="T">type of objects</typeparam>
        /// <param name="array">sorted array of objects</param>
        /// <param name="value">element to be searched</param>
        /// <param name="comparer">logic of compearing elements</param>
        /// /// <exception cref="ArgumentNullException"> arr is null</exception>
        /// <returns>index of element</returns>
        public static int BinarySearch<T>(T[] array, T value, Comparison<T> comparer)
        {
            if (array == null) throw new ArgumentNullException($"{nameof(array)} must not be null");
            if (array.Length == 0) return -1;

            if (comparer == null) comparer = Comparisions.Default;
            if (!CheckOrder(array, comparer)) throw new ArgumentException($"{nameof(array)} is not an ordered array");


            int left = 0;
            int right = array.Length;
            int middle = 0;

            while (left < right)
            {
                middle = left + (right - left) / 2;

                if (comparer(array[middle], value) == 0)
                    return middle;

                if (comparer(array[middle], value) > 0)
                    right = middle;
                else
                    left = middle + 1;
            }

            return -(1 + left);
        }

        /// <summary>
        /// Check Order
        /// </summary>
        /// <typeparam name="T">type of objects</typeparam>
        /// <param name="array">sorted array of objects</param>
        /// <param name="comparer">logic of compearing elements</param>
        /// <returns>true or false</returns>
        private static bool CheckOrder<T>(T[] array, Comparison<T> comparer)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (comparer(array[i], array[i + 1]) > 0) return false;
            }
            return true;
        }

    }
}
