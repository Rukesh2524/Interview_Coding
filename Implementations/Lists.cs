using System;
using System.Collections.Generic;
using System.Text;

namespace Implementations
{
    public class Lists
    {

        public static string CountCharacters(string input)
        {
            var characterCount = new List<(char Character, int Count)>();
            foreach (char c in input)
            {
                var existingEntry = characterCount.Find(entry => entry.Character == c);
                if (existingEntry.Character != '\0')
                {
                    existingEntry.Count++;
                }
                else
                {
                    characterCount.Add((c, 1));
                }
            }
            return string.Join(", ", characterCount.Select(entry => $"{entry.Character}: {entry.Count}"));
        }
    }
}
