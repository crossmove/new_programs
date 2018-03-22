using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class NullableTypes
    {
        public void NullableType()
        {
            //Very useful when handling with Database objects 
            int? a = 21;
            a = null;

            bool? flag = true;
            flag = null;
        }
    }
}
