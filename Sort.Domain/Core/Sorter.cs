using Matheus.SortAlgorithms.Abstractions;
using System.Diagnostics;

namespace Matheus.SortAlgorithms.Core
{
    public class Sorter : ISorter
    {
        private readonly Stopwatch _sw;
        private readonly ISortAlgorithm _sortAlgorithm;

        public Sorter(SortAlgorithmTypes algorithm)
        {
            _sw = new Stopwatch();
            _sortAlgorithm = SortFactory.Create(algorithm);
        }

        public Sorter(ISortAlgorithm sortAlgorithm)
        {
            _sw = new Stopwatch();
            _sortAlgorithm = sortAlgorithm;
        }

        public ISortResult Sort(List<int> numbers)
        {
            _sw.Reset();
            _sw.Start();

            var result = _sortAlgorithm.Sort(numbers);

            _sw.Stop();
            result.ExecutionTimeMilliseconds = _sw.ElapsedMilliseconds;

            return result;
        }
    }
}
