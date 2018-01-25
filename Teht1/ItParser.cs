using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    static class ItParser
    {
        /// <summary>
        /// Parse a text string and return the number of comma-separated elements in it
        /// Does not count leading or trailing commas
        /// </summary>
        /// <param name="text">string with commas</param>
        /// <returns>number of comma-separated parts</returns>
        public static int Count(string text)
        {
            string[] split = text.Split(',');
            return split.Length;
        }

        /// <summary>
        /// Parse a text string of comma-separated integers and return their sum
        /// </summary>
        /// <param name="text">string of comma-separated integers</param>
        /// <returns>sum of the integers</returns>
        public static int Sum(string text)
        {
            string[] split = text.Split(',');
            int sum = 0;
            foreach (string number in split)
            {
                int add;
                int.TryParse(number, out add);
                sum += add;
            }
            return sum;
        }

        /// <summary>
        /// Parse a text string of comma-separated integers and return their average
        /// Returns an integer, as per specification
        /// </summary>
        /// <param name="text">string of comma-separated integers</param>
        /// <returns>average of the integers, as integer</returns>
        public static int Average(string text)
        {
            return Sum(text) / Count(text);
        }
    }
}
