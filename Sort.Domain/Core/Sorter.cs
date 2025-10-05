using Matheus.SortAlgorithms.Abstractions;
using System.Diagnostics;

namespace Matheus.SortAlgorithms.Core
{
    /// <summary>
    /// Provides functionality to sort a list of integers using a specified sorting algorithm and measures the execution time.
    /// </summary>
    public class Sorter : ISorter
    {
        /// <summary>
        /// Stopwatch used to measure the execution time of the sorting operation.
        /// </summary>
        private readonly Stopwatch _sw;

        /// <summary>
        /// The sorting algorithm to be used for sorting operations.
        /// </summary>
        private readonly ISortAlgorithm _sortAlgorithm;

        /// <summary>
        /// Initializes a new instance of the <see cref="Sorter"/> class using the specified sorting algorithm type.
        /// </summary>
        /// <param name="algorithm">The type of sorting algorithm to use.</param>
        public Sorter(SortAlgorithms algorithm)
        {
            _sw = new Stopwatch();
            _sortAlgorithm = SortFactory.Create(algorithm);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sorter"/> class using the provided sorting algorithm implementation.
        /// </summary>
        /// <param name="sortAlgorithm">The sorting algorithm implementation to use.</param>
        public Sorter(ISortAlgorithm sortAlgorithm)
        {
            _sw = new Stopwatch();
            _sortAlgorithm = sortAlgorithm;
        }

        /// <summary>
        /// Sorts the specified list of integers in ascending order, measures the execution time, and returns the result.
        /// </summary>
        /// <param name="numbers">The list of integers to sort.</param>
        /// <returns>
        /// An <see cref="ISortResult"/> containing the sorted list, operation status, and execution time in milliseconds.
        /// </returns>
        public ISortResult Sort(List<int> numbers)
        {
            _sw.Reset();
            _sw.Start();

            var result = _sortAlgorithm.Sort(numbers);

            _sw.Stop();
            result.ExecutionTimeMilliseconds = _sw.ElapsedMilliseconds;

            return result;
        }
    }
}
