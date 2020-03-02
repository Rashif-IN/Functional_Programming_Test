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
        public static string Convertt(this int value)
        {
            var result = "";
            List<string> satuan = new List<string>() {"puluh", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan"};
            List<string> belasan = new List<string>() { "puluh", "se", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan"};
            if (value < 10)
            {
                result = satuan[value];
            }
            else if (value % 10 == 0)
            {
                result = $"{belasan[value / 10]} puluh";
            }
            else if (value > 10 && value < 20)
            {
                result = $"{belasan[value % 10]} belas";
            }
            else if (value >21)
            {
                var puluhan = value.ToString().ToCharArray().First().ToString();
                var puluhanData = belasan[Int32.Parse(puluhan)] + " puluh ";
                var satuanData = satuan[value % 10];
                result = puluhanData + satuanData;
            }
            return result;
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
