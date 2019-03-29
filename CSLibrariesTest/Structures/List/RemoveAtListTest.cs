using CSLibraries.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSLibrariesTest.Structures.List
{
    /// <summary>
    /// Test class for List.RemoveAt()
    /// </summary>
    [TestClass]
    public class RemoveAtListTest
    {
        // TODO: Coder la suite de tests

        /// <summary>
        /// This test attempts to see if trying to remove at a negative index will throw an exception
        /// </summary>
        [TestMethod]
        public void RemoveAt_OverMinRange_ThrowsException()
        {
            List<int> list = new List<int>();

            Assert.ThrowsException<System.IndexOutOfRangeException>(() => list.RemoveAt(-1));
        }
    }
}
