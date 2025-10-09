# 📦 Matheus.SortAlgorithms  

A lightweight .NET library that provides implementations of the most well-known sorting algorithms.  
It is designed to be **modular, extensible, and easy to use**.  

Currently available:

- ✅ QuickSort  
- ✅ HeapSort  
- ✅ BubbleSort   
- ✅ SelectionSort  
- ✅ SelectionSort  
- ✅ MergeSort  

---

## 🚀 Installation  

Add the NuGet package to your project:  

```powershell
dotnet add package Matheus.SortAlgorithms
```

Or via **Package Manager Console**:  

```powershell
Install-Package Matheus.SortAlgorithms
```

---

## 📖 Usage  

### Example with QuickSort  

```csharp
using Matheus.SortAlgorithms.Core;

class Program
{
    static void Main()
    {
        var sorter = new Sorter(SortAlgorithms.QuickSort);

        var input = new List<int> { 10, 7, 8, 9, 1, 5 };
        var result = sorter.Sort(input);

        Console.WriteLine("Input: " + string.Join(", ", input));
        Console.WriteLine("Sorted: " + string.Join(", ", result.SortedList));
        Console.WriteLine("Success: " + result.Success);
    }
}
```

✅ Output:  

```csharp
Input: 10, 7, 8, 9, 1, 5
Sorted: 1, 5, 7, 8, 9, 10
Success: True
```

---

## 🧑‍💻 Public API  

### `Sorter`  

Main entry point to run sorting algorithms:  

```csharp
var sorter = new Sorter(SortAlgorithms.QuickSort);
var result = sorter.Sort(new List<int> { 5, 2, 9 });
```

### `SortAlgorithms`  

Enum that lists the available algorithms:  

```csharp
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
```

### `ISortResult`  

Represents the output of a sorting operation:  

```csharp
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
```

---

## 🧾 License  

Distributed under the MIT License. See `LICENSE` for more information.  

## 📑 Changelog

See all changes in the [CHANGELOG.md](./CHANGELOG.md).

## 🔮 Planned Features (Future Versions)  

We’re constantly improving **Matheus.SortAlgorithms**! Here’s what’s coming in the next releases:  

| Algorithm / Feature | Priority | Description | Use Case |
|--------------------|----------|-------------|----------|
| **RadixSort** 🔜 | High | Non-comparative, integer-based sorting. Extremely fast for large datasets. | Sorting large numeric lists quickly. |
| **CountingSort** 🔜 | High | Non-comparative algorithm suitable for integers in a limited range. | Performance benchmarking; educational purposes. |
| **ShellSort** 🔜 | Medium-High | Improvement over InsertionSort. Efficient for partially sorted arrays. | Medium-sized lists, learning algorithm optimizations. |
| **CocktailSort** 🔜 | Low-Medium | Bidirectional BubbleSort variant. Stable for small datasets. | Educational and comparison purposes. |
| **Support for other list types** 🔜 | High | Currently `List<int>` only. Future support for `List<double>`, `List<string>`, and generic types with `IComparable<T>`. | Greater flexibility and usability across different scenarios. |
| **Benchmarking between algorithms** 🔜 | High | Automatic comparison of execution time, swaps, and comparisons across multiple datasets. | Performance analysis, choosing the best algorithm for your dataset. |

**💡 Notes:**  

- Algorithms marked 🔜 are **planned for upcoming versions**.  
- Benchmarking will include **different dataset types**: random, sorted, reverse-sorted, nearly sorted, and uniform.  
- Future versions will also allow **custom comparators** and **ascending/descending order selection**.  
