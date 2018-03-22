using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class RepeatedWordInTextCount
    {
        public static void Repeat()
        {
            string text = "sjkdlfeifeindiajieifefeiindiajjkdfjdeindia";
            string queryStr = "india";
            int count = 0;
        
            int queryStrLen = queryStr.Length;
            while (text.Length >= queryStrLen)
            {
                int index = text.IndexOf(queryStr);

                if (index < 0)
                    break;
                else
                    count++;
                text = text.Substring(index + queryStrLen);
            }
            Console.WriteLine(count);
        }
    }
}
