using System;
using System.ComponentModel;
using System.Reflection;

namespace bitofa.helper.Extensions {
    public static class DataAnnotationExtensions {
        public static string GetDescription<T>(this string fieldName) {
            string result;
            FieldInfo fi = typeof(T).GetField(fieldName.ToString());
            if (fi != null) {
                try {
                    object[] descriptionAttrs = fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
                    DescriptionAttribute description = (DescriptionAttribute)descriptionAttrs[0];
                    result = description.Description;
                }
                catch {
                    result = null;
                }
            }
            else {
                result = null;
            }

            return result;
        }

        public static string GetDescription(this Enum value) {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null) {
                FieldInfo field = type.GetField(name);
                if (field != null) {
                    if (Attribute.GetCustomAttribute(field,
                             typeof(DescriptionAttribute)) is DescriptionAttribute attr) {
                        return attr.Description;
                    }
                }
            }
            return null;
        }
    }
}
