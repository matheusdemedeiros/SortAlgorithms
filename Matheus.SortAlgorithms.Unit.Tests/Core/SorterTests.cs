using Matheus.SortAlgorithms.Core;

namespace Matheus.SortAlgorithms.Unit.Tests.Core
{
    public class SorterTests
    {
        [Theory]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.BubbleSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.SelectionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.InsertionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.HeapSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.MergeSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.QuickSort)]
        public void Sort_ShouldSortList_Correctly(SortAlgorithms.Core.SortAlgorithms algorithm)
        {
            // Arrange
            var numbers = new List<int> { 5, 3, 8, 1, 2 };
            var expected = new List<int> { 1, 2, 3, 5, 8 };
            var sorter = new Sorter(algorithm);
            // Act
            var result = sorter.Sort(numbers);
            // Assert
            Assert.True(result.Success);
            Assert.Equal(expected, result.SortedList);
            Assert.True(result.ExecutionTimeMilliseconds >= 0);
        }

        [Theory]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.BubbleSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.SelectionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.InsertionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.HeapSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.MergeSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.QuickSort)]
        public void Sort_ShouldHandleEmptyList(SortAlgorithms.Core.SortAlgorithms algorithm)
        {
            // Arrange
            var numbers = new List<int>();
            var expected = new List<int>();
            var sorter = new Sorter(algorithm);
            // Act
            var result = sorter.Sort(numbers);
            // Assert
            Assert.False(result.Success);
            Assert.Equal(expected, result.SortedList);
            Assert.True(result.ExecutionTimeMilliseconds >= 0);
        }

        [Theory]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.BubbleSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.SelectionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.InsertionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.HeapSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.MergeSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.QuickSort)]
        public void Sort_ShouldHandleNullList(SortAlgorithms.Core.SortAlgorithms algorithm)
        {
            // Arrange
            List<int> numbers = null;
            var sorter = new Sorter(algorithm);
            var result = sorter.Sort(numbers);

            // Act & Assert
            Assert.False(result.Success);
            Assert.Null(result.SortedList);
            Assert.True(result.ExecutionTimeMilliseconds >= 0);
        }

        [Theory]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.BubbleSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.SelectionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.InsertionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.HeapSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.MergeSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.QuickSort)]
        public void Sort_ShouldHandleSingleElementList(SortAlgorithms.Core.SortAlgorithms algorithm)
        {
            // Arrange
            var numbers = new List<int> { 42 };
            var expected = new List<int> { 42 };
            var sorter = new Sorter(algorithm);
            // Act
            var result = sorter.Sort(numbers);
            // Assert
            Assert.True(result.Success);
            Assert.Equal(expected, result.SortedList);
            Assert.True(result.ExecutionTimeMilliseconds >= 0);
        }

        [Theory]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.BubbleSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.SelectionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.InsertionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.HeapSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.MergeSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.QuickSort)]
        public void Sort_ShouldHandleAlreadySortedList(SortAlgorithms.Core.SortAlgorithms algorithm)
        {
            // Arrange
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var expected = new List<int> { 1, 2, 3, 4, 5 };
            var sorter = new Sorter(algorithm);
            // Act
            var result = sorter.Sort(numbers);
            // Assert
            Assert.True(result.Success);
            Assert.Equal(expected, result.SortedList);
            Assert.True(result.ExecutionTimeMilliseconds >= 0);
        }

        [Theory]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.BubbleSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.SelectionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.InsertionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.HeapSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.MergeSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.QuickSort)]
        public void Sort_ShouldHandleListWithNegativeNumbers(SortAlgorithms.Core.SortAlgorithms algorithm)
        {
            // Arrange
            var numbers = new List<int> { 3, -1, 4, -2, 0 };
            var expected = new List<int> { -2, -1, 0, 3, 4 };
            var sorter = new Sorter(algorithm);
            // Act
            var result = sorter.Sort(numbers);
            // Assert
            Assert.True(result.Success);
            Assert.Equal(expected, result.SortedList);
            Assert.True(result.ExecutionTimeMilliseconds >= 0);
        }

        [Theory]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.BubbleSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.SelectionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.InsertionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.HeapSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.MergeSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.QuickSort)]
        public void Sort_ShouldHandleListWithDuplicates(SortAlgorithms.Core.SortAlgorithms algorithm)
        {
            // Arrange
            var numbers = new List<int> { 4, 2, 3, 2, 4, 1 };
            var expected = new List<int> { 1, 2, 2, 3, 4, 4 };
            var sorter = new Sorter(algorithm);
            // Act
            var result = sorter.Sort(numbers);
            // Assert
            Assert.True(result.Success);
            Assert.Equal(expected, result.SortedList);
            Assert.True(result.ExecutionTimeMilliseconds >= 0);
        }

        [Theory]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.BubbleSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.SelectionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.InsertionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.HeapSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.MergeSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.QuickSort)]
        public void Sort_ShouldHandleLargeList(SortAlgorithms.Core.SortAlgorithms algorithm)
        {
            // Arrange
            var random = new Random();
            var numbers = Enumerable.Range(0, 1000).Select(_ => random.Next(0, 10000)).ToList();
            var expected = numbers.OrderBy(n => n).ToList();
            var sorter = new Sorter(algorithm);
            // Act
            var result = sorter.Sort(numbers);
            // Assert
            Assert.True(result.Success);
            Assert.Equal(expected, result.SortedList);
            Assert.True(result.ExecutionTimeMilliseconds >= 0);
        }

        [Theory]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.BubbleSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.SelectionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.InsertionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.HeapSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.MergeSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.QuickSort)]
        public void Sort_ShouldHandleListWithAllIdenticalElements(SortAlgorithms.Core.SortAlgorithms algorithm)
        {
            // Arrange
            var numbers = new List<int> { 7, 7, 7, 7, 7 };
            var expected = new List<int> { 7, 7, 7, 7, 7 };
            var sorter = new Sorter(algorithm);
            // Act
            var result = sorter.Sort(numbers);
            // Assert
            Assert.True(result.Success);
            Assert.Equal(expected, result.SortedList);
            Assert.True(result.ExecutionTimeMilliseconds >= 0);
        }

        [Theory]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.BubbleSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.SelectionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.InsertionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.HeapSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.MergeSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.QuickSort)]
        public void Sort_ShouldHandleReverseSortedList(SortAlgorithms.Core.SortAlgorithms algorithm)
        {
            // Arrange
            var numbers = new List<int> { 5, 4, 3, 2, 1 };
            var expected = new List<int> { 1, 2, 3, 4, 5 };
            var sorter = new Sorter(algorithm);
            // Act
            var result = sorter.Sort(numbers);
            // Assert
            Assert.True(result.Success);
            Assert.Equal(expected, result.SortedList);
            Assert.True(result.ExecutionTimeMilliseconds >= 0);
        }

        [Theory]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.BubbleSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.SelectionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.InsertionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.HeapSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.MergeSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.QuickSort)]
        public void Sort_ShouldHandleListWithMaxAndMinIntegers(SortAlgorithms.Core.SortAlgorithms algorithm)
        {
            // Arrange
            var numbers = new List<int> { int.MaxValue, 0, int.MinValue, 100, -100 };
            var expected = new List<int> { int.MinValue, -100, 0, 100, int.MaxValue };
            var sorter = new Sorter(algorithm);
            // Act
            var result = sorter.Sort(numbers);
            // Assert
            Assert.True(result.Success);
            Assert.Equal(expected, result.SortedList);
            Assert.True(result.ExecutionTimeMilliseconds >= 0);
        }

        [Theory]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.BubbleSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.SelectionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.InsertionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.HeapSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.MergeSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.QuickSort)]
        public void Sort_ShouldHandleListWithLargeRangeOfValues(SortAlgorithms.Core.SortAlgorithms algorithm)
        {
            // Arrange
            var numbers = new List<int> { 1000, -1000, 500, -500, 0 };
            var expected = new List<int> { -1000, -500, 0, 500, 1000 };
            var sorter = new Sorter(algorithm);
            // Act
            var result = sorter.Sort(numbers);
            // Assert
            Assert.True(result.Success);
            Assert.Equal(expected, result.SortedList);
            Assert.True(result.ExecutionTimeMilliseconds >= 0);
        }

        [Theory]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.BubbleSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.SelectionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.InsertionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.HeapSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.MergeSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.QuickSort)]
        public void Sort_ShouldHandleListWithZeros(SortAlgorithms.Core.SortAlgorithms algorithm)
        {
            // Arrange
            var numbers = new List<int> { 0, 0, 0, 0, 0 };
            var expected = new List<int> { 0, 0, 0, 0, 0 };
            var sorter = new Sorter(algorithm);
            // Act
            var result = sorter.Sort(numbers);
            // Assert
            Assert.True(result.Success);
            Assert.Equal(expected, result.SortedList);
            Assert.True(result.ExecutionTimeMilliseconds >= 0);
        }

        [Theory]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.BubbleSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.SelectionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.InsertionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.HeapSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.MergeSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.QuickSort)]
        public void Sort_ShouldHandleListWithAlternatingHighLowValues(SortAlgorithms.Core.SortAlgorithms algorithm)
        {
            // Arrange
            var numbers = new List<int> { 1, 1000, 2, 999, 3, 998 };
            var expected = new List<int> { 1, 2, 3, 998, 999, 1000 };
            var sorter = new Sorter(algorithm);
            // Act
            var result = sorter.Sort(numbers);
            // Assert
            Assert.True(result.Success);
            Assert.Equal(expected, result.SortedList);
            Assert.True(result.ExecutionTimeMilliseconds >= 0);
        }

        [Theory]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.BubbleSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.SelectionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.InsertionSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.HeapSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.MergeSort)]
        [InlineData(SortAlgorithms.Core.SortAlgorithms.QuickSort)]
        public void Sort_ShouldHandleListWithNegativeAndPositiveNumbers(SortAlgorithms.Core.SortAlgorithms algorithm)
        {
            // Arrange
            var numbers = new List<int> { -10, 5, -3, 2, 0, -1, 4 };
            var expected = new List<int> { -10, -3, -1, 0, 2, 4, 5 };
            var sorter = new Sorter(algorithm);
            // Act
            var result = sorter.Sort(numbers);
            // Assert
            Assert.True(result.Success);
            Assert.Equal(expected, result.SortedList);
            Assert.True(result.ExecutionTimeMilliseconds >= 0);
        }
    }
}
