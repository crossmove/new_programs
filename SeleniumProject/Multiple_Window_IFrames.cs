using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using System.Linq;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject
{
    /// <summary>
    /// Summary description for MultipleWindowHandling
    /// </summary>
    [TestClass]
    public class Multiple_Window_IFrames
    {
        //To move out of frame use:- driver.switchTo().defaultContent();
               
        [TestMethod] 
        public void MultipleWindow()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://toolsqa.com/automation-practice-switch-windows/";

            // Store the parent window of the driver
            String parentWindowHandle = driver.CurrentWindowHandle;  //op CDwindow-(B4655399AA945CC388D6AD9F6CB59E65)
            Console.WriteLine("Parent window's handle -> " + parentWindowHandle);

            IWebElement clickElement = driver.FindElement(By.Id("button1"));

            // Multiple click to open multiple window
            for (var i = 0; i < 2; i++)
            {
                clickElement.Click();
                Thread.Sleep(3000);
            }

            // Store all the opened window into the list 
            // Print each and every items of the list
            List<string> lstWindow = driver.WindowHandles.ToList();
            foreach (var handle in lstWindow)
            {
                Console.WriteLine("\n\n"+handle);
            }

            driver.SwitchTo().Window(lstWindow[1]);
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            clickElement.Click();
            
        }

        [TestMethod]
        public void IFrames_Multiple()
        {
          //http://toolsqa.com/selenium-webdriver/interact-with-elements-inside-an-iframe/

         IWebDriver driver = new ChromeDriver();           
		 driver.Url =@"http://toolsqa.wpengine.com/iframe-practice-page/";
 
        //Switch to frame 1, index is 0 
		driver.SwitchTo().Frame(0);
 
		IWebElement firstName = driver.FindElement(By
                .XPath("//*[@id='content']/form/fieldset/div[1]/p[3]/input"));

        IWebElement lastName = driver.FindElement(By
                .XPath("//*[@id='content']/form/fieldset/div[1]/p[4]/input"));
 
        firstName.SendKeys("Virender");
		lastName.SendKeys("Singh");
 
		//Now if you are inside frame 0 you cannot switch to frame 1. Because frame 1 is not a part
        //of frame 0, but its a part of main page. Any attempt to directly switch to frame 1 from frame 
        //0 will give an exception. Exception will be No Such frame exception.
        driver.SwitchTo().DefaultContent();
        driver.SwitchTo().Frame(1);
 
		//Step 5: Find image element and click on that
        IWebElement imageElement = driver.FindElement(By
				.XPath("//*[@id='post-9']/div/div[1]/div/p[1]/a/img"));
 
		imageElement.Click();        
        }
    }
}

//Once you switch to the frame, you can access the html elements that are inside
//the frame. Any attempt to access the elements which are inside iFrame without switching 
//to that ifFrame will result in WebDriver exception