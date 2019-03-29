using CSLibraries.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSLibrariesTest.Structures.List
{
    /// <summary>
    /// Test class for List.Capacity
    /// </summary>
    [TestClass]
    public class CapacityListTest
    {
        /// <summary>
        /// This test attemps to see if default capacity is 20 for a list.
        /// </summary>
        [TestMethod]
        public void Capacity_DefaultConstructor_Return20()
        {
            List<int> list = new List<int>();

            Assert.AreEqual(20, list.Capacity, $"Expected 20 but receive {list.Capacity}");
        }

        /// <summary>
        /// This test attemps to see if capacity is equals to the one given.
        /// </summary>
        [TestMethod]
        public void Capacity_ParamConstructor_Return2()
        {
            List<int> list = new List<int>(2);

            Assert.AreEqual(2, list.Capacity, $"Expected 2 but receive {list.Capacity}");
        }

        /// <summary>
        /// This test attemps to see if capacity does not change after adding into a list.
        /// </summary>
        [TestMethod]
        public void Capacity_AfterAdding_Return20()
        {
            List<int> list = new List<int>();

            list.Add(2);

            Assert.AreEqual(20, list.Capacity, $"Expected 20 but receive {list.Capacity}");
        }

        /// <summary>
        /// This test attemps to see if capacity does not change after clearing a list.
        /// </summary>
        [TestMethod]
        public void Capacity_AfterClearing_Return20()
        {
            List<int> list = new List<int>();

            list.Clear();

            Assert.AreEqual(20, list.Capacity, $"Expected 20 but receive {list.Capacity}");
        }

        /// <summary>
        /// This test attemps to see if capacity changed to smaller keep only the firsts values.
        /// </summary>
        [TestMethod]
        public void Capacity_SetSmaller_ReturnString()
        {
            List<int> list = new List<int>(5);

            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(1);
            list.Add(1);
            list.Capacity = 3;

            Assert.AreEqual("| 0 | 0 | 0 |", list.ToString(), $"Expected '| 0 | 0 | 0 |' but receive {list.ToString()}");
        }

        /// <summary>
        /// This test attemps to see if capacity changed to larger keep all the sets values.
        /// </summary>
        [TestMethod]
        public void Capacity_SetLarger_ReturnString()
        {
            List<int> list = new List<int>(3);

            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Capacity = 5;

            Assert.AreEqual("| 0 | 0 | 0 |", list.ToString(), $"Expected '| 0 | 0 | 0 |' but receive {list.ToString()}");
        }

        /// <summary>
        /// This test attemps to see if capacity changed to smaller return the new capacity.
        /// </summary>
        [TestMethod]
        public void Capacity_SetSmaller_ReturnCapacity()
        {
            List<int> list = new List<int>();

            list.Capacity = 10;

            Assert.AreEqual(10, list.Capacity, $"Expected 10 but receive {list.Capacity}");
        }

        /// <summary>
        /// This test attemps to see if capacity changed to larger return the new capacity.
        /// </summary>
        [TestMethod]
        public void Capacity_SetLarger_ReturnCapacity()
        {
            List<int> list = new List<int>();

            list.Capacity = 30;

            Assert.AreEqual(30, list.Capacity, $"Expected 30 but receive {list.Capacity}");
        }

        /// <summary>
        /// This test attemps to see if capacity changed to smaller return the new count.
        /// </summary>
        [TestMethod]
        public void Capacity_SetSmaller_ReturnCount()
        {
            List<int> list = new List<int>(5);

            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(1);
            list.Add(1);
            list.Capacity = 3;

            Assert.AreEqual(3, list.Count, $"Expected 3 but receive {list.Count}");
        }

        /// <summary>
        /// This test attemps to see if capacity changed to larger return the new count.
        /// </summary>
        [TestMethod]
        public void Capacity_SetLarger_ReturnCount()
        {
            List<int> list = new List<int>(3);

            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Capacity = 5;

            Assert.AreEqual(3, list.Count, $"Expected 3 but receive {list.Count}");
        }
    }
}
