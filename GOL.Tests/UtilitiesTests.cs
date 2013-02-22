using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GOL.Library;

namespace GOL.Tests
{
    /// <summary>
    /// Test Cases for testing the utilities class
    /// </summary>
    [TestClass]
    public class UtilitiesTests
    {
        public UtilitiesTests()
        {
            
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
        /// Test for function IsNumeric with valid values
        /// </summary>
        [TestMethod]
        public void IsNumeric_ValidValue()
        {
            bool expectedState = true;
            bool actualState = Utilities.isNumeric("10");
            Assert.AreEqual(expectedState, actualState);
        }

        /// <summary>
        /// Test for function Isnumeric with invalid value
        /// </summary>
        [TestMethod]
        public void IsNumeric_InValidValue()
        {
            bool expectedState = false;
            bool actualState = Utilities.isNumeric("A");
            Assert.AreEqual(expectedState, actualState);
        }

        /// <summary>
        /// Test for checking function GetStringArrayFromDelimitedString with valid value
        /// </summary>
        [TestMethod]
        public void GetStringArrayFromDelimitedString_ValidValue()
        {
            string inputString = "1,2,3,4,5,6";
            char[] delimiter = new char[] { ',' };
            int expectedArrayLength = 6;
            string[] returnArray = Utilities.GetStringArrayFromDelimitedString(inputString, delimiter);
            Assert.AreEqual(expectedArrayLength, returnArray.Length);
        }

    }
}
