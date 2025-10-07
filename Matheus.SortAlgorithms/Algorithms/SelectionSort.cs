using Matheus.SortAlgorithms.Abstractions;
using Matheus.SortAlgorithms.Core;

namespace Matheus.SortAlgorithms.Algorithms
{
    /// <summary>
    /// Implementation of the SelectionSort sorting algorithm.
    /// </summary>
    internal class SelectionSort : ISortAlgorithm
    {
        /// <summary>
        /// Sorts a list of integers using the SelectionSort algorithm.
        /// </summary>
        /// <param name="numbers">The list of integers to be sorted.</param>
        /// <returns>
        /// A <see cref="SortResult"/> containing the sorted list and the operation status.
        /// </returns>
        public ISortResult Sort(List<int> numbers)
        {
            var sorted = new SortResult();
            sorted.SortedList = Process(numbers);
            sorted.Success = sorted.SortedList != null && sorted.SortedList.Any();

            return sorted;
        }

        /// <summary>
        /// Sorts a list of integers in ascending order using the Selection Sort algorithm.
        /// </summary>
        /// <param name="numbers">The list of integers to be sorted.</param>
        /// <returns>The sorted list, or null if the input list is null or empty.</returns>
        private List<int>? Process(List<int> numbers)
        {
            if (numbers == null || numbers.Count <= 1)
                return numbers;

            for(var i = 0; i< numbers.Count; i++)
            {
                var smallIndex = FindSmallIndex(numbers.GetRange(i, numbers.Count - i)) + i;
                if(smallIndex != i)
                {
                    var temp = numbers[i];
                    numbers[i] = numbers[smallIndex];
                    numbers[smallIndex] = temp;
                }
            }   

            return numbers;
        }

        /// Finds the index of the smallest element in a list of integers.
        /// </summary>
        /// <param name="numbers">The list of integers to search.</param>
        /// <returns>The index of the smallest element in the list.</returns>
        private int FindSmallIndex(List<int> numbers)
        {
            var smallIndex = 0;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < numbers[smallIndex])
                {
                    smallIndex = i;
                }
            }

            return smallIndex;
        }
    }
}
