using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GOL.Library;

namespace GOL.Tests
{
    /// <summary>
    ///Test case for testing class InPlaceEvolveStrategy
    /// </summary>
    [TestClass]
    public class InPlaceEvolveStrategyTests
    {
        private static Grid grid;
        private static InPlaceEvolveStrategy inPlaceEvolve;

        public InPlaceEvolveStrategyTests()
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
        /// Initialize 5x5 grid with all cells as false
        /// </summary>
        /// <param name="context"></param>
        [ClassInitialize()]
        public static void GridInitialize5x5_WithAllCellsFalse(TestContext context)
        {
            grid = new Grid(5, 5);
            grid[0, 0].IsAlive = true;
            grid[0, 2].IsAlive = true;
            grid[0, 4].IsAlive = true;
            grid[1, 1].IsAlive = true;
            grid[1, 3].IsAlive = true;
            grid[2, 0].IsAlive = true;
            grid[2, 2].IsAlive = true;
            grid[2, 4].IsAlive = true;
            grid[3, 1].IsAlive = true;
            grid[3, 3].IsAlive = true;
            grid[4, 0].IsAlive = true;
            grid[4, 2].IsAlive = true;
            grid[4, 4].IsAlive = true;

            inPlaceEvolve = new InPlaceEvolveStrategy(grid);
        }

        /// <summary>
        /// Test case for updating a true cell to true
        /// </summary>
        [TestMethod]
        public void InPlaceEvolve_UpdateTrueToTrue()
        {
            bool cellState = true; //cell 1,1 is true

            inPlaceEvolve.EvolveStrategy(grid[1, 1], true);

            Assert.AreEqual(cellState, grid[1, 1].IsAlive);
        }

        /// <summary>
        /// Test case for updating a true cell to false
        /// </summary>
        [TestMethod]
        public void InPlaceEvolve_UpdateTrueToFalse()
        {
            bool cellState = false; //cell 1,1 is true

            inPlaceEvolve.EvolveStrategy(grid[1, 1], false);

            Assert.AreEqual(cellState, grid[1, 1].IsAlive);
        }

        /// <summary>
        /// Test case for updating a false cell to true
        /// </summary>
        [TestMethod]
        public void InPlaceEvolve_UpdateFalseToTrue()
        {
            bool cellState = true; //cell 1,2 is false

            inPlaceEvolve.EvolveStrategy(grid[1, 2], true);

            Assert.AreEqual(cellState, grid[1, 2].IsAlive);
        }

        /// <summary>
        /// Test case for updating a false cell to false
        /// </summary>
        [TestMethod]
        public void InPlaceEvolve_UpdateFalseToFalse()
        {
            bool cellState = false; //cell 1,2 is true

            inPlaceEvolve.EvolveStrategy(grid[1, 2], false);

            Assert.AreEqual(cellState, grid[1, 2].IsAlive);
        }
    }
}
