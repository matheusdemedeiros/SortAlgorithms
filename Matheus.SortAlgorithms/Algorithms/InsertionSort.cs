using Matheus.SortAlgorithms.Abstractions;
using Matheus.SortAlgorithms.Core;

namespace Matheus.SortAlgorithms.Algorithms
{
    /// <summary>
    /// Implementation of the InsertionSort sorting algorithm.
    /// </summary>
    internal class InsertionSort : ISortAlgorithm
    {
        /// <summary>
        /// Sorts a list of integers using the InsertionSort algorithm.
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
        /// Sorts the given list of integers using the Insertion Sort algorithm.
        /// </summary>
        /// <param name="numbers">The list of integers to be processed.</param>
        /// <returns>
        /// A list sorted. 
        /// Returns <c>null</c> if the list is empty, and returns the original list if it contains only one element.
        /// </returns>
        private List<int>? Process(List<int> numbers)
        {
            if (numbers == null || numbers.Count <= 1)
                return numbers;

            for (int i = 1; i < numbers.Count; i++)
            {
                int key = numbers[i];
                int j = i - 1;

                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }

                numbers[j + 1] = key;
            }

            return numbers;
        }
    }
}
