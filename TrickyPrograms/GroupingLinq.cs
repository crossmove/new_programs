using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyPrograms
{
    class GroupingLinq
    {
        public static void Group()
        {
            List<int> list = new List<int> { 1, 2, 3, 2, 4, 5, 5, 7, 6 };

            var groups = list.GroupBy(x => x);

            foreach (var item in groups)
            {
                Console.WriteLine(item.Key+" "+item.Count());
            }
        }
    }
}
