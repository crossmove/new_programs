using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestProject4.HandCoding
{
    class CustomInvokerClass
    {
       public void CallButtonClick()
        {
            CustomCalculatorWindow calcWin = new CustomCalculatorWindow();

            CustomUIItemWindow itemWindow = new CustomUIItemWindow(calcWin);

            Mouse.Click(itemWindow);
        }
    }
}
