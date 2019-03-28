using System;
using CSLibraries.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSLibrariesTest.Structures.List
{
    /// <summary>
    /// Test class for CSLibrariesTest.Structures.List.ToString()
    /// </summary>
    [TestClass]
    public class ToStringListTest
    {
        /// <summary>
        /// This test atempt to see if ToString function will return "| |" after clearing a list.
        /// </summary>
        [TestMethod]
        public void ToString_AfterClear_Test()
        {
            List<string> list = new List<string>();

            list.Add("a");
            list.Add("a");
            list.Add("a");
            list.Clear();

            Assert.AreEqual("| |", list.ToString(), $"Expected '| |' and recieve '{list.ToString()}'");
        }

        /// <summary>
        /// This test atempt to see if ToString function will return "| |" for empty list.
        /// </summary>
        [TestMethod]
        public void ToString_Empty_Test()
        {
            List<string> list = new List<string>();

            Assert.AreEqual("| |", list.ToString(), $"Expected '| |' and recieve '{list.ToString()}'");
        }

        /// <summary>
        /// This test atempt to see if ToString function will return the true content of a full list with mixed normal and default values.
        /// </summary>
        [TestMethod]
        public void ToString_Full_Test()
        {
            List<string> list = new List<string>(3);

            list.Add("a");
            list.Add(default(string));
            list.Add("a");

            Assert.AreEqual("| a |  | a |", list.ToString(), $"Expected '| a |  | a |' and recieve '{list.ToString()}'");
        }

        /// <summary>
        /// This test atempt to see if ToString function will return the true content of a semifull list with mixed normal and default values.
        /// </summary>
        [TestMethod]
        public void ToString_Semifull_Test()
        {
            List<string> list = new List<string>();

            list.Add("a");
            list.Add(default(string));
            list.Add("a");

            Assert.AreEqual("| a |  | a |", list.ToString(), $"Expected '| a |  | a |' and recieve '{list.ToString()}'");
        }
    }
}
