using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GOL.Library;

namespace GOL.Tests
{
    /// <summary>
    /// Test cases for testing NeigbourStrategy
    /// </summary>
    [TestClass]
    public class NeighbourStategyTests
    {
        private static Grid allDeadGrid;
        private static Grid allAliveGrid;
        private static Grid alternateAliveAndDeadGrid;
        private static NeighbourStategy neighbourStrategyAllDead;
        private static NeighbourStategy neighbourStrategyAllAlive;
        private static NeighbourStategy neighbourStrategyAlternateAliveAndDead;

        public NeighbourStategyTests()
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
        /// Setting up 3 5x5 grids. one with all false cells, another with all true cells and last with alternate cells as true and false
        /// </summary>
        /// <param name="context"></param>

        [ClassInitialize()]
        public static void GridInitialize5x5_WithAllCellsFalse(TestContext context)
        {
            allDeadGrid = new Grid(5, 5);
            allAliveGrid = new Grid(5, 5);

            for (int i = 0; i < allAliveGrid.Length; i++)
            {
                for (int j = 0; j < allAliveGrid.Breath; j++)
                {
                    allAliveGrid[i, j].IsAlive = true;
                }
            }

            alternateAliveAndDeadGrid = new Grid(5, 5);
            alternateAliveAndDeadGrid[0, 0].IsAlive = true;
            alternateAliveAndDeadGrid[0, 2].IsAlive = true;
            alternateAliveAndDeadGrid[0, 4].IsAlive = true;
            alternateAliveAndDeadGrid[1, 1].IsAlive = true;
            alternateAliveAndDeadGrid[1, 3].IsAlive = true;
            alternateAliveAndDeadGrid[2, 0].IsAlive = true;
            alternateAliveAndDeadGrid[2, 2].IsAlive = true;
            alternateAliveAndDeadGrid[2, 4].IsAlive = true;
            alternateAliveAndDeadGrid[3, 1].IsAlive = true;
            alternateAliveAndDeadGrid[3, 3].IsAlive = true;
            alternateAliveAndDeadGrid[4, 0].IsAlive = true;
            alternateAliveAndDeadGrid[4, 2].IsAlive = true;
            alternateAliveAndDeadGrid[4, 4].IsAlive = true;
            neighbourStrategyAllDead = new NeighbourStategy(allDeadGrid);
            neighbourStrategyAllAlive = new NeighbourStategy(allAliveGrid);
            neighbourStrategyAlternateAliveAndDead = new NeighbourStategy(alternateAliveAndDeadGrid);
        }


        [TestMethod]
        public void NeighbourStategyAllDead_CheckCountofAliveNeighbourforFirstRowFirstColumnCellEqualsZero()
        {
            int countOfNeighbours = 0;

            int returnValue = neighbourStrategyAllDead.GetCountofCellNeighbours(allDeadGrid[0, 0]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllDead_CheckCountofAliveNeighbourforFirstRowSecondColumnCellEqualsZero()
        {
            int countOfNeighbours = 0;

            int returnValue = neighbourStrategyAllDead.GetCountofCellNeighbours(allDeadGrid[0, 1]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllDead_CheckCountofAliveNeighbourforFirstRowThirdColumnCellEqualsZero()
        {
            int countOfNeighbours = 0;

            int returnValue = neighbourStrategyAllDead.GetCountofCellNeighbours(allDeadGrid[0, 2]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllDead_CheckCountofAliveNeighbourforFirstRowFourthColumnCellEqualsZero()
        {
            int countOfNeighbours = 0;

            int returnValue = neighbourStrategyAllDead.GetCountofCellNeighbours(allDeadGrid[0, 3]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        
        public void NeighbourStategyAllDead_CheckCountofAliveNeighbourforFirstRowFifthColumnCellEqualsZero()
        {
            int countOfNeighbours = 0;

            int returnValue = neighbourStrategyAllDead.GetCountofCellNeighbours(allDeadGrid[0, 4]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NeighbourStategyAllDead_CheckCountofAliveNeighbourforFirstRowSixthColumnCellEqualsZero()
        {
            

            int returnValue = neighbourStrategyAllDead.GetCountofCellNeighbours(allDeadGrid[0, 5]);

            
        }

        [TestMethod]
        public void NeighbourStategyAllDead_CheckCountofAliveNeighbourforSecondRowFirstColumnCellEqualsZero()
        {
            int countOfNeighbours = 0;

            int returnValue = neighbourStrategyAllDead.GetCountofCellNeighbours(allDeadGrid[1, 0]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllDead_CheckCountofAliveNeighbourforSecondRowSecondColumnCellEqualsZero()
        {
            int countOfNeighbours = 0;

            int returnValue = neighbourStrategyAllDead.GetCountofCellNeighbours(allDeadGrid[1, 1]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllDead_CheckCountofAliveNeighbourforSecondRowThirdColumnCellEqualsZero()
        {
            int countOfNeighbours = 0;

            int returnValue = neighbourStrategyAllDead.GetCountofCellNeighbours(allDeadGrid[1, 2]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllDead_CheckCountofAliveNeighbourforSecondRowFourthColumnCellEqualsZero()
        {
            int countOfNeighbours = 0;

            int returnValue = neighbourStrategyAllDead.GetCountofCellNeighbours(allDeadGrid[1, 3]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllDead_CheckCountofAliveNeighbourforSecondRowFifthColumnCellEqualsZero()
        {
            int countOfNeighbours = 0;

            int returnValue = neighbourStrategyAllDead.GetCountofCellNeighbours(allDeadGrid[1, 4]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllDead_CheckCountofAliveNeighbourforFifthRowFirstColumnCellEqualsZero()
        {
            int countOfNeighbours = 0;

            int returnValue = neighbourStrategyAllDead.GetCountofCellNeighbours(allDeadGrid[4, 0]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllDead_CheckCountofAliveNeighbourforFifthRowSecondColumnCellEqualsZero()
        {
            int countOfNeighbours = 0;

            int returnValue = neighbourStrategyAllDead.GetCountofCellNeighbours(allDeadGrid[4, 1]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllDead_CheckCountofAliveNeighbourforFifthRowThirdColumnCellEqualsZero()
        {
            int countOfNeighbours = 0;

            int returnValue = neighbourStrategyAllDead.GetCountofCellNeighbours(allDeadGrid[4, 2]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllDead_CheckCountofAliveNeighbourforFifthRowFourthColumnCellEqualsZero()
        {
            int countOfNeighbours = 0;

            int returnValue = neighbourStrategyAllDead.GetCountofCellNeighbours(allDeadGrid[4, 3]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllDead_CheckCountofAliveNeighbourforFifthRowFifthColumnCellEqualsZero()
        {
            int countOfNeighbours = 0;

            int returnValue = neighbourStrategyAllDead.GetCountofCellNeighbours(allDeadGrid[4, 4]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }
        //
        [TestMethod]
        public void NeighbourStategyAllAlive_CheckCountofAliveNeighbourforFirstRowFirstColumnCellEqualsZero()
        {
            int countOfNeighbours = 3;

            int returnValue = neighbourStrategyAllAlive.GetCountofCellNeighbours(allAliveGrid[0, 0]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllAlive_CheckCountofAliveNeighbourforFirstRowSecondColumnCellEqualsZero()
        {
            int countOfNeighbours = 5;

            int returnValue = neighbourStrategyAllAlive.GetCountofCellNeighbours(allAliveGrid[0, 1]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllAlive_CheckCountofAliveNeighbourforFirstRowThirdColumnCellEqualsZero()
        {
            int countOfNeighbours = 5;

            int returnValue = neighbourStrategyAllAlive.GetCountofCellNeighbours(allAliveGrid[0, 2]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllAlive_CheckCountofAliveNeighbourforFirstRowFourthColumnCellEqualsZero()
        {
            int countOfNeighbours = 5;

            int returnValue = neighbourStrategyAllAlive.GetCountofCellNeighbours(allAliveGrid[0, 3]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllAlive_CheckCountofAliveNeighbourforFirstRowFifthColumnCellEqualsZero()
        {
            int countOfNeighbours = 3;

            int returnValue = neighbourStrategyAllAlive.GetCountofCellNeighbours(allAliveGrid[0, 4]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NeighbourStategyAllAlive_CheckCountofAliveNeighbourforFirstRowSixthColumnCellEqualsZero()
        {
            

            int returnValue = neighbourStrategyAllAlive.GetCountofCellNeighbours(allAliveGrid[0, 5]);

            
        }

        [TestMethod]
        public void NeighbourStategyAllAlive_CheckCountofAliveNeighbourforSecondRowFirstColumnCellEqualsZero()
        {
            int countOfNeighbours = 5;

            int returnValue = neighbourStrategyAllAlive.GetCountofCellNeighbours(allAliveGrid[1, 0]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllAlive_CheckCountofAliveNeighbourforSecondRowSecondColumnCellEqualsZero()
        {
            int countOfNeighbours = 8;

            int returnValue = neighbourStrategyAllAlive.GetCountofCellNeighbours(allAliveGrid[1, 1]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllAlive_CheckCountofAliveNeighbourforSecondRowThirdColumnCellEqualsZero()
        {
            int countOfNeighbours = 8;

            int returnValue = neighbourStrategyAllAlive.GetCountofCellNeighbours(allAliveGrid[1, 2]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllAlive_CheckCountofAliveNeighbourforSecondRowFourthColumnCellEqualsZero()
        {
            int countOfNeighbours = 8;

            int returnValue = neighbourStrategyAllAlive.GetCountofCellNeighbours(allAliveGrid[1, 3]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllAlive_CheckCountofAliveNeighbourforSecondRowFifthColumnCellEqualsZero()
        {
            int countOfNeighbours = 5;

            int returnValue = neighbourStrategyAllAlive.GetCountofCellNeighbours(allAliveGrid[1, 4]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllAlive_CheckCountofAliveNeighbourforFifthRowFirstColumnCellEqualsZero()
        {
            int countOfNeighbours = 3;

            int returnValue = neighbourStrategyAllAlive.GetCountofCellNeighbours(allAliveGrid[4, 0]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllAlive_CheckCountofAliveNeighbourforFifthRowSecondColumnCellEqualsZero()
        {
            int countOfNeighbours = 5;

            int returnValue = neighbourStrategyAllAlive.GetCountofCellNeighbours(allAliveGrid[4, 1]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllAlive_CheckCountofAliveNeighbourforFifthRowThirdColumnCellEqualsZero()
        {
            int countOfNeighbours = 5;

            int returnValue = neighbourStrategyAllAlive.GetCountofCellNeighbours(allAliveGrid[4, 2]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllAlive_CheckCountofAliveNeighbourforFifthRowFourthColumnCellEqualsZero()
        {
            int countOfNeighbours = 5;

            int returnValue = neighbourStrategyAllAlive.GetCountofCellNeighbours(allAliveGrid[4, 3]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllAlive_CheckCountofAliveNeighbourforFifthRowFifthColumnCellEqualsZero()
        {
            int countOfNeighbours = 3;

            int returnValue = neighbourStrategyAllAlive.GetCountofCellNeighbours(allAliveGrid[4, 4]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }
        ////
        [TestMethod]
        public void NeighbourStategyAlternateAliveAndDead_CheckCountofAliveNeighbourforFirstRowFirstColumnCellEqualsZero()
        {
            int countOfNeighbours = 1;

            int returnValue = neighbourStrategyAlternateAliveAndDead.GetCountofCellNeighbours(allAliveGrid[0, 0]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAlternateAliveAndDead_CheckCountofAliveNeighbourforFirstRowSecondColumnCellEqualsZero()
        {
            int countOfNeighbours = 3;

            int returnValue = neighbourStrategyAlternateAliveAndDead.GetCountofCellNeighbours(allAliveGrid[0, 1]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAlternateAliveAndDead_CheckCountofAliveNeighbourforFirstRowThirdColumnCellEqualsZero()
        {
            int countOfNeighbours = 2;

            int returnValue = neighbourStrategyAlternateAliveAndDead.GetCountofCellNeighbours(allAliveGrid[0, 2]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAlternateAliveAndDead_CheckCountofAliveNeighbourforFirstRowFourthColumnCellEqualsZero()
        {
            int countOfNeighbours = 3;

            int returnValue = neighbourStrategyAlternateAliveAndDead.GetCountofCellNeighbours(allAliveGrid[0, 3]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAlternateAliveAndDead_CheckCountofAliveNeighbourforFirstRowFifthColumnCellEqualsZero()
        {
            int countOfNeighbours = 1;

            int returnValue = neighbourStrategyAlternateAliveAndDead.GetCountofCellNeighbours(allAliveGrid[0, 4]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NeighbourStategyAlternateAliveAndDead_CheckCountofAliveNeighbourforFirstRowSixthColumnCellEqualsZero()
        {
            

            int returnValue = neighbourStrategyAlternateAliveAndDead.GetCountofCellNeighbours(allAliveGrid[0, 5]);

            
        }

        [TestMethod]
        public void NeighbourStategyAlternateAliveAndDead_CheckCountofAliveNeighbourforSecondRowFirstColumnCellEqualsZero()
        {
            int countOfNeighbours = 3;

            int returnValue = neighbourStrategyAlternateAliveAndDead.GetCountofCellNeighbours(allAliveGrid[1, 0]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAlternateAliveAndDead_CheckCountofAliveNeighbourforSecondRowSecondColumnCellEqualsZero()
        {
            int countOfNeighbours = 4;

            int returnValue = neighbourStrategyAlternateAliveAndDead.GetCountofCellNeighbours(allAliveGrid[1, 1]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAlternateAliveAndDead_CheckCountofAliveNeighbourforSecondRowThirdColumnCellEqualsZero()
        {
            int countOfNeighbours = 4;

            int returnValue = neighbourStrategyAlternateAliveAndDead.GetCountofCellNeighbours(allAliveGrid[1, 2]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAllAlternateAliveAndDead_CheckCountofAliveNeighbourforSecondRowFourthColumnCellEqualsZero()
        {
            int countOfNeighbours = 4;

            int returnValue = neighbourStrategyAlternateAliveAndDead.GetCountofCellNeighbours(allAliveGrid[1, 3]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAlternateAliveAndDead_CheckCountofAliveNeighbourforSecondRowFifthColumnCellEqualsZero()
        {
            int countOfNeighbours = 3;

            int returnValue = neighbourStrategyAlternateAliveAndDead.GetCountofCellNeighbours(allAliveGrid[1, 4]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAlternateAliveAndDead_CheckCountofAliveNeighbourforFifthRowFirstColumnCellEqualsZero()
        {
            int countOfNeighbours = 1;

            int returnValue = neighbourStrategyAlternateAliveAndDead.GetCountofCellNeighbours(allAliveGrid[4, 0]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAlternateAliveAndDead_CheckCountofAliveNeighbourforFifthRowSecondColumnCellEqualsZero()
        {
            int countOfNeighbours = 3;

            int returnValue = neighbourStrategyAlternateAliveAndDead.GetCountofCellNeighbours(allAliveGrid[4, 1]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAlternateAliveAndDead_CheckCountofAliveNeighbourforFifthRowThirdColumnCellEqualsZero()
        {
            int countOfNeighbours = 2;

            int returnValue = neighbourStrategyAlternateAliveAndDead.GetCountofCellNeighbours(allAliveGrid[4, 2]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAlternateAliveAndDead_CheckCountofAliveNeighbourforFifthRowFourthColumnCellEqualsZero()
        {
            int countOfNeighbours = 3;

            int returnValue = neighbourStrategyAlternateAliveAndDead.GetCountofCellNeighbours(allAliveGrid[4, 3]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }

        [TestMethod]
        public void NeighbourStategyAlternateAliveAndDead_CheckCountofAliveNeighbourforFifthRowFifthColumnCellEqualsZero()
        {
            int countOfNeighbours = 1;

            int returnValue = neighbourStrategyAlternateAliveAndDead.GetCountofCellNeighbours(allAliveGrid[4, 4]);

            Assert.AreEqual(countOfNeighbours, returnValue);
        }


    }
}
