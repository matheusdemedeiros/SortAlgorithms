using Matheus.SortAlgorithms.Shared;

namespace Matheus.SortAlgorithms.Abstractions
{
    /// <summary>
    /// Defines the contract for sorting algorithms.
    /// </summary>
    public interface ISortAlgorithm
    {
        /// <summary>
        /// Sorts a list of integers and returns the result.
        /// </summary>
        /// <param name="numbers">The list of integers to be sorted.</param>
        /// <returns>
        /// A <see cref="SortResult"/> containing the sorted list and the operation status.
        /// </returns>
        SortResult Sort(List<int> numbers);
    }
}
