namespace Matheus.SortAlgorithms.Abstractions
{
    public interface ISorter
    {
        /// <summary>
        /// Sorts the specified list of integers in ascending order and returns the result.
        /// </summary>
        /// <param name="numbers">The list of integers to sort. Cannot be null.</param>
        /// <returns>An object that contains the sorted list and any additional sorting information.</returns>
        ISortResult Sort(List<int> numbers);
    }
}
