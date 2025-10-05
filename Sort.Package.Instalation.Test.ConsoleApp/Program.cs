using Sort.Domain.Algorithms.Quicksort;

namespace Sort.Package.Instalation.Test.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var list = new List<int> { 5, 3, 8, 1, 2 };
           
            var sorter = new QuickSortAlgorithm();
            var result = sorter.Sort(list);
        }
    }
}
