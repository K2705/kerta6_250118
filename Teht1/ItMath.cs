using System;

namespace Teht1
{
    static class ItMath
    {
        /// <summary>
        /// Is a given text string a number?
        /// Uses same criteria as float.TryParse, except that a digit string
        /// beginning or ending with the system decimal separator is not
        /// considered a number.
        /// </summary>
        /// <param name="text">Text string to examine</param>
        /// <returns>True if the string is a number, False if it is not</returns>
        public static bool IsNumber(String text)
        {
            char decimalSeparator = Convert.ToChar(System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);   //Aika vonkale
            if (text[0] == decimalSeparator || text[text.Length - 1] == decimalSeparator) { return false; }
            return float.TryParse(text, out float drop);
        }

        /// <summary>
        /// Is a given text string a date?
        /// Accepted date formats are
        /// "dd.MM.yyyy", "dd.MM.yy", "d.M.yyyy" and "d.M.yy"
        /// </summary>
        /// <param name="text">Text string to examine</param>
        /// <returns>True if the string is a date, False if it is not</returns>
        public static bool IsDate(string text)
        {
            string[] formats = { "dd.MM.yyyy", "dd.MM.yy", "d.M.yyyy", "d.M.yy" };
            return DateTime.TryParseExact(text, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime drop);
            // I don't know what half these parameters do but it seems to work
        }
    }
}
