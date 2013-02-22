using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GOL.Library;

namespace GOL.Tests
{
    /// <summary>
    /// Summary description for AliveCellsRulesEngineTests
    /// </summary>
    [TestClass]
    public class AliveCellsRulesEngineTests
    {
        public AliveCellsRulesEngineTests()
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
        public void AliveCellExecuteRule_WithCountofNeighbourEqualsOne()
        {
            int countOfNeighbours = 1;
            AliveCellsRulesEngine aliveCellsRulesEngine = new AliveCellsRulesEngine();
            bool returnValue = aliveCellsRulesEngine.ExecuteRule(countOfNeighbours);
            Assert.AreEqual(false, returnValue);
        }

        [TestMethod]
        public void AliveCellExecuteRule_WithCountofNeighbourEqualsTwo()
        {
            int countOfNeighbours = 2;
            AliveCellsRulesEngine aliveCellsRulesEngine = new AliveCellsRulesEngine();
            bool returnValue = aliveCellsRulesEngine.ExecuteRule(countOfNeighbours);
            Assert.AreEqual(true, returnValue);
        }

        [TestMethod]
        public void AliveCellExecuteRule_WithCountofNeighbourEqualsThree()
        {
            int countOfNeighbours = 3;
            AliveCellsRulesEngine aliveCellsRulesEngine = new AliveCellsRulesEngine();
            bool returnValue = aliveCellsRulesEngine.ExecuteRule(countOfNeighbours);
            Assert.AreEqual(true, returnValue);
        }

        [TestMethod]
        public void AliveCellExecuteRule_WithCountofNeighbourEqualsFour()
        {
            int countOfNeighbours = 4;
            AliveCellsRulesEngine aliveCellsRulesEngine = new AliveCellsRulesEngine();
            bool returnValue = aliveCellsRulesEngine.ExecuteRule(countOfNeighbours);
            Assert.AreEqual(false, returnValue);
        }

        [TestMethod]
        public void AliveCellExecuteRule_WithCountofNeighbourEqualsFive()
        {
            int countOfNeighbours = 5;
            AliveCellsRulesEngine aliveCellsRulesEngine = new AliveCellsRulesEngine();
            bool returnValue = aliveCellsRulesEngine.ExecuteRule(countOfNeighbours);
            Assert.AreEqual(false, returnValue);
        }

        [TestMethod]
        public void AliveCellExecuteRule_WithCountofNeighbourEqualsSix()
        {
            int countOfNeighbours = 6;
            AliveCellsRulesEngine aliveCellsRulesEngine = new AliveCellsRulesEngine();
            bool returnValue = aliveCellsRulesEngine.ExecuteRule(countOfNeighbours);
            Assert.AreEqual(false, returnValue);
        }

        [TestMethod]
        public void AliveCellExecuteRule_WithCountofNeighbourEqualsSeven()
        {
            int countOfNeighbours = 7;
            AliveCellsRulesEngine aliveCellsRulesEngine = new AliveCellsRulesEngine();
            bool returnValue = aliveCellsRulesEngine.ExecuteRule(countOfNeighbours);
            Assert.AreEqual(false, returnValue);
        }

        [TestMethod]
        public void AliveCellExecuteRule_WithCountofNeighbourEqualsEight()
        {
            int countOfNeighbours = 8;
            AliveCellsRulesEngine aliveCellsRulesEngine = new AliveCellsRulesEngine();
            bool returnValue = aliveCellsRulesEngine.ExecuteRule(countOfNeighbours);
            Assert.AreEqual(false, returnValue);
        }

        [TestMethod]
        public void AliveCellExecuteRule_WithCountofNeighbourEqualsNine()
        {
            int countOfNeighbours = 9;
            AliveCellsRulesEngine aliveCellsRulesEngine = new AliveCellsRulesEngine();
            bool returnValue = aliveCellsRulesEngine.ExecuteRule(countOfNeighbours);
            Assert.AreEqual(false, returnValue);
        }

        [TestMethod]
        public void AliveCellExecuteRule_WithCountofNeighbourEqualsHundred()
        {
            int countOfNeighbours = 100;
            AliveCellsRulesEngine aliveCellsRulesEngine = new AliveCellsRulesEngine();
            bool returnValue = aliveCellsRulesEngine.ExecuteRule(countOfNeighbours);
            Assert.AreEqual(false, returnValue);
        }

    }
}
