namespace GroupAnagrams
{
    internal class Program
    {
        static List<List<string>> GroupAnagrams(List<string> strings)
        {
            Dictionary<string, List<string>> storedAnagrams = new();
            foreach (var word in strings)
            {
                string sortedW = String.Concat(word.OrderBy(c => c));
                if (!storedAnagrams.ContainsKey(sortedW))
                    storedAnagrams.Add(sortedW, new());
                storedAnagrams[sortedW].Add(word);
            }
            return storedAnagrams.Values.ToList();
        }
        static void Main(string[] args)
        {
            var input1 = new List<string>() { "eat", "tea", "tan", "ate", "nat", "bat" };
            var grouped = GroupAnagrams(input1);
        }
    }
}
