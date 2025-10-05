using Matheus.SortAlgorithms.Abstractions;
using Matheus.SortAlgorithms.Core;

namespace Matheus.SortAlgorithms.Algorithms
{
    /// <summary>
    /// Implementation of the HeapSort sorting algorithm.
    /// </summary>
    public class HeapSort : ISortAlgorithm
    {
        /// <summary>
        /// Sorts a list of integers using the HeapSort algorithm.
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
        /// Sorts the given list of integers using the Heap Sort algorithm.
        /// </summary>
        /// <param name="numbers">The list of integers to be processed.</param>
        /// <returns>
        /// A list sorted. 
        /// Returns <c>null</c> if the list is empty, and returns the original list if it contains only one element.
        /// </returns>
        private List<int>? Process(List<int> numbers)
        {
            var n = numbers.Count;
            if (n == 0) return null;
            if (n == 1) return numbers;

            for (var i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(numbers, n, i);
            }

            for (var i = n - 1; i >= 0; i--)
            {
                var temp = numbers[0];
                numbers[0] = numbers[i];
                numbers[i] = temp;
                Heapify(numbers, i, 0);
            }

            return numbers;
        }

        /// <summary>
        /// Ensures the max-heap property for a specific node in a list.
        /// </summary>
        /// <param name="numbers">The list of integers representing the heap.</param>
        /// <param name="n">The current size of the valid heap area.</param>
        /// <param name="i">The index of the node to check and adjust.</param>
        private void Heapify(List<int> numbers, int n, int i)
        {
            var root = i;
            var left = 2 * i + 1;
            var right = 2 * i + 2;

            if (left < n && numbers[left] > numbers[root])
            {
                root = left;
            }
            if (right < n && numbers[right] > numbers[root])
            {
                root = right;
            }

            if (root != i)
            {
                var temp = numbers[i];
                numbers[i] = numbers[root];
                numbers[root] = temp;

                Heapify(numbers, n, root);
            }
        }
    }
}
