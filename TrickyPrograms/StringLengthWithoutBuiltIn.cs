using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringLengthWithoutBuiltIn
{
    static void Main(string[] args)
    {

        string name = "123456789";
        int stringLength = GetStringLength(name);
        Console.WriteLine(stringLength);
    }

    private static int GetStringLength(string name)
    {
        bool status = true;
        int i = 0;
        name = name + '\0';
        while (status)
        {

            if (name[i] != '\0')
            {
                i++;
            }
            else
            {
                status = false;
            }
        }
        return i;
    }
}
