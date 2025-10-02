# 📦 Matheus.SortAlgorithms  

A lightweight .NET library that provides implementations of the most well-known sorting algorithms.  
It is designed to be **modular, extensible, and easy to use**.  

Currently available:

- ✅ QuickSort  

Planned for future versions:  

- 🔜 MergeSort  
- 🔜 HeapSort  
- 🔜 BubbleSort  
- 🔜 InsertionSort  
- 🔜 SelectionSort  

---

## 🚀 Installation  

Add the NuGet package to your project:  

```powershell
dotnet add package Sort.Domain
```

Or via **Package Manager Console**:  

```powershell
Install-Package Sort.Domain
```

---

## 📖 Usage  

### Example with QuickSort  

```csharp
using Sort.Domain.Algorithms.Quicksort;
using Sort.Domain.Algorithms.Shared;

class Program
{
    static void Main()
    {
        var sorter = new QuickSortAlgorithm();

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

## 📂 Project Structure  

```markdown
Sort.Domain
 ├── Algorithms
 │    ├── Abstractions   # Interfaces (ISortAlgorithm)
 │    ├── Quicksort      # QuickSort implementation
 │    └── ... (other algorithms coming soon)
 │
 ├── Shared              # Common objects (SortResult)
 ├── Sort.Domain.csproj
 └── README.md
```

---

## 🧑‍💻 Public API  

### `ISortAlgorithm`

Interface for all sorting algorithms:  

```csharp
public interface ISortAlgorithm
{
    SortResult Sort(List<int> numbers);
}
```

### `QuickSortAlgorithm`  

QuickSort implementation:  

```csharp
var sorter = new QuickSortAlgorithm();
var result = sorter.Sort(new List<int> { 5, 2, 9 });
```

### `SortResult`  

Represents the output of a sorting operation:  

```csharp
public class SortResult
{
    public IEnumerable<int>? SortedList { get; set; }
    public bool Success { get; set; }
}
```

---

## 🧾 License  

Distributed under the MIT License. See `LICENSE` for more information.  
