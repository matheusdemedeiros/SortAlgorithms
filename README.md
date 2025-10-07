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
    QuickSort,
    HeapSort
    // Future implementations: MergeSort, BubbleSort, InsertionSort, SelectionSort
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

