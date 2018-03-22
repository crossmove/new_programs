using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodedUITestProject4.WebRecordTestClasses;
using System.Drawing.Imaging;


namespace CodedUITestProject4
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class TestClass
    {
        [TestInitialize]
        public void InitializeMethod()
        {
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            ApplicationUnderTest.Launch(@"C:\Windows\System32\calc.exe");
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.Add();
            this.UIMap.AssertAddition();
        }

        [TestMethod]
        public void PrintMatchingControlsName()
        {           
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.PrintingMatchingControlsName();          
        }

        [TestMethod]
        public void WebRecordTest() //Video no 14
        {
            //open website 
            //http://executeautomation.com/demosite/Login.html

            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            WebRecordTest obj = new WebRecordTest();
            obj.executeautomationdemosite();
        }

        [TestMethod]
        public void HandCodeWebTest() //Video no 15
        {            
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            HandCodingWebTest obj = new HandCodingWebTest();
            obj.WebTest();
        }

        [TestMethod]
        public void HandCodeWebTest_Optimize() //Video no 16
        {          
            HandCodingWebTest_optimize obj = new HandCodingWebTest_optimize();
            obj.Run();
        }

        [TestMethod]
        public void CustomMethod() //Video no 16
        {
            CustomMethodsForSetText obj = new CustomMethodsForSetText();
            obj.Run();
        }

        [TestMethod]
        public void CustomMethod_UsingGenerics() //Video no 17
        {
            CustomMethodForSetText_Generics obj = new CustomMethodForSetText_Generics();
            obj.Run();
        }

        [TestMethod]
        public void BrowseWindow_Hook() //Video no 17
        {
           //hook with already existing Browser with title "Execute Automation"
           BrowserWindow window = BrowserWindow.Locate("Execute Automation"); //Execute Automation is the title of the browser.

           //From Process
           //BrowserWindow fromProcess = BrowserWindow.FromProcess();

           BrowserWindow.ClearCookies();
           BrowserWindow.ClearCache();

           Image image = window.CaptureImage();
           image.Save(@"c:\captured.jpeg", ImageFormat.Jpeg);
           image.Dispose(); //Releasing 

           BrowserWindow.CurrentBrowser = "Firefox"; // or "Chrome" or "IE"

           window.Refresh();

           window.Forward();
           window.Back();
           window.NavigateToHomepage();
        }

        [TestMethod]
        public void AssertWrapper()
        {
            Verfiy("a", "b"); 
            //Now check the Test Result : Output
        }

        [TestMethod]
        public void CrossBrowserChrome()
        {
            //The latest version of the browser is not compatible for this test
            // so download old chrome from this location and try 

            //https://sites.google.com/a/chromium.org/chromedriver/downloads
            BrowserWindow.CurrentBrowser = "chrome";
            BrowserWindow.Launch(@"https://www.gmail.com/");
        }

        [TestMethod]
        public void JavaScript_CodedUI()
        {
            BrowserWindow browserObj = BrowserWindow.Launch(@"https://www.gmail.com/");
            browserObj.ExecuteScript("alert('Hello')");
            var count = browserObj.ExecuteScript("var count = document.getElementsByTagName('Input').length; return count;");                        
        }

        //[TestCleanup]
        public void TestCleanup()
        {
            if(TestContext.CurrentTestOutcome == UnitTestOutcome.Failed)
            {
                Image image = UITestControl.Desktop.CaptureImage();
                image.Save(@"D\" + TestContext.TestName + ".jpg");
                image.Dispose();
            }
        }

        public void Verfiy(string actual, string expected)
        {
            try
            {
                Assert.AreEqual(actual, expected);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       

        
        
        

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
