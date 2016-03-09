using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_FrameWork;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void Can_Go_To_HomePage()
        {
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt());
        }

        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}
