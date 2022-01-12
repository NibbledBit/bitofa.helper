namespace bitofa.helper.Extensions {
    public static class ObjectExtensions {
        public static bool Exists<T>(this T obj) {
            return obj != null;
        }
        public static bool DoesNotExist<T>(this T obj) {
            return obj == null;
        }
    }
}
