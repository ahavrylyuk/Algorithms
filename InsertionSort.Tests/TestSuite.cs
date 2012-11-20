#region Using directives

using System.Collections.Generic;
using System.Linq;
using Xunit;

#endregion

namespace InsertionSort.Tests
{
    public class TestSuite
    {
        private static void AssertSortedAscending(IEnumerable<int> input, IList<int> output)
        {
            Assert.Equal(input.Sum(), output.Sum());

            for (var i = 0; i < output.Count - 1; i++)
            {
                Assert.True(output[i + 1] >= output[i]);
            }
        }

        private static void AssertSortedDescending(IEnumerable<int> input, IList<int> output)
        {
            Assert.Equal(input.Sum(), output.Sum());

            for (var i = 0; i < output.Count - 1; i++)
            {
                Assert.True(output[i] >= output[i + 1]);
            }
        }

        [Fact]
        public void TestInsertionSortDescendingOnSorted()
        {
            var input = Enumerable.Range(1, 100).ToArray();

            var output = input.Sort(new ImprovedInsertionAlgorith<int>(), SortDirection.Desc).ToArray();

            AssertSortedDescending(input, output);
        }

        [Fact]
        public void TestInsertionSortDescendingOnUnsorted()
        {
            var input = Enumerable.Range(1, 100).Shuffle().ToArray();

            var output = input.Sort(new ImprovedInsertionAlgorith<int>(), SortDirection.Desc).ToArray();

            AssertSortedDescending(input, output);
        }

        [Fact]
        public void TestInsertionSortOnSorted()
        {
            var input = Enumerable.Range(1, 100).ToArray();

            var output = input.Sort(new ImprovedInsertionAlgorith<int>()).ToArray();

            AssertSortedAscending(input, output);
        }

        [Fact]
        public void TestInsertionSortOnUnsorted()
        {
            var input = Enumerable.Range(1, 100).Shuffle().ToArray();
            //var input = new[] {8, 2, 4, 2, 9};

            var output = input.Sort(new ImprovedInsertionAlgorith<int>()).ToArray();

            AssertSortedAscending(input, output);
        }

        [Fact]
        public void TestShuffle()
        {
            var range = Enumerable.Range(1, 100).ToArray();
            var input = range.Shuffle();
            Assert.Equal(range.Sum(), input.Sum());
            //for (var i = 0; i < input.Length - 1; i++)
            //{
            //    Assert.AreNotEqual(input[i] + 1, input[i + 1]);
            //}
        }
    }
}