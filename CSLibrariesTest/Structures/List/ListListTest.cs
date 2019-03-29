using CSLibraries.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSLibrariesTest.Structures.List
{
    /// <summary>
    /// Class test for List.List()
    /// </summary>
    [TestClass]
    public class ListListTest
    {
        /// <summary>
        /// This test attempts to see if default constructor give a capacity 20
        /// </summary>
        [TestMethod]
        public void ListDefault_TestCapacity_Return20()
        {
            List<int> list = new List<int>();

            Assert.AreEqual(20, list.Capacity, $"Expected 20 but receive {list.Capacity}");
        }

        /// <summary>
        /// This test attempts to see if default constructor contains 0 element
        /// </summary>
        [TestMethod]
        public void ListDefault_TestCount_Return0()
        {
            List<int> list = new List<int>();

            Assert.AreEqual(0, list.Count, $"Expected 20 but receive {list.Count}");
        }

        /// <summary>
        /// This test attempts to see if constructor with parameter give the choosen capacity 
        /// </summary>
        [TestMethod]
        public void ListParam_TestCapacity_Return2()
        {
            List<int> list = new List<int>(2);

            Assert.AreEqual(2, list.Capacity, $"Expected 2 but receive {list.Capacity}");
        }

        /// <summary>
        /// This test attempts to see if constructor with parameter contains 0 element
        /// </summary>
        [TestMethod]
        public void ListParam_TestCount_Return0()
        {
            List<int> list = new List<int>(2);

            Assert.AreEqual(0, list.Count, $"Expected 20 but receive {list.Count}");
        }
    }
}
