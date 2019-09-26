using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReguralExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool isOk Regex.IsMatch(text, @"^([[:alnum:]])*[0-9.]*([[:alnum:]])+@*([[:alnum:]])+[0-9.]{1}");
            Console.WriteLine(isOk);
        }
    }
}
