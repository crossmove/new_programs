using Microsoft.VisualStudio.TestTools.UITesting.WinControls;  //For Windows Controls ex: Winforms
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;  //For Wpf Controls  
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls; //For Web Controls
using Microsoft.VisualStudio.TestTools.UITesting.JScript;      //For JavaScript


namespace CodedUITestProject1
{
    public partial class UIMap
    {
        public void Run1()
        {
            WinButton uIStartButton = this.UIStartWindow.UIStartButton;

            WpfButton wpfButton = new WpfButton();
            wpfButton.SearchProperties[WpfButton.PropertyNames.Name] = "ButtonName";
            wpfButton.SearchProperties[WpfButton.PropertyNames.ClassName] = "Uia.ClassName";
            //or


            HtmlEdit htmlEdit = new HtmlEdit();
        }
    }
}
