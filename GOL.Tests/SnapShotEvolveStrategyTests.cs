using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GOL.Library;

namespace GOL.Tests
{
    /// <summary>
    /// Test case for testing class SnapShotEvolveStrategy
    /// </summary>
    [TestClass]
    public class SnapShotEvolveStrategyTests
    {
        private static Grid grid;
        private static Grid gridwithoutEvolve;
        private static SnapShotEvolveStrategy snapShotEvolve;
        private static SnapShotEvolveStrategy snapShotEvolveforUpdate;

        public SnapShotEvolveStrategyTests()
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
        /// Setting up expected and actual 5x5 grids with alternate cells as true
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

            snapShotEvolve = new SnapShotEvolveStrategy(grid);

            gridwithoutEvolve = new Grid(5, 5);
            snapShotEvolveforUpdate = new SnapShotEvolveStrategy(gridwithoutEvolve);
        }

        /// <summary>
        /// test for updating a true cell to true
        /// </summary>
        [TestMethod]
        public void SnapShotEvolve_UpdateTrueToTrue()
        {

            bool cellState = true; //cell 1,1 is true

            snapShotEvolve.EvolveStrategy(grid[1, 1], true);

            Grid evolvedGrid = snapShotEvolve.GetEvolvedGrid();

            Assert.AreEqual(cellState, evolvedGrid[1, 1].IsAlive);
        }

        /// <summary>
        /// Test for updating true cell to false
        /// </summary>
        [TestMethod]
        public void SnapShotEvolve_UpdateTrueToFalse()
        {
            bool cellState = false; //cell 1,1 is true

            snapShotEvolve.EvolveStrategy(grid[1, 1], false);

            Grid evolvedGrid = snapShotEvolve.GetEvolvedGrid();

            Assert.AreEqual(cellState, evolvedGrid[1, 1].IsAlive);
        }

        /// <summary>
        /// Test for updating a False cell to true
        /// </summary>
        [TestMethod]
        public void SnapShotEvolve_UpdateFalseToTrue()
        {
            bool cellState = true; //cell 1,2 is false

            snapShotEvolve.EvolveStrategy(grid[1, 2], true);

            Grid evolvedGrid = snapShotEvolve.GetEvolvedGrid();

            Assert.AreEqual(cellState, evolvedGrid[1, 2].IsAlive);
        }

        /// <summary>
        /// Test for updating a false cell to false
        /// </summary>
        [TestMethod]
        public void SnapShotEvolve_UpdateFalseToFalse()
        {
            bool cellState = false; //cell 1,2 is true

            snapShotEvolve.EvolveStrategy(grid[1, 2], false);

            Grid evolvedGrid = snapShotEvolve.GetEvolvedGrid();

            Assert.AreEqual(cellState, evolvedGrid[1, 2].IsAlive);
        }


        [TestMethod]
        public void SnapShotEvolve_NewAndOldGridAreEqual()
        {

            int unMatchedCells = 0;
            int counter = 0;
            snapShotEvolve.EvolveStrategy(gridwithoutEvolve[0, 0], true);
            snapShotEvolve.EvolveStrategy(gridwithoutEvolve[0, 2], true);
            snapShotEvolve.EvolveStrategy(gridwithoutEvolve[0, 4], true);
            snapShotEvolve.EvolveStrategy(gridwithoutEvolve[1, 1], true);
            snapShotEvolve.EvolveStrategy(gridwithoutEvolve[1, 3], true);
            snapShotEvolve.EvolveStrategy(gridwithoutEvolve[2, 0], true);
            snapShotEvolve.EvolveStrategy(gridwithoutEvolve[2, 2], true);
            snapShotEvolve.EvolveStrategy(gridwithoutEvolve[2, 4], true);
            snapShotEvolve.EvolveStrategy(gridwithoutEvolve[3, 1], true);
            snapShotEvolve.EvolveStrategy(gridwithoutEvolve[3, 3], true);
            snapShotEvolve.EvolveStrategy(gridwithoutEvolve[4, 0], true);
            snapShotEvolve.EvolveStrategy(gridwithoutEvolve[4, 2], true);
            snapShotEvolve.EvolveStrategy(gridwithoutEvolve[4, 4], true);

            snapShotEvolveforUpdate.UpgradeGrid();

            Grid evolvedGrid = snapShotEvolveforUpdate.GetEvolvedGrid();

            for (int i = 0; i < gridwithoutEvolve.Length; i++)
                for (int j = 0; j < gridwithoutEvolve.Breath; j++)
                {
                    if (evolvedGrid[i, j].IsAlive != gridwithoutEvolve[i, j].IsAlive)
                    {
                        counter++;
                    }
                }

            Assert.AreEqual(unMatchedCells, counter);
        }
    }
}
