using Sort.Domain.Algorithms.Abstractions;
using Sort.Domain.Algorithms.Shared;

namespace Sort.Domain.Algorithms.Quicksort
{
    public class QuickSortAlgorithm : ISortAlgorithm
    {
        public SortResult Sort(List<int> numbers)
        {
            var sorted = new SortResult();
            sorted.SortedList = Process(numbers);
            sorted.Success = sorted.SortedList != null && sorted.SortedList.Any() ? true : false;

            return sorted;
        }

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

        private int GetPivotIndex(List<int> numbers)
        {
            return numbers.Count - 1;
        }
    }
}