using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSLibraries.Structures;

namespace CSLibrariesTest.Structures
{
    [TestClass]
    public class ListTest
    {
        /*[TestMethod]
        public void Methode_Comportement_RetourAttendu()
        {

        }*/

        /**************************************************/

        [TestCategory("List Add")]
        [TestMethod]
        public void Add_AfterClear_Return1()
        {
            List<string> list = new List<string>(3);

            list.Add("1");
            list.Add("0");
            list.Add("0");
            list.Clear();

            list.Add("1");
            Assert.Equals("1", list[0]);
        }

        [TestCategory("List Add")]
        [TestMethod]
        public void Add_Default_ReturnDefault()
        {
            List<string> list = new List<string>();

            list.Add(default(string));

            Assert.AreEqual(default(string), list[0]);
        }

        [TestCategory("List Add")]
        [TestMethod]
        public void Add_OnEmpty_Return1()
        {
            List<string> list = new List<string>(3);

            list.Add("1");
            Assert.Equals("1", list[0]);
        }

        [TestCategory("List Add")]
        [TestMethod]
        public void Add_MoreThanMax_ThrowException()
        {
            List<string> list = new List<string>(3);

            list.Add("0");
            list.Add("0");
            list.Add("0");

            Assert.ThrowsException<IndexOutOfRangeException>(() => list.Add("0"));

        }

        [TestCategory("List Add")]
        [TestMethod]
        public void Add_ToMax_Return1()
        {
            List<string> list = new List<string>(3);

            list.Add("0");
            list.Add("0");
            list.Add("1");
            Assert.Equals("1", list[2]);
        }

        /**************************************************/

        [TestCategory("List Clear")]
        [TestMethod]
        public void Clear_Empty_ReturnDefault()
        {
            List<string> list = new List<string>();

            list.Clear();

            Assert.AreEqual(default(string), list[0]);

        }

        [TestCategory("List Clear")]
        [TestMethod]
        public void Clear_Full_ReturnDefault()
        {
            List<string> list = new List<string>(3);

            list.Add("0");
            list.Add("0");
            list.Add("0");
            list.Clear();

            Assert.AreEqual(default(string), list[0]);
        }

        [TestCategory("List Clear")]
        [TestMethod]
        public void Clear_SemiFull_ReturnDefault()
        {
            List<string> list = new List<string>(3);

            list.Add("0");
            list.Add("0");
            list.Clear();

            Assert.AreEqual(default(string), list[0]);
        }

        /**************************************************/

        [TestCategory("List Contains")]
        [TestMethod]
        public void Contains_AllDefault_ReturnFalse()
        {
            List<string> list = new List<string>();

            Assert.AreEqual(false, list.Contains("0"));
        }

        [TestCategory("List Contains")]
        [TestMethod]
        public void Contains_DontExist_ReturnFalse()
        {
            List<string> list = new List<string>(3);

            list.Add("1");
            list.Add("2");
            list.Add("3");

            Assert.AreEqual(false, list.Contains("0"));
        }

        [TestCategory("List Contains")]
        [TestMethod]
        public void Contains_Exist_ReturnTrue()
        {
            List<string> list = new List<string>(3);

            list.Add("1");
            list.Add("2");
            list.Add("3");

            Assert.AreEqual(true, list.Contains("2"));
        }

        /**************************************************/

        [TestCategory("List List")]
        [TestMethod]
        public void List_DefaultSize_CapacityEquals20()
        {
            List<string> list = new List<string>();

            Assert.AreEqual(20, list.Capacity);
        }

        [TestCategory("List List")]
        [TestMethod]
        public void List_Size0_CapacityEquals0()
        {
            List<string> list = new List<string>(0);

            Assert.AreEqual(0, list.Capacity);
        }


    }
}
