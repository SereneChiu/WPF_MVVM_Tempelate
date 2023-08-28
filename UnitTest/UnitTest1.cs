using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConfiguratorLibrary;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private IConfiguratorLibraryService mService = new ConfiguratorLibraryService();
        private object obj = null;

        [TestMethod]
        public void TestItem1()
        {
            InitTest();
            Assert.AreEqual(mService.LoadResult, true, "Test fail.");
        }

        private void InitTest()
        {
            obj = mService.MainPage;
        }

        private void ResetTest()
        {
            mService = null;
            mService = new ConfiguratorLibraryService();
        }


    }
}
