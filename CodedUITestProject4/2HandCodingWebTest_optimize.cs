using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestProject4
{
    class HandCodingWebTest_optimize
    {
        private BrowserWindow mParentWindow { get; set; } //new implemenation

        public void Run()
        {
            BrowserWindow.Launch(@"http://executeautomation.com/demosite/Login.html");

            /*BrowserWindow browserWin = new BrowserWindow();
            browserWin.SearchProperties[UITestControl.PropertyNames.Name] = "Execute Automation";
            browserWin.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            browserWin.WindowTitles.Add("Execute Automation");*/

            HtmlDocument doc = new HtmlDocument(ParentWindow);
            doc.FilterProperties[HtmlDocument.PropertyNames.Title] = "Execute Automation";

            HtmlEdit editbox = new HtmlEdit(doc);
            editbox.SearchProperties[HtmlEdit.PropertyNames.Name] = "UserName";

            editbox.Text = "pradeep";
        }

        public BrowserWindow TopParentWindow()
        {
            BrowserWindow browserWin = new BrowserWindow();
            browserWin.SearchProperties[UITestControl.PropertyNames.ClassName] = BrowserWindow.CurrentBrowser.ToString(); //value=IE
            browserWin.WindowTitles.Add("Execute Automation");
            return browserWin;
        }

        public BrowserWindow ParentWindow
        {
            get
            {
                if(this.mParentWindow == null)
                {
                    this.mParentWindow = TopParentWindow();                   
                }
                return this.mParentWindow;
            }
        }
    }
}
