using CSLibraries.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSLibrariesTest.Structures.List
{
    /// <summary>
    /// Test class for CSLibrariesTest.Structures.List.Count.
    /// </summary>
    [TestClass]
    public class CountListTest
    {
        /// <summary>
        /// This test atempt to see if Count will return 0 for a cleared list.
        /// </summary>
        [TestMethod]
        public void Count_Cleared_Return0()
        {
            List<int> list = new List<int>();

            list.Add(0);
            list.Clear();

            Assert.AreEqual(0, list.Count, $"Expected 0, obtained {list.Count}");
        }

        /// <summary>
        /// This test atempt to see if Count will return 0 for an empty list with default constructor.
        /// </summary>
        [TestMethod]
        public void Count_DefaultEmpty_Return0()
        {
            List<int> list = new List<int>();

            Assert.AreEqual(0, list.Count, $"Expected 0, obtained {list.Count}");
        }

        /// <summary>
        /// This test atempt to see if Count will return 0 for an empty list with capacity parameter.
        /// </summary>
        [TestMethod]
        public void Count_ParamEmpty_Return0()
        {
            List<int> list = new List<int>(5);

            Assert.AreEqual(0, list.Count, $"Expected 0, obtained {list.Count}");
        }

        /// <summary>
        /// This test atempt to see if Count will return 5 as the number of elements added to the list.
        /// </summary>
        [TestMethod]
        public void Count_SemiFullReturn5()
        {
            List<int> list = new List<int>();

            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(0);

            Assert.AreEqual(5, list.Count, $"Expected 5, obtained {list.Count}");
        }
    }
}
