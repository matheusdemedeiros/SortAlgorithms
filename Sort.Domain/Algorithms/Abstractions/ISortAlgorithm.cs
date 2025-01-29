using Sort.Domain.Algorithms.Shared;

namespace Sort.Domain.Algorithms.Abstractions
{
    public interface ISortAlgorithm
    {
        SortResult Sort(List<int> numbers);
    }
}
