using System;

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
                Console.WriteLine("String \"{0}\" is a number: {1}", test, ItMath.IsNumber(test));
            }

            Console.WriteLine("-- Testing good strings --");
            foreach (String test in testStringsGood)
            {
                Console.WriteLine("String \"{0}\" is a number: {1}", test, ItMath.IsNumber(test));
            }
        }

        
    }
}
