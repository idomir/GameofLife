using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GOL.Library;

namespace GOL.Tests
{
    /// <summary>
    /// Summary description for CellTests
    /// </summary>
    [TestClass]
    public class CellTests
    {
        public CellTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Cell1x1_RowValueCheck()
        {
            Cell cell = new Cell(1, 1, true);
            int countofRows = 1;
            Assert.AreEqual(countofRows, cell.RowNumber);
        }

        [TestMethod]
        public void Cell1x1_ColValueCheck()
        {
            Cell cell = new Cell(1, 1, true);
            int countofColumns = 1;
            Assert.AreEqual(countofColumns, cell.ColumnNumber);
        }

        [TestMethod]
        public void Cell1x1_IsAliveTrueValueCheck()
        {
            Cell cell = new Cell(1, 1, true);
            bool isAlive = true;
            Assert.AreEqual(isAlive, cell.IsAlive);
        }

        [TestMethod]
        public void Cell1x1_IsAliveFalseValueCheck()
        {
            Cell cell = new Cell(1, 1, false);
            bool isAlive = false;
            Assert.AreEqual(isAlive, cell.IsAlive);
        }

    }
}
