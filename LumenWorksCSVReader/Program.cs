using System;
using System.Collections.Generic;
using System.Text;
using LumenWorks.Framework.IO.Csv;
using System.IO;

namespace LumenWorksCSVReader
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadCSV();
        }

        static void ReadCSV()
        {
            using(CsvReader csv = new CsvReader(new StreamReader("data.csv"),true))
            {
                int fieldCount = csv.FieldCount; //FieldCount = Column Count
                Console.WriteLine("Column Count "+ fieldCount);

                string[] headers = csv.GetFieldHeaders(); //Coloumn Headers

                //foreach can be applied for string array also

                foreach (var item in headers)
                {
                    Console.WriteLine(item); 
                }

                while (csv.ReadNextRecord())
                {
                    for (int i = 0; i < fieldCount; i++)
                        Console.Write(string.Format("{0} = {1};",
                                      headers[i], csv[i]));
                    Console.WriteLine();
                }
            }
        }
    }
}

/*
 Install Nuget Package: "LumenWorks CSV Reader"
 * https://www.codeproject.com/Articles/9258/A-Fast-CSV-Reader
 */

/* CSV
one,two
1,2
x,y
f,d
r,t
 * */

/* o/p
 Column Count 2
one
two
one = 1;two = 2;
one = x;two = y;
one = f;two = d;
one = r;two = t; 
 * */

