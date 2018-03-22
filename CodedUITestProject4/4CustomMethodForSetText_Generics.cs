using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestProject4
{
    class CustomMethodForSetText_Generics
    {
        private BrowserWindow mParentWindow { get; set; } 

        public void Run()
        {
            BrowserWindow.Launch(@"http://executeautomation.com/demosite/Login.html");

            HtmlDocument doc = new HtmlDocument(ParentWindow);
            doc.FilterProperties[HtmlDocument.PropertyNames.Title] = "Execute Automation";

            /*HtmlEdit editbox = new HtmlEdit(doc);
            editbox.SearchProperties[HtmlEdit.PropertyNames.Name] = "UserName";
            editbox.Text = "pradeep";*/

            //Replacing above code with Generic example
            EnterText<HtmlEdit>(PropertyType.Name, "UserName", "Generics1");
        }

        public enum PropertyType
        {
            ID, Name, Instance
        }

        public void EnterText<T>(PropertyType type, string propertyValue, string text) where T : HtmlControl
        {
            HtmlControl genericCtrl = (T)Activator.CreateInstance(typeof(T), new object[] { ParentWindow });

            if (type == PropertyType.Name)
            {
                genericCtrl.SearchProperties[HtmlEdit.PropertyNames.Name] = propertyValue;
            }
            else if (type == PropertyType.ID)
            {
                genericCtrl.SearchProperties[HtmlEdit.PropertyNames.Id] = propertyValue;
            }
            Keyboard.SendKeys(genericCtrl, text);
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
