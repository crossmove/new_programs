using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class _1WordCountInText
    {
        public void WordCount()
        {
            string Text = "aindia catindiajjindia12345"; 
            string QueryString = "12345";

            int length = QueryString.Length;
  
            int count = 0;
            while (Text.Length >= length)
            {               
                int index = Text.IndexOf(QueryString);
                if (index < 0)
                {
                    break;
                }
                count++;
                Text = Text.Substring(length + index);
            }
            Console.WriteLine(count + " Times");   
            //Program to add 
       }        
    }
}
