using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System.Linq;
using System.Drawing;
using OpenQA.Selenium.Interactions;
using System.Threading;
using System.IO;
using System.Collections;

namespace SeleniumProject
{
    [TestClass]
    public class SeleniumGeneral
    {

        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void DynamicTable()
            {
                //https://stackoverflow.com/questions/43853855/webdriver-how-to-click-on-a-button-for-a-specific-row-of-a-table-c

                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl(new Uri(@"F:\One.html"));

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                IList<IWebElement> rowCollection = driver.FindElements(By.XPath("//table/tbody//tr"));

                IList<IWebElement> tds;

                StreamWriter writer = new StreamWriter(@"F:\tablevalues.txt");

                foreach (IWebElement row in rowCollection)
                {
                    tds = row.FindElements(By.TagName("td"));

                    foreach (IWebElement td in tds)
                    {
                        if (td.Text == "Hello")
                        {
                            tds[0].Click();
                        }
                        writer.Write(td.Text + "\t");
                    }

                    writer.WriteLine();
                }
                writer.Close();
            }
        }

        [TestMethod]
        public void HighlightElement()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(new Uri(@"F:\One.html"));

            //Now we should use Implict Wait as below, earlier is deprecated.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //Row and Column starts from Index 1, not Zero
            IWebElement element = driver.FindElement(By.XPath("//table/tbody/tr[1]/td[1]"));

            var javaScriptDriver = (IJavaScriptExecutor)driver;
            string highlightJavascript = @"arguments[0].style.cssText = ""border-width: 3px; border-style: solid; border-color: green"";";

            //The above statement resolves to following string result
            // arguments[0].style.cssText = "border-width: 3px; border-style: solid; border-color: green";



            javaScriptDriver.ExecuteScript(highlightJavascript, new object[] { element });

        }

        [TestMethod]
        public void Double_RightClick()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(new Uri(@"F:\One.html"));

            IWebElement element = driver.FindElement(By.XPath("//table/tbody/tr[1]/td[1]"));

            Actions action = new Actions(driver);
            action.DoubleClick(element).Build().Perform();

            //Context Click means right click --> Select Down Arrow key once --> Click the selected Item --> Build --> Perform
            action.ContextClick(element).SendKeys(Keys.Down).Click().Build().Perform();

            //Shift Key down --> Enter values pradeep --> Shift Key release / up
            action.KeyDown(Keys.Shift).SendKeys("pradeep").KeyUp(Keys.Shift).Build().Perform();
        }


        [TestMethod]
        public void SetFocus()
        {
            IWebDriver driver = new ChromeDriver();
            IWebElement myelement = driver.FindElement(By.Id("element-id"));
            //Send empty message to element for set focus on element 
            myelement.SendKeys(""); 

        }


        [TestMethod]
        public void SeleniumAllSelectors()
        {
            IWebDriver chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl(@"http://www.google.com");

            //Find Element : returns exception if no match found
            IWebElement byID = chromeDriver.FindElement(By.Id("ID"));
            IWebElement byName = chromeDriver.FindElement(By.Name("Name"));
            IWebElement byClassName = chromeDriver.FindElement(By.ClassName("ClassName"));
            IWebElement byTagName = chromeDriver.FindElement(By.TagName("TagName"));
            IWebElement byXapth = chromeDriver.FindElement(By.XPath("//div[@id='gs_lc0']/input"));
            IWebElement byCSSSelector = chromeDriver.FindElement(By.CssSelector("#food span.dairy.aged"));

            //Find Elements: Return empty list if no match found
            IList<IWebElement> cheeses = chromeDriver.FindElements(By.ClassName("cheese"));
        }


        [TestMethod]
        public void FindElementsByJavaScript()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.makemytrip.com/");

            //Downcasting driver object to JavaScriptExecutor
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement searchBtn = (IWebElement)js.ExecuteScript("return document.getElementById('searchBtn')");
            var text = searchBtn.Text;
            //ouput = search 

            // Down casting to List<WebElement> because executeScript return a type of Object
            IList<IWebElement> element = (IList<IWebElement>)js.ExecuteScript("return document.getElementsByClassName('non-pot')");
            int count = element.Count;
            //output 

            bool displayStatus = searchBtn.Displayed; //Visible area of the browser
           
        }

        [TestMethod]
        public void FindElementsByJavaScriptCode()
        {
            IWebDriver chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl(@"http://www.google.com");

            // Single WebElement
            IWebElement byJavsScript = (IWebElement)((IJavaScriptExecutor)chromeDriver).ExecuteScript("return $('.className')[0]");

            //List of WebElements
            IList<IWebElement> elemByClassName = chromeDriver.FindElements(By.TagName("className"));
            IList<IWebElement> inputs = (IList<IWebElement>)((IJavaScriptExecutor)chromeDriver).ExecuteScript(
            "var labels = arguments[0], inputs = []; for (var i=0; i < labels.length; i++){" +
            "inputs.push(document.getElementById(labels[i].getAttribute('for'))); } return inputs;", elemByClassName);
        }


        [TestMethod]
        public void ChromeHeadLess()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");

            IWebDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://www.makemytrip.com/");

            driver.Url = @"http://www.gmail.com";
            driver.Navigate().GoToUrl(@"http://www.gmail.com");

        }

        [TestMethod]
        public void Questions()
        {

            //Difference between driver.Url and  driver.Navigate().GoToUrl  ? 
            //both does the same things 
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.makemytrip.com/");
            driver.Url = @"https://www.makemytrip.com/";

            //Quit vs Close Method
            driver.Close(); // Close the current window
            driver.Quit();  // Quits the driver, closes all associated windows opened by driver

            //Difference between implicit and explicit wait ?
            // the implicit wait is set for the life of the WebDriver object instance
            //Default implicit wait is 0 seconds
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //WebDriverWait by default calls the ExpectedCondition every 500 milliseconds until it returns successfully
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until<IWebElement>(ExpectedConditions.ElementExists(By.Id("ID")));
            
            
        }

        [TestMethod]
        public void IFrame()
        {
            //https://www.guru99.com/handling-iframes-selenium.html
            //an IFrame = Inline Frame,  is an HTML document embedded inside another HTML document in a website.
            //The IFrame HTML element is often used to insert content from another source, such as an advertisement
            //We cannot detect IFrames by inspecting through Firebug 
            //We can only identity IFrame by Right clicking on the element, If you find the option like 'This Frame' in context menu then it is an iframe
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.makemytrip.com/"); 
          
            //Finding total numbers of IFrames 
            int count = driver.FindElements(By.TagName("iframe")).Count;

            //Basically, we can switch over the elements in frames using 3 ways.

            //By Index
            driver.SwitchTo().Frame(0);

            //By Name or Id
            driver.SwitchTo().Frame("frameName");
            driver.FindElement(By.XPath("html/body/a/img")).Click();



            //By Web Element
            //--todo--
        }

        [TestMethod]
        public void SSLCertificates()
        {
            //How to Handle Untrusted Certificate Selenium Webdriver
            FirefoxOptions fireOptions = new FirefoxOptions();
            fireOptions.AcceptInsecureCertificates = true;
            fireOptions.SetPreference("intl.accept_languages", "jp"); //Internatalization , jp = japan language
            IWebDriver driver = new FirefoxDriver(fireOptions);
            driver.Url = "http://www.hello.com";

            //for Chrome
            ChromeOptions options = new ChromeOptions();
            options.AcceptInsecureCertificates = true;
            IWebDriver chromeDriver = new ChromeDriver(options);

            driver.SwitchTo().Window(driver.WindowHandles.Last());

           
        }

        [TestMethod]
        public void DisableInfoBars_MaximizeWindow()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("disable-infobars");
            options.AddArguments("--start-maximized");            

            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "http://www.gmail.com";
        }

        [TestMethod]
        public void DriverEnviornmentVariables()
        {
            //Consider we have drivers in D:\Drivers\chromedriver.exe path 
            string driverPath = @"D:\drivers\";
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.gmail.com";


            //instead of this we can also set enviornment variable Path to D:\drivers\
            //and we can ignore the passing driverPath as argment in code.

            driver.FindElement(By.CssSelector("#id")).SendKeys(Keys.Enter);
        }

        [TestMethod]
        public void SetFocusOnElement()
        {
            IWebDriver driver = new ChromeDriver();
            IWebElement myelement = driver.FindElement(By.Id("element-id"));
            //Send empty message to element for set focus on element  
            myelement.SendKeys("");  
        }

       [TestMethod]
        public void CSSFontSizeColor()
        {
            IWebDriver driver = new ChromeDriver();
            string fontSize = driver.FindElement(By.Id("element-id")).GetCssValue("font-size");
            string color = driver.FindElement(By.Id("element-id")).GetCssValue("color");

        }

       [TestMethod]
       public void Refresh()
       {
           IWebDriver driver = new ChromeDriver();
           driver.Navigate().Refresh();
       }

       [TestMethod]
       public void GetBrowserName()
       {
           IWebDriver driver = new ChromeDriver();
           driver.Url = "http://www.gmail.com";
           String s = (String)((IJavaScriptExecutor)driver).ExecuteScript("return navigator.userAgent;");
           // s op: Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36
           
           String s1 = (String)((IJavaScriptExecutor)driver).ExecuteScript("return navigator.appCodeName;");            
           //s1 op: Mozilla
           int a = 1;
       }

        [TestMethod]
       public void ClickingHiddenElementJavaScript()
       {
           //Using javascript is a good option when wanting to click on hidden elements. Selenium CANNOT perform actions on hidden elements (ie clicking). 

           IWebDriver driver = new ChromeDriver();

           ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//input[@value=2]")));

            //or

           ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].trigger('click');", driver.FindElement(By.XPath("//input[@value=2]")));
       }

          [TestMethod]
        public void HighlightJavaScript()
        {           
            IWebDriver driver = new ChromeDriver();

            IWebElement element = driver.FindElement(By.XPath("//table/tbody/tr[1]/td[1]"));
            
            var javaScriptDriver = (IJavaScriptExecutor)driver;

            string highlightJavascript1 = @"$(arguments[0]).css({ ""border-width"" : ""2px"", ""border-style"" : ""solid"", ""border-color"" : ""red"" });";
            //or both are same 
            string highlightJavascript2 = @"arguments[0].style.cssText = ""border-width: 3px; border-style: solid; border-color: green"";";

            //The above statement resolves to following string result
            // arguments[0].style.cssText = "border-width: 3px; border-style: solid; border-color: green";

            javaScriptDriver.ExecuteScript(highlightJavascript1, new object[] { element });

        }

          [TestMethod]
          public void FindElementXPath()
          {
              IWebDriver driver = new ChromeDriver();
              
              //Here we are using relative path as we are using // 
              //Means ul is not direct child of div and  li is not direct child of ul
              IList<IWebElement> elements= driver.FindElements(By.XPath("//div[@id='example']//ul//li"));
          }

          [TestMethod]
          public void LocatingElementsThroughJavaScript()
          {
              //We have enough locators to identity web elements on a web page. 
              //Sometimes these locating strategies fail if they are hidden or deeply nested.
              //If a website has ajax calls in this case also javascript locating commands are useful.

              IWebDriver driver = new ChromeDriver();
              driver.Navigate().GoToUrl("https://www.makemytrip.com/");

              //Downcasting driver object to JavaScriptExecutor 
              IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
              IWebElement searchBtn = (IWebElement)js.ExecuteScript("return document.getElementById('searchBtn')");
              var text = searchBtn.Text;
              //ouput = search  

              // Down casting to List<WebElement> because executeScript return a type of Object 
              IList<IWebElement> element = (IList<IWebElement>)js.ExecuteScript("return document.getElementsByClassName('non-pot')");
              int count = element.Count;                           
          }

          [TestMethod]
          public void JavaScriptClick_XPath()
          {
              IWebDriver driver = new ChromeDriver();

              ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//input[@value=2]")));

              //or

              ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].trigger('click');", driver.FindElement(By.XPath("//input[@value=2]")));
          }
          
        [TestMethod]
         public void SelectElement_Dropdown()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(@"http://www.google.com");

            SelectElement select = new SelectElement(driver.FindElement(By.TagName("select")));
            select.DeselectAll();
            select.SelectByText("Edam");
            select.SelectByIndex(1);
            select.SelectedOption.GetAttribute("country");
        }

        [TestMethod]
        public void Submit()
        {
            /*
             * Submit should be used within forms, for every elements .Submit() method is associated.
             * When we make call use element.Submit(), then WebDriver will go until end of the form and 
             * then calls Submit() on that form.  If element is not inside form then,  it will throw
             * NoSuchElementException.
             * */
            IWebDriver driver = new ChromeDriver();

            IWebElement element = driver.FindElement(By.Id("id"));
            element.Submit();

            //or
            driver.FindElement(By.Id("submit")).Click();
        }

        [TestMethod]
        public void EnabledDisplayedSelected()
        {
            IWebDriver driver = new ChromeDriver();
            IWebElement element = driver.FindElement(By.Id("lst-ib"));
            bool isEnabled = element.Enabled;
            bool isDisplayed = element.Displayed;
            bool isSelected = element.Selected;

            string title = driver.Title;
            string pageSource = driver.PageSource;

        }

        [TestMethod]
        public void DriverManage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(@"http://www.google.com");

            //Maximize window
            driver.Manage().Window.Maximize();

            //Get the Screen Size 
            Size size = driver.Manage().Window.Size;

            //Change the screen Size as per our requirement
            Size reducedSize = new Size(1500, 800);
            driver.Manage().Window.Size = reducedSize;
        }

        [TestMethod]
        public void CheckBox_RadioButton()
        {
            IWebDriver driver = new ChromeDriver();
            //Select CheckBox
            IWebElement checkboxElement = driver.FindElement(By.Id("Checkbox"));
            checkboxElement.Click();

            //Select Radio Button
            IWebElement RadioButtonElement = driver.FindElement(By.Id("RadioButton"));

            if (!RadioButtonElement.Selected)
            {
                RadioButtonElement.Click();
            }
        }

        [TestMethod]
        public void Navigate()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(@"http://www.google.com");

            IWebElement element = driver.FindElement(By.Id("source"));
            element.SendKeys("Pradeep");
            element.Submit();

            //Navigation
            driver.Navigate().Forward();
            driver.Navigate().Back();
            driver.Navigate().Refresh(); 

            
        }

        [TestMethod]
        public void ExplicitWait()
        {
            /*
             * This waits up to 10 seconds before throwing a TimeoutException or if it 
             * finds the element will return it in 0 - 10 seconds. 
                WebDriverWait by default calls the ExpectedCondition every 500 milliseconds
             * until it returns successfully.
             */
            IWebDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement elem = wait.Until(ExpectedConditions.ElementExists(By.Id("someid")));
        }

        [TestMethod]
        public void DragDrop()
        {
            //Drag and Drop
            IWebDriver driver = new ChromeDriver();
            Actions action = new Actions(driver);
            IWebElement sourcElement = driver.FindElement(By.Id("source"));
            IWebElement destElement = driver.FindElement(By.Id("destination"));
            action.DragAndDrop(sourcElement, destElement).Perform();

        }

        [TestMethod]
        public void TableData_NestedTable()
        {
            IWebDriver driver = new ChromeDriver();

            string innerText = driver.FindElement(By.XPath("//table/tbody/tr[2]/td[2]")).Text;

            //Nested Table
            string innerText1 = driver.FindElement(By.XPath("//table/tbody/tr[2]/td[2]/table/tbody/tr/td[2]")).Text;

        }

        public void SwitchingFrames()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(@"http://www.google.com");

            driver.SwitchTo().Frame(0);
            driver.SwitchTo().Frame("frameName");

        }

        [TestMethod]
        public void MovingbetweenWindowsAndFramesAlerts()
        {
            /*
             * Some web applications have many frames or multiple windows.
             * WebDriver supports moving between named windows using the SwitchTo() method.
             * Also propery driver.WindowHandles gets the window handles of Opened Browser Windows.
             * window got one method.
                But for Frame we have 3 overloads
                index
                frameElement
                frameName
             * */

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(@"http://www.google.com");

            //Moving Between Windows and Frames & Alert
            driver.SwitchTo().Window("windowName");

            driver.SwitchTo().Frame("frameName");

            //Reverting back from Frame to Default
            driver.SwitchTo().DefaultContent();

            //Switching to Alert
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            alert.Dismiss();
            string alertText = alert.Text;

            //Gets the window handles of open browser windows.
            foreach (string handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
            }        
        }

        [TestMethod]
        public void ImplicitWait()
        {
            /*
             * An implicit wait is to tell WebDriver to poll the DOM for a certain amount of time when
             * trying to find an element or elements if they are not immediately available. 
             * The default setting is 0. Once set, the implicit wait is set for the life of 
             * the WebDriver object instance.
             * */

            IWebDriver driver = new ChromeDriver("");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

        }

        [TestMethod]
        public void Actions()
        {
            
            IWebDriver driver = new ChromeDriver("");
            IWebElement element = driver.FindElement(By.Id("source"));

            //Mouse Hover
            Actions action = new Actions(driver);
            action.MoveToElement(element).Build().Perform();

            action.ClickAndHold(element);
            action.Release();

            //Right Click 
            action.ContextClick(element);


            //series of actions or chain of actions.
            action.Click(element).KeyDown(Keys.Shift).DoubleClick(element).Build();
            action.Perform();

        }

        [TestMethod]
        public void Screenshot()
        {
            IWebDriver driver = new ChromeDriver("");
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(@"c:\deploy\screenshot.jpg", ScreenshotImageFormat.Jpeg);
        }

        [TestMethod]
        public void ScrollExample()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.jqueryui.com");

            Thread.Sleep(5000);
            //Scroll to some point
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0,700)");

            //Scroll to the bottom of the page
            Thread.Sleep(5000);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");

            //Execute an alert
            ((IJavaScriptExecutor)driver).ExecuteScript("alert('hello')");
        }

        [TestMethod]
        public void SelectingAllCheckbox()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.jqueryui.com");

            IList<IWebElement> list = driver.FindElements(By.TagName("input"));

            // Below code will select all of the check boxes and radio buttons.
            for (int i = 0; i < list.Count; i++)
            {
                // Checking the check box
                if (list[i].GetAttribute("type").Trim().ToLower().Equals("checkbox"))
                {

                    // Select the check box if not already selected.
                    if (!(list[i].Selected))
                    {
                        list[i].Click();
                    }
                    else
                    {
                        // De-select the check boxes.
                        list[i].Click();
                    }
                }
            }
        }

        [TestMethod]
        public void DynamicValueFromTable()
        {
            IWebDriver driver = new ChromeDriver();

            //Dynamic value from Table
            int rowNumber = 2;
            int colNumber = 3;

            //tr and td index starts from 1, tr[1] means firstRow tr[1]td[1] = firstrow first column
            string cellValue = driver.FindElement(By.XPath("html/body/table/tbody/tr[" + rowNumber + "]/td[" + colNumber + "]")).Text;

        }

        [TestMethod]
        public void Cookies()
        {
            /**
             First of all, you need to be on the domain that the cookie will be valid for.
             * If you are trying to preset cookies before you start interacting with a site and your
             * homepage is large / takes a while to load an alternative is to find a smaller page on the site
             **/

            IWebDriver driver = new ChromeDriver();
            Cookie cookieobj = new Cookie("key", "value");
            driver.Manage().Cookies.AddCookie(cookieobj);
            driver.Manage().Cookies.DeleteAllCookies();

        }



    }
}
