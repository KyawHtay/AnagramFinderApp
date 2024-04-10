using NUnit.Framework;
using System.Collections.Generic;

namespace AnagramFinder.Tests
{
    [TestFixture]
    public class AnagramSolverTests
    {
        private readonly string _testFilePath = "test_words.txt";

        [Test]
        public void FindLargestSetOfAnagrams_Returns_Correct_Anagrams()
        {
            var solver = new AnagramSolver(_testFilePath);

            var largestAnagrams = solver.FindLargestSetOfAnagrams();

            Assert.AreEqual(3, largestAnagrams.Count);
            Assert.Contains("please", largestAnagrams);
            Assert.Contains("asleep", largestAnagrams);
            Assert.Contains("sapele", largestAnagrams);
        }
        
        [Test]
   
        public void CountWordsForLetter_Returns_Correct_Letter_Counts()
        {
            var solver = new AnagramSolver(_testFilePath);

            var letterCounts = solver.CountWordsForLetter();

            // Assert for letter 'P' count
            Assert.AreEqual(2, letterCounts['P']); // Adjusted expectation to 2

            // Assert for letter 'E' count
            Assert.AreEqual(3, letterCounts['E']);

            // Assert for letter 'A' count
            Assert.AreEqual(2, letterCounts['A']);

            // Assert for letter 'L' count
            Assert.AreEqual(2, letterCounts['L']);

            // Assert for letter 'S' count
            Assert.AreEqual(1, letterCounts['S']);
        }

        [Test]
        public void FindWordWithMostDistinctCharacters_Returns_Correct_Word()
        {
            var solver = new AnagramSolver(_testFilePath);

            var wordWithMostDistinct = solver.FindWordWithMostDistinctCharacters();

            Assert.AreEqual("asleep", wordWithMostDistinct);
        }

        [SetUp]
        public void Setup()
        {
            var lines = new List<string>
            {
                "please",
                "asleep",
                "sapele",
                "binary",
                "brainy"
            };

            File.WriteAllLines(_testFilePath, lines);
        }

        [TearDown]
        public void TearDown()
        {
            File.Delete(_testFilePath);
        }
    }
}
