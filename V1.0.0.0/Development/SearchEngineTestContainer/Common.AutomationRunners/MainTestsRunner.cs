﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchEngineTestContainer.Common.AutomationSequences;

namespace SearchEngineTestContainer.Common.AutomationRunners
{
    /// <summary>
    /// Summary description for MainTestsRunner
    /// </summary> 
    [TestClass]
   [DeploymentItem("IEDriverServer.exe")]
   [DeploymentItem("chromedriver.exe")]
   [DeploymentItem("geckodriver.exe")]
   [DeploymentItem("MicrosoftWebDriver.exe")]
    public class MainTestsRunner
    {

        [TestMethod]
        public void SearchTheWeb()
        {
            var testCase = new SearchTheWeb();
            var actual = testCase.AutomationSequnce();

            Assert.AreEqual(true, actual);
        }



        #region Additional test attributes

        public MainTestsRunner()
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

    }
}