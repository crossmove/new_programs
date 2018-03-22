using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestProject4.HandCoding
{
    public class CustomUIItemWindow : WinWindow
    {
        public CustomUIItemWindow(UITestControl searchLimitContainer) :
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "131";
            this.WindowTitles.Add("Calculator");
            #endregion
        }

        #region Properties
        public WinButton UIItem1Button
        {
            get
            {
                if ((this.mUIItem1Button == null))
                {
                    this.mUIItem1Button = new WinButton(this);
                    #region Search Criteria
                    this.mUIItem1Button.SearchProperties[WinButton.PropertyNames.Name] = "1";
                    this.mUIItem1Button.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIItem1Button;
            }
        }
        #endregion

        #region Fields
        private WinButton mUIItem1Button;
        #endregion
    }
}
