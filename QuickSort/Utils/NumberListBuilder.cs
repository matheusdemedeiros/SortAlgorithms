namespace QuickSort.Utils
{
    public static class NumberListBuilder
    {
        public static List<int> Build(int count)
        {
            var random = new Random();
            var numberList = new List<int>();
            while (numberList.Count < count)
            {
                numberList.Add(random.Next(0, count + 1));
            }

            return numberList;
        }
    }
}
