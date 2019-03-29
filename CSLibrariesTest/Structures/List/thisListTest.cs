using CSLibraries.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSLibrariesTest.Structures.List
{
    /// <summary>
    /// Test class for CSLibrariesTest.Structures.List.this[].
    /// </summary>
    [TestClass]
    public class ThisListTest
    {
        /// <summary>
        /// This test attempts to see if an index return a corect value.
        /// </summary>
        /// <param name="index">Index of the tested index.</param>
        /// <param name="expected">Result expected for the index.</param>
        [DataTestMethod]
        [DataRow(0, 1)]
        [DataRow(1, 2)]
        [DataRow(2, 3)]
        [DataRow(3, 4)]
        [DataRow(4, 5)]
        public void This_Index_ReturnGoodValue(int index,int expected)
        {
            List<int> list = new List<int>(5);

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            Assert.AreEqual(expected, list[index], $"{expected} was expected but receive {list[index]}");
        }

        /// <summary>
        /// This test attempts to see if an over capacity index throws an exception of type System.IndexOutOfRangeException.
        /// </summary>
        [TestMethod]
        public void This_OutOfCapacityRange_ThrowException()
        {
            List<int> list = new List<int>();

            Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[20]);
        }

        /// <summary>
        /// This test attempts to see if an unset index throws an exception of type System.IndexOutOfRangeException.
        /// </summary>
        [TestMethod]
        public void This_OutOfContainRange_ThrowException()
        {
            List<int> list = new List<int>();

            Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[0]);
        }

        /// <summary>
        /// This test attempts to see if a negative index throws an exception of type System.IndexOutOfRangeException.
        /// </summary>
        [TestMethod]
        public void This_OutOfMinRange_ThrowException()
        {
            List<int> list = new List<int>();

            Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[-1]);
        }
    }
}
