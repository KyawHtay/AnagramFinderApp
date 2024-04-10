using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AnagramFinder
{
    public class AnagramSolver
    {
        private readonly string _filePath;

        public AnagramSolver(string filePath)
        {
            _filePath = filePath;
        }

        public List<string> FindLargestSetOfAnagrams()
        {
            var words = File.ReadAllLines(_filePath);
            var groupedAnagrams = words.GroupBy(WordToSortedString)
                                       .OrderByDescending(group => group.Count())
                                       .FirstOrDefault();

            return groupedAnagrams?.ToList() ?? new List<string>();
        }

        private string WordToSortedString(string word)
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }

        public Dictionary<char, int> CountWordsForLetter()
        {
            var words = File.ReadAllLines(_filePath);
            var letterCounts = new Dictionary<char, int>();

            foreach (var word in words)
            {
                foreach (var letter in word.ToUpper())
                {
                    if (!letterCounts.ContainsKey(letter))
                        letterCounts[letter] = 0;
                    letterCounts[letter]++;
                }
            }

            return letterCounts;
        }

        public string FindWordWithMostDistinctCharacters()
        {
            var words = File.ReadAllLines(_filePath);
            var maxDistinctCount = 0;
            var wordWithMaxDistinct = "";

            foreach (var word in words)
            {
                var distinctCount = word.Distinct().Count();
                if (distinctCount > maxDistinctCount)
                {
                    maxDistinctCount = distinctCount;
                    wordWithMaxDistinct = word;
                }
            }

            return wordWithMaxDistinct;
        }


    }
}
