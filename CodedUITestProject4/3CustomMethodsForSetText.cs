using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestProject4
{
    class CustomMethodsForSetText
    {
        private BrowserWindow mParentWindow { get; set; } //new implemenation

        public void Run()
        {
            BrowserWindow.Launch(@"http://executeautomation.com/demosite/Login.html");

            HtmlDocument doc = new HtmlDocument(ParentWindow);
            doc.FilterProperties[HtmlDocument.PropertyNames.Title] = "Execute Automation";

            /*HtmlEdit editbox = new HtmlEdit(doc);
            editbox.SearchProperties[HtmlEdit.PropertyNames.Name] = "UserName";
            editbox.Text = "pradeep";*/
            EnterText(new HtmlEdit(), PropertyType.Name, "UserName", "pradeep12345");
        }

        public enum PropertyType
        {
            ID, Name, Instance
        }

        public void EnterText(object controlType, PropertyType type, string propertyValue, string text)
        {
            if(controlType is HtmlEdit)
            {
                HtmlEdit edit = new HtmlEdit(ParentWindow);
                if(type == PropertyType.Name)
                {
                    edit.SearchProperties[HtmlEdit.PropertyNames.Name] = propertyValue;
                }
                else if(type == PropertyType.ID)
                {
                    edit.SearchProperties[HtmlEdit.PropertyNames.Id] = propertyValue;
                }
                Keyboard.SendKeys(edit, text);
            }
            else if(controlType is HtmlTextArea)
            {
                HtmlTextArea textArea = new HtmlTextArea(ParentWindow);
                if (type == PropertyType.Name)
                {
                    textArea.SearchProperties[HtmlTextArea.PropertyNames.Name] = propertyValue;
                }
                else if (type == PropertyType.ID)
                {
                    textArea.SearchProperties[HtmlTextArea.PropertyNames.Id] = propertyValue;
                }
                Keyboard.SendKeys(textArea, text);
            }
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
