using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CoreFeatures
{
    class XMLDocumentExample
    {
        public static void method()
        {
           
            XmlDocument xml = new XmlDocument();
            xml.Load("XMLFile1.xml");          //Properties : Copy to Ouput is mandatory

            XmlElement rootNode = xml.DocumentElement;  //Returns root node, here it is "catalog"

            //XmlNode is base class for XmlElement
            XmlElement node_First = (XmlElement)xml.SelectSingleNode("//book");  //we use XPath as parameters

            string s = node_First.Attributes["name"].Value;  //op: book1
            //or
            string s1 = node_First.GetAttribute("name");    //op: book1

            var attributes = node_First.Attributes;

            XmlNodeList nodeList = xml.SelectNodes("//book");

            //XmlElement element = new XmlElement();
            //element.
        }
    }
}
