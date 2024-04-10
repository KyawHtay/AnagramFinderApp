using NUnit.Framework;
using System.Collections.Generic;
using AnagramFinder;

namespace AnagramFinder.Tests
{
    [TestFixture]
    public class AnagramSolverTests
    {
        private readonly string _testFilePath = @"test_words.txt";

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

            Assert.AreEqual(3, letterCounts['P']);
            Assert.AreEqual(6, letterCounts['E']);
            Assert.AreEqual(5, letterCounts['A']);
            Assert.AreEqual(3, letterCounts['L']);
            Assert.AreEqual(3, letterCounts['S']);
        }

        [Test]
        public void FindWordWithMostDistinctCharacters_Returns_Correct_Word()
        {
            var solver = new AnagramSolver(_testFilePath);

            var wordWithMostDistinct = solver.FindWordWithMostDistinctCharacters();

            Assert.AreEqual("binary", wordWithMostDistinct);
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
