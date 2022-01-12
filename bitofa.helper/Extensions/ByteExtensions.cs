using System;
using System.Text;

namespace bitofa.helper.Extensions {
    public static class ByteExtensions {

        /// <summary>
        /// Convent an array of byte data to a hex encoded string (typically for logging)
        /// </summary>
        /// <param name="ba">array of bytes</param>
        /// <returns></returns>
        public static string ToHexString(this byte[] ba) {
            if (ba != null) {
                StringBuilder hex = new StringBuilder(ba.Length * 2);
                foreach (byte b in ba)
                    hex.AppendFormat("{0:x2}", b);
                return hex.ToString();
            }
            return null;
        }

        /// <summary>
        /// Combine a byte array to another byte array
        /// </summary>
        /// <param name="first">The first part</param>
        /// <param name="second">The second part to append</param>
        /// <returns>Both arrays joined</returns>
        public static byte[] Combine(this byte[] first, byte[] second) {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }
    }
}
