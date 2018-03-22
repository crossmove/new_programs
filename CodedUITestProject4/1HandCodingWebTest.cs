using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestProject4
{
    class HandCodingWebTest
    {
        public void WebTest()
        {
            BrowserWindow.Launch(@"http://executeautomation.com/demosite/Login.html");

            BrowserWindow browserWin = new BrowserWindow();
            browserWin.SearchProperties[UITestControl.PropertyNames.Name] = "Execute Automation";
            browserWin.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            browserWin.WindowTitles.Add("Execute Automation");

            HtmlDocument doc = new HtmlDocument(browserWin);
            doc.FilterProperties[HtmlDocument.PropertyNames.Title] = "Execute Automation";

            HtmlEdit editbox = new HtmlEdit(doc);
            editbox.SearchProperties[HtmlEdit.PropertyNames.Name] = "UserName";

            editbox.Text = "pradeep";
        }
    }
}
