using System;
using System.Collections.Generic;

namespace GeneratorFibonacciNumbers
{
    public class GeneratorFibonacciNumbers
    {
        /// <summary>
        /// Generate the specified quantity.
        /// </summary>
        /// <returns>The generate.</returns>
        /// <param name="n">Quantity.</param>
        public static IEnumerable<int> Generate(int n)
        {
            if (n < 1) throw new ArgumentException($"{nameof(n)} is invalid!");

            int previous = -1;
            int next = 1;
            int temporary = 0;
            for (int i = 0; i < n; i++)
            {
                temporary = next;
                yield return next += previous;
                previous = temporary;
            }
        }

    }
}
