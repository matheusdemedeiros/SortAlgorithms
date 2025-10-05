using Matheus.SortAlgorithms.Abstractions;
using Matheus.SortAlgorithms.Algorithms.HeapSort;
using Matheus.SortAlgorithms.Algorithms.QuickSort;

namespace Matheus.SortAlgorithms.Core
{
    /// <summary>
    /// Provides a factory for creating instances of sorting algorithms based on the specified type.
    /// </summary>
    public static class SortFactory
    {
        /// <summary>
        /// Creates an instance of <see cref="ISortAlgorithm"/> based on the specified algorithm type.
        /// </summary>
        /// <param name="algorithm">The type of sorting algorithm to create.</param>
        /// <returns>
        /// An instance of <see cref="ISortAlgorithm"/> corresponding to the provided type.
        /// </returns>
        public static ISortAlgorithm Create(SortAlgorithmTypes algorithmType)
        {
            switch(algorithmType)
            {
                case SortAlgorithmTypes.QuickSort:
                    return new QuickSortAlgorithm();
                case SortAlgorithmTypes.HeapSort:
                    return new HeapSortAlgorithm();
                default:
                    throw new ArgumentException("Invalid algorithm type");
            }
        }
    }
}
