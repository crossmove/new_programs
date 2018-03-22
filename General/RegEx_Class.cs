using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace General
{
    class RegEx_Class
    {
       //  ^ --> Carrot Symbol specfies start of regualar expression
       // $ -->  Dollar Symbol specfies end of regualar expression
       // [] -> Square brackets specifies what you want 
       // {} -> Curly brackets specifies the number of characters(length of validation)
       // Regex is case sensitive
      // ^ and $ sign makes regular expression more rigid, these are not mandatory
        public static void method()
        {
            //Enter characters between a-g
            Regex regex1 = new Regex("^[a-g]$");
            bool flag1 = regex1.IsMatch("b");

            //Enter characters between a-g with length of 3
            Regex regex2 = new Regex("^[a-g]{3}$");
            bool flag2 = regex2.IsMatch("bcd");

            // a-g with min and max length {1,3} 
            Regex regex3 = new Regex("^[a-g]{1,3}$");
            bool flag3 = regex3.IsMatch("bc");


            // Numerics with length 8 
            Regex regex4 = new Regex("^[0-9]{8}$");
            bool flag4 = regex4.IsMatch("12345678");

            // Numerics with length 8 
            Regex regex5 = new Regex("^[0-9]{3,7}$");
            bool flag5 = regex5.IsMatch("123");

            // abcd1234
            Regex regex6 = new Regex("^[a-g]{4}[0-9]{4}$");
            bool flag6 = regex6.IsMatch("abcd1234");

            //making case insensitive
            Regex regex7 = new Regex("^[a-gA-G]{4}[0-9]{4}$");
            bool flag7 = regex7.IsMatch("AbcD1234");

            //website name can be any character from a-z it can contain 0-9 numericals 
            //length is {5 to 12}
            //domain name can be com or org or in
            Regex regex8 = new Regex("^www.[a-zA-Z0-9]{5,12}.(com|org|in)$"); //Pipe symbol for or condition
            bool flag8 = regex8.IsMatch("www.india123.com");

            int a = 21;
        }

        public static void RemoveDigits()
        {
            string input = "a1b2c3";
            var output = Regex.Replace(input, @"[\d-]", string.Empty);
            Console.WriteLine(output);
        }

    }
}
