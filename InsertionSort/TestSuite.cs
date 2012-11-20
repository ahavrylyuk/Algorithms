using System.Linq;
using NUnit.Framework;

namespace InsertionSort
{
    [TestFixture]
    class TestSuite
    {
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

        [Test]
        public void TestInsertionSort()
        {
            //var input = Enumerable.Range(1, 100).Shuffle().ToArray();
            var input = new[] {8, 2, 4, 2, 9};

            var output = input.Sort(new ImprovedInsertionAlgorith<int>()).ToArray();

            Assert.AreEqual(input.Sum(), output.Sum());
            
            for (var i = 0; i < output.Length - 1; i++)
            {
                Assert.GreaterOrEqual(output[i + 1], output[i]);
            }
        }
    }
}
