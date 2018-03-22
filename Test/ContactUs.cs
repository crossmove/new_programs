using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using System.IO;
using Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;

namespace Test
{
    public class ContactUs
    {
        //Elements Identification of the page

        [FindsBy(How = How.Name, Using = "your-name")]
        private IWebElement yourName;
        [FindsBy(How = How.Name, Using = "your-email")]
        private IWebElement yourEmail;
        [FindsBy(How = How.Name, Using = "your-subject")]
        private IWebElement yourSubject;
        [FindsBy(How = How.Name, Using = "your-message")]
        private IWebElement yourMessage;

        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        private IWebElement submit;

        [FindsBy(How = How.ClassName, Using = "wpcf7-response-output")]
        private IWebElement SuccMessage;
        [FindsBy(How = How.Id, Using = "menu-item-1296")]
        private IWebElement contactUs;


        //Functions performing on these elements are below

        public bool isAt()
        {
            return Browsers.Title.Contains("Contact Us");
        }
        public void GoTo()
        {
            contactUs.Click();
        }
        public void SendYourName(string name)
        {
            yourName.SendKeys(name);
        }
        public void SendYourEmail(string email)
        {
            yourEmail.SendKeys(email);
        }
        public void SendYourSubject(string Subject)
        {
            yourSubject.SendKeys(Subject);
        }
        public void SendYourMessage(string message)
        {
            yourMessage.SendKeys(message);
        }
        public void clickSubmit()
        {
           // WebElement element = driver.findElement(By("element"));
            Actions action = new Actions(Browsers.getDriver);
            action.MoveToElement(submit).Click().Perform();
        }
        public void ValidateMessage()
        {
            try
            {
                var text = SuccMessage.Text;
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        public void filldatafromCsv()
        {
            string filePath = @"C:\Users\TestProject\Desktop\runFile.csv";
            List<string> data = new List<string>();
            data = Servers.general.loadCsvFile(filePath);
            for (int i = 0; i < data.Count; i++)
            {
                var values = data[i].Split(';');
                SendYourName(values[0]);
                SendYourEmail(values[1]);
                SendYourSubject(values[2]);
                SendYourMessage(values[3]);
                clickSubmit();
                ValidateMessage();
            }
        }
    }
}