using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace Test
{
    public static class Pages
    {
        private static T getPages<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browsers.getDriver, page);
            return page;
        }
        public static ContactUs contactUs
        {
            get { return getPages<ContactUs>(); }
        }
    }
}
//Pages.contactUs.Goto(); --todo--
