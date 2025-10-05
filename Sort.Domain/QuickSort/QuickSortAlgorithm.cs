using Matheus.SortAlgorithms.Abstractions;
using Matheus.SortAlgorithms.Shared;

namespace Matheus.SortAlgorithms.QuickSort
{
    /// <summary>
    /// Implementation of the QuickSort sorting algorithm.
    /// </summary>
    public class QuickSortAlgorithm : ISortAlgorithm
    {
        /// <summary>
        /// Sorts a list of integers using the QuickSort algorithm.
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

        /// <summary>
        /// Recursively sorts a list of integers using QuickSort.
        /// </summary>
        /// <param name="numbers">The list of integers to be sorted.</param>
        /// <returns>A new sorted list.</returns>
        private List<int>? Process(List<int> numbers)
        {
            var pivotIndex = Partition(numbers);
            if (pivotIndex == int.MinValue)
            {
                return numbers;
            }

            var right = numbers.Skip(pivotIndex + 1).ToList();
            var left = numbers.Take(pivotIndex).ToList();

            left = Process(left);
            right = Process(right);

            var sorted = new List<int>();
            sorted.AddRange(left);
            sorted.Add(numbers[pivotIndex]);
            sorted.AddRange(right);

            return sorted;
        }

        /// <summary>
        /// Partitions the list around a pivot element.
        /// Elements smaller than the pivot are moved to the left,
        /// and elements greater than or equal to the pivot are moved to the right.
        /// </summary>
        /// <param name="numbers">The list to partition.</param>
        /// <returns>The final index of the pivot after partitioning.</returns>
        private int Partition(List<int> numbers)
        {
            if (numbers.Count <= 1)
            {
                return int.MinValue;
            }

            var i = 0;
            var j = 0;
            int aux, current;
            var pivotIndex = GetPivotIndex(numbers);
            var pivot = numbers[pivotIndex];

            while (i < numbers.Count)
            {
                current = numbers[i];
                if (current < pivot)
                {
                    aux = current;
                    numbers[i] = numbers[j];
                    numbers[j] = aux;
                    j++;
                }
                i++;
            }

            aux = numbers[j];
            numbers[j] = pivot;
            numbers[pivotIndex] = aux;

            return j;
        }

        /// <summary>
        /// Selects the pivot index for the partitioning process.
        /// Currently, the pivot is always chosen as the last element of the list.
        /// </summary>
        /// <param name="numbers">The list from which the pivot will be selected.</param>
        /// <returns>The pivot index.</returns>
        private int GetPivotIndex(List<int> numbers)
        {
            return numbers.Count - 1;
        }
    }
}
