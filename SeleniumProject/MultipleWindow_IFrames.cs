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
    public class MultipleWindow_IFrames
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


            driver.SwitchTo();
            clickElement.Click();
            
        }

        [TestMethod]
        public void IFrames_Multiple()
        {
             IWebDriver driver = new ChromeDriver();
            // Step 1: Navigate to the page with multiple iframes
		    driver.NavigatTo.Goto("http://toolsqa.wpengine.com/iframe-practice-page/");
 
		// Step 2: Switch to first frame and then find First Name and Last name
		// element
 
		/* Switch to the first frame, remember frame index starts from 0 */
		driver.switchTo().frame(0);
 
		/* now find the First name field */
		WebElement firstName = driver.findElement(By
				.xpath("//*[@id='content']/form/fieldset/div[1]/p[3]/input"));
 
		/* now find the Last name field */
		WebElement lastName = driver.findElement(By
				.xpath("//*[@id='content']/form/fieldset/div[1]/p[4]/input"));
 
		// Step 3: Fill some value in the first name and last name files
		firstName.sendKeys("Virender");
		lastName.sendKeys("Singh");
 
		// Step 4: Switching to the 2nd frame, frame index 1
		driver.switchTo().defaultContent();
		driver.switchTo().frame(1);
 
		//Step 5: Find image element and click on that
		WebElement imageElement = driver.findElement(By
				.xpath("//*[@id='post-9']/div/div[1]/div/p[1]/a/img"));
 
		imageElement.click();

        Console.WriteLine(  );

        }
    }
}

//Once you switch to the frame, you can access the html elements that are inside
//the frame. Any attempt to access the elements which are inside iFrame without switching 
//to that ifFrame will result in WebDriver exception