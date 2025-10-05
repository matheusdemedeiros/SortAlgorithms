namespace Matheus.SortAlgorithms.Abstractions
{
    public interface ISortResult
    {
        IEnumerable<int>? SortedList { get; set; }
        bool Success { get; set; }
    }
}