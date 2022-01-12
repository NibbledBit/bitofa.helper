using System;
using System.Collections.Generic;
using System.Text;

namespace bitofa.helper {
    public static class ObjectExtensions {
        public static bool Exists<T>(this T obj) {
            return obj != null;
        }
        public static bool DoesNotExist<T>(this T obj) {
            return obj == null;
        }
    }
}
