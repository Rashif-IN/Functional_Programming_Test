using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FuncProg_Test
{
    public static class IEnumerableExtension
    {
        public static string Capitalize(this string values)
        {
            return (CultureInfo.CurrentCulture.TextInfo.ToTitleCase(values.ToLower()));
        }
        public static string SnakeCase(this string values)
        {
            return values.Replace(" ", "_");
        }
        public static string KebabCase(this string values)
        {
            return values.Replace(" ", "-");
        }
        public static T Most<T>(this IEnumerable <T> values)
        {
            return (values.GroupBy(X => X).OrderByDescending(X => X.Count()).Select(X=>X.Key)).First();
        }
        public static string TrimS(this string values, int num)
        {
            return $"{values.Substring(0, num)}...";
        }
        public static string TrimW(this string values, int num)
        {
            return String.Join(" ",values.Split().Take(num));
        }
    }
}
