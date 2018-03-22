namespace CodedUITestProject4
{
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using System.Linq;
    
    
    public partial class UIMap
    {
        public void PrintingMatchingControlsName()
        {
            ApplicationUnderTest.Launch(@"C:\Windows\System32\calc.exe");

            //For WinWindow 
            WinWindow calWindow = new WinWindow();
            calWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Calculator";
            calWindow.SearchProperties[WinWindow.PropertyNames.ClassName] = "CalcFrame";

            WinButton button = new WinButton(calWindow);

            UITestControlCollection buttonColl = button.FindMatchingControls();
            var Controls = buttonColl.Select(bu => bu.Name);

            foreach (var item in Controls)
            {
                Console.WriteLine(item);
            }
        }
    }
}
