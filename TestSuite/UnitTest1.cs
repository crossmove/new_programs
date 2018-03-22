using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Collections.Generic;
using Test;
namespace AutomatedTestCases
{
    //https://github.com/Apress/selenium-webdriver-recipes-in-csharp
    [TestClass]
    public class Sanity 
    {
        [TestMethod]
        public void ClickContactUs()
        {
            Browsers.Init();
            Browsers.getDriver.FindElement(By.Id("menu-item-1296")).Click();
        }

        [TestMethod]
        public void ContactUsTestflow21()
        {
            Browsers.Init();
            Pages.contactUs.GoTo();//
            Assert.IsTrue(Pages.contactUs.isAt());

            Pages.contactUs.SendYourName("Asya test");
            Pages.contactUs.SendYourEmail("TestProject@testproject.com");
            Pages.contactUs.SendYourSubject("Test");
            Pages.contactUs.SendYourMessage("Test 123");
            Pages.contactUs.clickSubmit();
            Pages.contactUs.ValidateMessage();
            
        }
        
    }
}