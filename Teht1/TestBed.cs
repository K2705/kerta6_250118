﻿using System;

namespace Teht1
{
    class TestBed
    {
        static void Main(string[] args)
        {
            String[] testStringsBad = { "Kissa", "abcABC1", "1234.", ",1234", "1234,", "12-34", "123.45", "123,45,67" };
            String[] testStringsGood = { "0", "123", "123,45", "+123", "-123", "+123,45", "-123,45" };

            RunNumberTest(testStringsBad, testStringsGood);

            Console.WriteLine();

            String[] dateStringsBad = { "12,12,2016", "12.13.2017", "30.2.2017" };
            String[] dateStringsGood = { "1.2.13", "1.10.2017", "12.12.2017", "24.12.17" };

            RunDateTest(dateStringsBad, dateStringsGood);

            Console.WriteLine();

            TestParser();
        }

        private static void TestParser()
        {
            Console.Write("Input a list of numbers separated with commas\n> ");
            string input = Console.ReadLine();
            //TODO According to spec, this is meant to be capped at 10 numbers, but I don't care
            Console.WriteLine();
            Console.WriteLine("The string {0} contains {1} numbers, their sum is {2} and their average {3}."
                , input, ItParser.Count(input), ItParser.Sum(input), ItParser.Average(input));
        }

        private static void RunNumberTest(string[] testStringsBad, string[] testStringsGood)
        {
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

        private static void RunDateTest(string[] testStringsBad, string[] testStringsGood)
        {
            Console.WriteLine("-- Testing bad strings --");
            foreach (String test in testStringsBad)
            {
                Console.WriteLine("String \"{0}\" is a date: {1}", test, ItMath.IsDate(test));
            }

            Console.WriteLine("-- Testing good strings --");
            foreach (String test in testStringsGood)
            {
                Console.WriteLine("String \"{0}\" is a date: {1}", test, ItMath.IsDate(test));
            }
        }

    }
}
