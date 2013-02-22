using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using GOL.Library;
namespace GOL.Tests
{
    /// <summary>
    /// This function tests the outcome of calling the function EmulateGOL. A grid with 3 central vertical cells as true are given as input to the test function.
    /// The expected output is a 3 horizantal cells instead of 3 vertical cells.
    /// </summary>
    [TestClass]
    public class GameofLifeManagerTests
    {

        private static Grid grid;
        private static Grid expectedGrid;
        private static GameofLifeManager gameofLifeManager;

        public GameofLifeManagerTests()
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
        /// Initialize 2 grids. expected grid is horizontal 3 cells as true.
        /// </summary>
        /// <param name="context"></param>
        [ClassInitialize()]
        public static void GridInitialize5x5_WithAll3VerticalCellsTrue(TestContext context)
        {
            expectedGrid = new Grid(5, 5);
            expectedGrid[2, 1].IsAlive = true;
            expectedGrid[2, 2].IsAlive = true;
            expectedGrid[2, 3].IsAlive = true;


            grid = new Grid(5, 5);

            gameofLifeManager = new GameofLifeManager(grid, EvolveType.SnapShot);
            
        }

        /// <summary>
        /// Test case for matching 2 grids for equality
        /// </summary>
        [TestMethod]
        public void GameofLifeManager_EmulateGOL()
        {
            grid[1, 2].IsAlive = true;
            grid[2, 2].IsAlive = true;
            grid[3, 2].IsAlive = true;

            gameofLifeManager.EmulateGOL();

            int countOfCells = 25;
            int counter = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid.Breath; j++)
                {
                    if (expectedGrid[i, j].IsAlive == grid[i, j].IsAlive)
                    {
                        counter++;
                    }
                }
            }

            Assert.AreEqual(countOfCells, counter);
          
        }
    }
}
