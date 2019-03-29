using System;
using CSLibraries.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSLibrariesTest.Structures.List
{
    /// <summary>
    /// Test class for CSLibrariesTest.Structures.List.ToString().
    /// </summary>
    [TestClass]
    public class ToStringListTest
    {
        /// <summary>
        /// This test attempts to see if ToString function will return "| |" after clearing a list.
        /// </summary>
        [TestMethod]
        public void ToString_AfterClear_ReturnString()
        {
            List<string> list = new List<string>();

            list.Add("a");
            list.Add("a");
            list.Add("a");
            list.Clear();

            Assert.AreEqual("| |", list.ToString(), $"Expected '| |' and recieve '{list.ToString()}'");
        }

        /// <summary>
        /// This test attempts to see if ToString function will return a correct string using complex type of data with null adresse.
        /// </summary>
        [TestMethod]
        public void ToString_ComplexeObject_ReturnString()
        {
            List<Tuple<int>> list = new List<Tuple<int>>(3);

            list.Add(new Tuple<int>(0));
            list.Add(default(Tuple<int>));
            list.Add(new Tuple<int>(0));

            Assert.AreEqual("| (0) |  | (0) |", list.ToString(), $"Expected '| (0) |  | (0) |' and recieve '{list.ToString()}'");
        }

        /// <summary>
        /// This test attempts to see if ToString function will return "| |" for empty list.
        /// </summary>
        [TestMethod]
        public void ToString_Empty_ReturnString()
        {
            List<string> list = new List<string>();

            Assert.AreEqual("| |", list.ToString(), $"Expected '| |' and recieve '{list.ToString()}'");
        }

        /// <summary>
        /// This test attempts to see if ToString function will return the true content of a full list with mixed normal and default values.
        /// </summary>
        [TestMethod]
        public void ToString_Full_ReturnString()
        {
            List<string> list = new List<string>(3);

            list.Add("a");
            list.Add(default(string));
            list.Add("a");

            Assert.AreEqual("| a |  | a |", list.ToString(), $"Expected '| a |  | a |' and recieve '{list.ToString()}'");
        }

        /// <summary>
        /// This test attempts to see if ToString function will return the true content of a semifull list with mixed normal and default values.
        /// </summary>
        [TestMethod]
        public void ToString_Semifull_ReturnString()
        {
            List<string> list = new List<string>();

            list.Add("a");
            list.Add(default(string));
            list.Add("a");

            Assert.AreEqual("| a |  | a |", list.ToString(), $"Expected '| a |  | a |' and recieve '{list.ToString()}'");
        }
    }
}
