using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void startTest()
        {
            Browsers.Init();
        }

        [TestMethod]
        public void blogTest()
        {
            //bool flag = driver.Title.Contains("TestProject");
            //driver.FindElement(By.Name("your-name")).SendKeys("Test");
            //Assert.IsTrue(flag);
        }

        [TestCleanup]
        public void endtest()
        {
            Browsers.Close();

            FirefoxProfile profile = new FirefoxProfile();
            profile.AcceptUntrustedCertificates = true; 
        }
    }
}
