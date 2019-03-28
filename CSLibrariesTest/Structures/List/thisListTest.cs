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
        // TODO: Coder la suite de tests

        /// <summary>
        /// This test atempt to see if a negative index throws an exception of type System.IndexOutOfRangeException.
        /// </summary>
        [TestMethod]
        public void This_OutOfMinRange_ThrowException()
        {
            List<int> list = new List<int>();

            Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[-1]);
        }
    }
}
