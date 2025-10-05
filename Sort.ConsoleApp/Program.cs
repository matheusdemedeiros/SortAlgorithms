using Matheus.SortAlgorithms.HeapSort;
using Sort.ConsoleApp.Utils;
using System.Diagnostics;

var timeToGenerateNumbers = new Stopwatch();
var timeToSortNumbers = new Stopwatch();

timeToGenerateNumbers.Start();
var numbers = NumberListBuilder.Build(20);
timeToGenerateNumbers.Stop();
ConsoleUtils.PrintNumberList(numbers);
Console.WriteLine(@"Tempo decorrido para gerar a lista de numeros: {0} mili-segundos", timeToGenerateNumbers.ElapsedMilliseconds);

var algorithm = new HeapSortAlgorithm();

timeToSortNumbers.Start();
var sortResult = algorithm.Sort(numbers);
timeToSortNumbers.Stop();
ConsoleUtils.PrintNumberList(sortResult.SortedList.ToList());
Console.WriteLine(@"Tempo decorrido para ordenar a lista de números: {0} mili-segundos", timeToSortNumbers.ElapsedMilliseconds);

Console.ReadLine();
