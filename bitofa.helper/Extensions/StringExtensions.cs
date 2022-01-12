using System;

namespace bitofa.helper.Extensions {
    public static class StringExtensions {
        public static bool IsANumber(this string str) {
            return int.TryParse(str, out _);
        }
        public static string ReplaceLastOccurrence(this string source, string find, string replace) {
            int place = source.LastIndexOf(find);
            return source.Remove(place, find.Length).Insert(place, replace);
        }
        /// <summary>
        /// Truncates string so that it is no longer than the specified number of characters.
        /// </summary>
        /// <param name="str">String to truncate.</param>
        /// <param name="length">Maximum string length.</param>
        /// <returns>Original string or a truncated one if the original was too long.</returns>
        public static string Truncate(this string str, int length) {
            if (length < 0) {
                throw new ArgumentOutOfRangeException(nameof(length), "Length must be >= 0");
            }

            if (str == null) {
                return null;
            }

            int maxLength = Math.Min(str.Length, length);
            return str.Substring(0, maxLength);
        }
    }
}
