#region Using directives

using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

#endregion

namespace InsertionSort
{
    [TestFixture]
    public class TestSuite
    {
        private static void AssertSortedAscending(IEnumerable<int> input, IList<int> output)
        {
            Assert.AreEqual(input.Sum(), output.Sum());

            for (var i = 0; i < output.Count - 1; i++)
            {
                Assert.GreaterOrEqual(output[i + 1], output[i]);
            }
        }

        private static void AssertSortedDescending(IEnumerable<int> input, IList<int> output)
        {
            Assert.AreEqual(input.Sum(), output.Sum());

            for (var i = 0; i < output.Count - 1; i++)
            {
                Assert.GreaterOrEqual(output[i], output[i + 1]);
            }
        }

        [Test]
        public void TestInsertionSortDescendingOnSorted()
        {
            var input = Enumerable.Range(1, 100).ToArray();

            var output = input.Sort(new ImprovedInsertionAlgorith<int>(), SortDirection.Desc).ToArray();

            AssertSortedDescending(input, output);
        }

        [Test]
        public void TestInsertionSortDescendingOnUnsorted()
        {
            var input = Enumerable.Range(1, 100).Shuffle().ToArray();

            var output = input.Sort(new ImprovedInsertionAlgorith<int>(), SortDirection.Desc).ToArray();

            AssertSortedDescending(input, output);
        }

        [Test]
        public void TestInsertionSortOnSorted()
        {
            var input = Enumerable.Range(1, 100).ToArray();

            var output = input.Sort(new ImprovedInsertionAlgorith<int>()).ToArray();

            AssertSortedAscending(input, output);
        }

        [Test]
        public void TestInsertionSortOnUnsorted()
        {
            var input = Enumerable.Range(1, 100).Shuffle().ToArray();
            //var input = new[] {8, 2, 4, 2, 9};

            var output = input.Sort(new ImprovedInsertionAlgorith<int>()).ToArray();

            AssertSortedAscending(input, output);
        }

        [Test]
        public void TestShuffle()
        {
            var range = Enumerable.Range(1, 100).ToArray();
            var input = range.Shuffle();
            Assert.AreEqual(range.Sum(), input.Sum());
            //for (var i = 0; i < input.Length - 1; i++)
            //{
            //    Assert.AreNotEqual(input[i] + 1, input[i + 1]);
            //}
        }
    }
}