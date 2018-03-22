using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Configuration;

namespace Test
{
    public class Browsers
    {
        private static IWebDriver webDriver;
        public static ReportsManager reports; // adding the report vaiable
        private static string baseURL = ConfigurationManager.AppSettings["url"];
        private static string browser = ConfigurationManager.AppSettings["browser"];
        public static void Init()
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "IE":
                    webDriver = new InternetExplorerDriver();
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    break;
            }
            
            reports = new ReportsManager(browser, baseURL);
            Goto(baseURL);
            webDriver.Manage().Window.Maximize();
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }
        public static IWebDriver getDriver
        {
            get { return webDriver; }
        }
        public static void Goto(string url)
        {
            webDriver.Url = url;
            reports.verifyURL(url);
        }
        public static void Close()
        {
            webDriver.Quit();
        }
    }
}
