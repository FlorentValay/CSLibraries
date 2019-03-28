using CSLibraries.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSLibrariesTest.Structures.List
{
    /// <summary>
    /// Test class for CSLibrariesTest.Structures.List.Reverse().
    /// </summary>
    [TestClass]
    public class ReverseListTest
    {
        /// <summary>
        /// This test atempt to see if Reverse function inverse correctly the list.
        /// </summary>
        [TestMethod]
        public void Reverse_Once_ReturnString()
        {
            List<int> list = new List<int>(5);

            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Reverse();

            Assert.AreEqual("| 4 | 3 | 2 | 1 | 0 |", list.ToString(), $"Expected '| 4 | 3 | 2 | 1 | 0 |' and recieve '{list.ToString()}'");
        }

        /// <summary>
        /// This test atempt to see if Reverse function inverse correctly the list twice.
        /// </summary>
        [TestMethod]
        public void Reverse_Twice_ReturnString()
        {
            List<int> list = new List<int>(5);

            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Reverse();
            list.Reverse();

            Assert.AreEqual("| 0 | 1 | 2 | 3 | 4 |", list.ToString(), $"Expected '| 0 | 1 | 2 | 3 | 4 |' and recieve '{list.ToString()}'");
        }
    }
}
