using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class TestBed
    {
        static void Main(string[] args)
        {
            String[] testStringsBad = { "Kissa", "abcABC1", "1234.", ",1234", "1234,", "12-34", "123.45", "123,45,67" };
            String[] testStringsGood = { "0", "123", "123,45", "+123", "-123", "+123,45", "-123,45" };

            Console.WriteLine("-- Testing bad strings --");
            foreach (String test in testStringsBad)
            {
                Console.WriteLine("String \"{0}\" is a number: {1}", test, IsNumber(test));
            }

            Console.WriteLine("-- Testing good strings --");
            foreach (String test in testStringsGood)
            {
                Console.WriteLine("String \"{0}\" is a number: {1}", test, IsNumber(test));
            }
        }

        public static bool IsNumber(String text)
        {
            char decimalSeparator = Convert.ToChar(System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);   //Aika vonkale
            if (text[0] == decimalSeparator || text[text.Length - 1] == decimalSeparator) { return false; }
            return float.TryParse(text, out float drop);
        }
    }
}
