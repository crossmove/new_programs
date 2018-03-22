using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;


namespace SeleniumProject
{
    [TestClass]
    public class ElementProperties
    {
        [TestMethod]
        public void _ElementPropertiesSelenium()
        {
            IWebDriver driver = new ChromeDriver("");

            IWebElement elem = driver.FindElement(By.Id(""));

            //The below 2 codes are same
            ReadOnlyCollection<IWebElement> elemList1 = driver.FindElements(By.ClassName("classNameXX"));
            IList<IWebElement> elemList2 = driver.FindElements(By.ClassName("classNameXX"));

            //How to get attribute of the element
            string id = elem.GetAttribute("id");
            string attrVal = elem.GetAttribute("class");
            string cssValue = elem.GetCssValue("style");

            elem.Clear();
            elem.Click();

            bool visible = elem.Displayed;
            bool enabled = elem.Enabled;
            bool selected = elem.Selected;
            Point location = elem.Location;

            elem.SendKeys("pradeep.exe@gmail.com");

            Size size = elem.Size;

            elem.Submit();

            string tagName = elem.TagName;
            string text = elem.Text;
        }

    }
}
