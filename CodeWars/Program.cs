using System;
using System.Text.RegularExpressions;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9119;
            string nstring = n.ToString();
            string wynik = String.Empty;
            for (int i = 0; i < nstring.Length; i++)
            {
                Console.WriteLine(nstring[i]);
                int buffor = (int)char.GetNumericValue(nstring[i]);
                wynik += Math.Pow(buffor, 2).ToString();
        }
            int intwynik = Convert.ToInt32(wynik);
        Console.WriteLine(intwynik);
        }
    }
}
