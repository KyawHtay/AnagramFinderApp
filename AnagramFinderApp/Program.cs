
using System;

namespace AnagramFinderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file location:");
            string filePath = Console.ReadLine();

            //Defensive checking:
            if (!File.Exists(filePath)) { Console.WriteLine($"No File {filePath} exists!"); Console.ReadKey(); return; }
            var solver = new AnagramFinder.AnagramSolver(filePath);

            var largestAnagrams = solver.FindLargestSetOfAnagrams();
            Console.WriteLine("Largest set of anagrams:");
            foreach (var word in largestAnagrams)
            {
                Console.WriteLine(word);
            }

            var letterCounts = solver.CountWordsForLetter();
            Console.WriteLine("\nCount of words for each letter:");
            foreach (var kvp in letterCounts.OrderBy(k => k.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            var wordWithMostDistinctChars = solver.FindWordWithMostDistinctCharacters();
            Console.WriteLine($"\nWord with most distinct characters: {wordWithMostDistinctChars}");

            Console.ReadKey();
        }
    }
}
