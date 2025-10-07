using Matheus.SortAlgorithms.Core;
using Sort.ConsoleApp.Utils;
using System.Diagnostics;

var timeToGenerateNumbers = new Stopwatch();

timeToGenerateNumbers.Start();
var numbers = NumberListBuilder.Build(20);
timeToGenerateNumbers.Stop();
ConsoleUtils.PrintNumberList(numbers);
Console.WriteLine(@"Tempo decorrido para gerar a lista de numeros: {0} mili-segundos", timeToGenerateNumbers.ElapsedMilliseconds);

var sorter = new Sorter(SortAlgorithms.MergeSort);
var result = sorter.Sort(numbers);

ConsoleUtils.PrintNumberList(result.SortedList.ToList());
Console.WriteLine(@"Tempo decorrido para ordenar a lista de números: {0} mili-segundos", result.ExecutionTimeMilliseconds);

Console.ReadLine();
