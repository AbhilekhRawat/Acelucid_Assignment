using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Hdjsh asd2324234jghjsd hjsdg sdhk 12212021 idf32432 32423 d34234jh dfh";

        string pattern = @"\b(\d{2})(\d{2})(\d{4})\b";
        Match match = Regex.Match(input, pattern);

        if (match.Success)
        {
            string month = match.Groups[1].Value;
            string day = match.Groups[2].Value;
            string year = match.Groups[3].Value;

            DateTime date = DateTime.ParseExact(month + day + year, "MMddyyyy", null);
            Console.WriteLine("Valid date found: " + date.ToString("MM/dd/yyyy"));
        }
        else
        {
            Console.WriteLine("No valid date found.");
        }
    }
}
