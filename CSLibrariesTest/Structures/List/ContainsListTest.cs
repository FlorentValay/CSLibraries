using System;
using CSLibraries.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSLibrariesTest.Structures.List
{
    /// <summary>
    /// Test class for List.Contain()
    /// </summary>
    [TestClass]
    public class ContainsListTest
    {
        /// <summary>
        /// This test attempts to see if an empty list cant find a unexisting element.
        /// </summary>
        [TestMethod]
        public void Contains_Empty_ReturnFalse()
        {
            List<int> list = new List<int>();

            Assert.IsFalse(list.Contains(0), "Expected false, but receive true");
        }

        /// <summary>
        /// This test attempts to see if an unexisting element will be not find in the list.
        /// </summary>
        [TestMethod]
        public void Contains_NotExisting_ReturnFalse()
        {
            List<int> list = new List<int>();

            list.Add(1);

            Assert.IsFalse(list.Contains(0), "Expected false, but receive true");
        }

        /// <summary>
        /// This test attempts to see if an existing element will be find in the list.
        /// </summary>
        [TestMethod]
        public void Contains_Existing_ReturnTrue()
        {
            List<int> list = new List<int>();

            list.Add(1);

            Assert.IsTrue(list.Contains(1), "Expected true, but receive false");
        }

        /// <summary>
        /// This test attempts to see if an existing element with default value will be find in the list.
        /// </summary>
        [TestMethod]
        public void Contains_DefaultExisting_ReturnTrue()
        {
            List<int> list = new List<int>();

            list.Add(default(int));

            Assert.IsTrue(list.Contains(default(int)), "Expected true, but receive false");
        }
    }
}
