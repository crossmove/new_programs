using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestProject4.HandCoding
{
    public class CustomCalculatorWindow : WinWindow
    {

        public CustomCalculatorWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Calculator";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "CalcFrame";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
    }
}
