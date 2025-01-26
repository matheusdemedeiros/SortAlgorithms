using QuickSort.Utils;
using System.Diagnostics;

var timeToGenerateNumbers = new Stopwatch();
var timeToSortNumbers = new Stopwatch();

timeToGenerateNumbers.Start();
var numbers = NumberListBuilder.Build(1000000);
timeToGenerateNumbers.Stop();
ConsoleUtils.PrintNumberList(numbers);
Console.WriteLine(@"Tempo decorrido para gerar a lista de numeros: {0} mili-segundos", timeToGenerateNumbers.ElapsedMilliseconds);

var quickSortAlgorithm = new QuickSortAlgorithm();

timeToSortNumbers.Start();
var sortedNumbers = quickSortAlgorithm.Sort(numbers);
timeToSortNumbers.Stop();
ConsoleUtils.PrintNumberList(sortedNumbers);
Console.WriteLine(@"Tempo decorrido para gerar a lista de numeros: {0} mili-segundos", timeToGenerateNumbers.ElapsedMilliseconds);
Console.WriteLine(@"Tempo decorrido para ordenar a lista de números: {0} mili-segundos", timeToSortNumbers.ElapsedMilliseconds);

Console.ReadLine();
