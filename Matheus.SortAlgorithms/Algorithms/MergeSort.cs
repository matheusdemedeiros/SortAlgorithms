using Matheus.SortAlgorithms.Abstractions;
using Matheus.SortAlgorithms.Core;

namespace Matheus.SortAlgorithms.Algorithms
{
    /// <summary>
    /// Implementation of the MergeSort sorting algorithm.
    /// </summary>
    internal class MergeSort : ISortAlgorithm
    {
        /// <summary>
        /// Sorts a list of integers using the MergeSort algorithm.
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
        /// Recursively sorts a list of integers using MergeSort.
        /// </summary>
        /// <param name="numbers">The list of integers to be sorted.</param>
        /// <returns>A new sorted list.</returns>
        private List<int>? Process(List<int> numbers)
        {
            var n = numbers.Count;
            if (n == 0) return numbers;
            if (n == 1) return numbers;

            ApplyMergeSort(numbers, 0, n -1);
            return numbers;
        }

        /// <summary>
        /// Recursively sorts a section of the list using the MergeSort algorithm.
        /// Divides the list into halves, sorts each half, and merges them.
        /// </summary>
        /// <param name="numbers">The list of integers to be sorted.</param>
        /// <param name="begin">The starting index of the section to sort.</param>
        /// <param name="end">The ending index of the section to sort.</param>
        private void ApplyMergeSort(List<int> numbers, int begin = 0, int end = 0)
        {
            if (begin < end)
            {
                int middle = (begin + end) / 2;
                ApplyMergeSort(numbers, begin, middle);
                ApplyMergeSort(numbers, middle + 1, end);
                Merge(numbers, begin, middle, end);

            }
        }

        /// <summary>
        /// Merges two sorted halves of the list into a single sorted section.
        /// </summary>
        /// <param name="numbers">The list containing the sections to merge.</param>
        /// <param name="begin">The starting index of the first half.</param>
        /// <param name="middle">The ending index of the first half (middle of the section).</param>
        /// <param name="end">The ending index of the second half.</param>
        private void Merge(List<int> numbers, int begin, int middle, int end)
        {
            var left = numbers.GetRange(begin, middle - begin + 1);
            var right = numbers.GetRange(middle + 1, end - middle);

            int topLeft = 0, topRight = 0;

            for (var i = begin; i <= end; i++)
            {
                if (topLeft >= left.Count)
                {
                    numbers[i] = right[topRight];
                    topRight++;
                }
                else if (topRight >= right.Count)
                {
                    numbers[i] = left[topLeft];
                    topLeft++;
                }
                else if (left[topLeft] <= right[topRight])
                {
                    numbers[i] = left[topLeft];
                    topLeft++;
                }
                else
                {
                    numbers[i] = right[topRight];
                    topRight++;
                }
            }
        }
    }
}
