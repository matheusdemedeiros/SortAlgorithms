using Sort.Domain.Algorithms.Abstractions;
using Sort.Domain.Algorithms.Shared;

namespace Sort.Domain.Algorithms.HeapSort
{
    /// <summary>
    /// Implementation of the HeapSort sorting algorithm.
    /// </summary>
    public class HeapSortAlgorithm : ISortAlgorithm
    {
        /// <summary>
        /// Sorts a list of integers using the HeapSort algorithm.
        /// </summary>
        /// <param name="numbers">The list of integers to be sorted.</param>
        /// <returns>
        /// A <see cref="SortResult"/> containing the sorted list and the operation status.
        /// </returns>
        public SortResult Sort(List<int> numbers)
        {
            var sorted = new SortResult();
            sorted.SortedList = Process(numbers);
            sorted.Success = sorted.SortedList != null && sorted.SortedList.Any();

            return sorted;
        }

        private List<int>? Process(List<int> numbers)
        {
            return null;
        }
    }
}
