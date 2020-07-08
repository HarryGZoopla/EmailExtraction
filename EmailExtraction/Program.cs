using System;
using System.IO;
using System.Text.RegularExpressions;

namespace EmailExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = File.ReadAllText("sample.txt");

            Regex rx = new Regex(@"@softwire\.com\s",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

            MatchCollection matches = rx.Matches(text);

            Console.WriteLine(matches.Count);
        }
    }
}
