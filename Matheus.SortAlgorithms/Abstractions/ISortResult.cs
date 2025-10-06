namespace Matheus.SortAlgorithms.Abstractions
{
    public interface ISortResult
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

        /// <summary>
        /// Gets or sets the execution time of the sorting algorithm, in milliseconds.
        /// </summary>
        public long ExecutionTimeMilliseconds { get; set; }
    }
}