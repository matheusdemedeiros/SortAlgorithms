namespace Matheus.SortAlgorithms.Core
{
    /// <summary>
    /// Specifies the available types of sorting algorithms.
    /// </summary>
    public enum SortAlgorithms
    {
        /// <summary>
        /// QuickSort algorithm.
        /// Average complexity: O(n log n), worst-case: O(n²).
        /// Recursive, divide-and-conquer, not stable.
        /// Best for general-purpose in-memory sorting.
        /// </summary>
        QuickSort = 0,

        /// <summary>
        /// HeapSort algorithm.
        /// Complexity: O(n log n) in all cases.
        /// In-place, non-recursive, not stable.
        /// Useful when stable sorting is not required.
        /// </summary>
        HeapSort = 1,

        /// <summary>
        /// BubbleSort algorithm.
        /// Complexity: O(n²) in average and worst case.
        /// Simple, stable, suitable for educational purposes or small datasets.
        /// </summary>
        BubbleSort = 2,

        /// <summary>
        /// SelectionSort algorithm.
        /// Complexity: O(n²) in all cases.
        /// In-place, not stable, minimal swaps.
        /// Often used in situations where write operations are expensive.
        /// </summary>
        SelectionSort = 3,

        /// <summary>
        /// InsertionSort algorithm.
        /// Complexity: O(n²) average/worst, O(n) best case for nearly sorted lists.
        /// Stable, adaptive, efficient for small or partially sorted datasets.
        /// </summary>
        InsertionSort = 4,

        /// <summary>
        /// MergeSort algorithm.
        /// Complexity: O(n log n) in all cases.
        /// Stable, recursive, requires additional memory for merging.
        /// Ideal for large datasets and when stability is important.
        /// </summary>
        MergeSort = 5,
    }
}
