using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GOL.Library;

namespace GOL.Tests
{
    /// <summary>
    /// Test cases for Entity Grid class
    /// </summary>
    [TestClass]
    public class GridTests
    {


        private static Grid grid5x5;
        private static Grid grid0x0;

        public GridTests()
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

        /// <summary>
        /// Initialize a 5x5 grid with all false cells
        /// </summary>
        /// <param name="context"></param>
        [ClassInitialize()]
        public static void GridInitialize5x5_WithAllCellsFalse(TestContext context)
        {
            grid5x5 = new Grid(5, 5);
            grid0x0 = new Grid(0, 0);
        }

        /// <summary>
        /// Test case for checking the count for a 5x5 grid
        /// </summary>
        [TestMethod]
        public void GridCellsCount_5x5()
        {
            int countOfCells = 25;
            int counter = 0;
            for (int i = 0; i < grid5x5.Length; i++)
            {
                for (int j = 0; j < grid5x5.Breath; j++)
                {
                    counter++;
                }
            }

            Assert.AreEqual(countOfCells, counter);
        }

        /// <summary>
        /// Test case for checking the count for a 0x0 grid
        /// </summary>
        [TestMethod]
        public void GridCellsCount_0x0()
        {
            int countOfCells = 0;
            int counter = 0;
            for (int i = 0; i < grid0x0.Length; i++)
            {
                for (int j = 0; j < grid0x0.Breath; j++)
                {
                    counter++;
                }
            }

            Assert.AreEqual(countOfCells, counter);
        }
    }
}
