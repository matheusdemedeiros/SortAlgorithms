using Matheus.SortAlgorithms.Abstractions;
using Matheus.SortAlgorithms.Core;

namespace Matheus.SortAlgorithms.Algorithms
{
    /// <summary>
    /// Implementation of the BubbleSort sorting algorithm.
    /// </summary>
    internal class BubbleSort : ISortAlgorithm
    {
        /// <summary>
        /// Sorts a list of integers using the BubbleSort algorithm.
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
        /// Sorts the given list of integers using the Bubble Sort algorithm.
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

            bool swapped;
            int n = numbers.Count;

            do
            {
                swapped = false;

                for (int i = 0; i < n - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        swapped = true;
                    }
                }

                n--;

            } while (swapped);

            return numbers;
        }
    }
}
