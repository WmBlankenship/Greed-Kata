using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Greed.Tests
{
    [TestClass]
    public class Greed_Should
    {
        private GreedScorer _scorer;

        [TestInitialize]
        public void Setup()
        {
            _scorer = new GreedScorer();
        }

        [DataRow(new int[] { 2, 3, 4, 4, 6 }, 0)]
        [DataRow(new int[] { 2, 3, 4, 4, 5 }, 50)]
        [DataRow(new int[] { 1, 2, 3, 4, 4 }, 100)]
        [DataRow(new int[] { 2, 3, 4, 5, 5 }, 100)]
        [DataRow(new int[] { 1, 3, 4, 5, 6 }, 150)]
        [DataRow(new int[] { 2, 2, 2, 3, 3 }, 200)]
        [DataRow(new int[] { 2, 2, 2, 3, 5 }, 250)]
        [DataRow(new int[] { 3, 3, 3, 4, 4 }, 300)]
        [DataRow(new int[] { 3, 3, 3, 4, 5 }, 350)]
        [DataRow(new int[] { 3, 4, 4, 4, 6 }, 400)]
        [DataRow(new int[] { 3, 4, 4, 4, 5 }, 450)]
        [DataRow(new int[] { 3, 4, 5, 5, 5 }, 500)]
        [DataRow(new int[] { 3, 5, 5, 5, 5 }, 550)]
        [DataRow(new int[] { 2, 3, 6, 6, 6 }, 600)]
        [DataRow(new int[] { 2, 5, 6, 6, 6 }, 650)]
        [DataRow(new int[] { 1, 1, 1, 1, 1 }, 1200)]
        [TestMethod]
        public void Return_Correct_Score(int[] input, int expectedScore)
        {
            var dice = new List<int>(input);
            var actiualScore = _scorer.Score(dice);
            Assert.AreEqual(expectedScore, actiualScore);
        }
    }
}
