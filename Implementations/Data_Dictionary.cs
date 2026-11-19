namespace Implementations
{
    public class Data_Dictionary
    {
        public static string CountCharacters(string input)
        {
            var characterCount = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (characterCount.ContainsKey(c))
                {
                    characterCount[c]++;
                }
                else
                {
                    characterCount[c] = 1;
                }
            }
            return string.Join(", ", characterCount.Select(kvp => $"{kvp.Key}: {kvp.Value}"));
        }
    }
}
