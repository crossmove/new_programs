using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class ReportsManager
    {
        Reports report;
        string browser;
        string url;
        IWebDriver driver = Browsers.getDriver;
        public ReportsManager(string browser, string url)
        {
            this.browser = browser;
            this.url = url;
            report = new Reports(browser, url);
        }
        public void verifyURL(string url)
        {
            string PageURL = driver.Url;
            string message = "The Current Url and Expected Url are not equals";
            if (PageURL.Equals(url))
                report.addLine("Verify url", "PASS", "Url are Equals");
            else
                report.addLine("Verify url", "FAIL", message);
            //Assert.AreEqual(PageURL, url, message);
        }
        public void verifyElementNotAppear(IWebElement element)
        {
            if (!element.Displayed)
            {
                string message = "Element does not exist";
                Assert.Fail(message);
                addLog("Looking For Element" + element + "", "FAIL", element + " Should Be On The Page");
            }
        }
        public void addLog(string des, string res, string exp)
        {
            report.addLine(des, res, exp);
        }
    }
}
