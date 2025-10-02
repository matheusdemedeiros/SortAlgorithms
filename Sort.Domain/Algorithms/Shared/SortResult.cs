namespace Sort.Domain.Algorithms.Shared
{
    /// <summary>
    /// Represents the result of a sorting operation.
    /// </summary>
    public class SortResult
    {
        /// <summary>
        /// Gets or sets the sorted list of integers.
        /// Returns <c>null</c> if the sorting process failed.
        /// </summary>
        public IEnumerable<int>? SortedList { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the sorting operation was successful.
        /// </summary>
        public bool Success { get; set; }
    }
}
