namespace Sort.ConsoleApp.Utils
{
    public static class ConsoleUtils
    {
        public static void PrintNumberList(List<int> numbers)
        {
            Console.WriteLine("\nArray");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
