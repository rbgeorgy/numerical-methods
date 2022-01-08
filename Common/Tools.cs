using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Common
{
    public static class Tools
    {
        public static bool IsParseable(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;
            
            var pi = new Regex(@"\s*pi\s*", RegexOptions.IgnoreCase);
            var numRegex = new Regex(@"^-?\d+(?:\.\d+)?$");
            
            var textWithoutPi = pi.Replace(text, "");

            if (string.IsNullOrEmpty(textWithoutPi) && pi.IsMatch(text)) return true;

            return numRegex.IsMatch(textWithoutPi);
        }

        public static double ParseDoubleWithPi(string text) {
            if (string.IsNullOrEmpty(text)) return 0;

            var pi = new Regex(@"\s*pi\s*", RegexOptions.IgnoreCase);

            if (!pi.IsMatch(text)) return double.Parse(text, CultureInfo.InvariantCulture);
            
            var textWithoutPi = pi.Replace(text, "");
            var parameter = textWithoutPi == "" ? 1 : double.Parse(textWithoutPi, CultureInfo.InvariantCulture);
            var fieldValue = parameter * Math.PI;
            return fieldValue;
        }
    }
}