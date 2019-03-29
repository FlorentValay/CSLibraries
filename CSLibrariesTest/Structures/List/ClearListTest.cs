using CSLibraries.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSLibrariesTest.Structures.List
{
    /// <summary>
    /// This test class is used to test List.Clear
    /// </summary>
    public class ClearListTest
    {
        /// <summary>
        /// This test method attempts to see if clearing a list will not change capacity.
        /// </summary>
        [TestMethod]
        public void Clear_TestCapacity_Return20()
        {
            List<int> list = new List<int>();

            list.Clear();

            Assert.AreEqual(20, list.Capacity, $"Expected 20 but receive {list.Capacity}");
        }

        /// <summary>
        /// This test method attempts to see if clearing a list will change count to 0.
        /// </summary>
        [TestMethod]
        public void Clear_TestCount_Return0()
        {
            List<int> list = new List<int>();

            list.Add(0);
            list.Clear();

            Assert.AreEqual(0, list.Count, $"Expected 0 but receive {list.Count}");
        }
    }
}
