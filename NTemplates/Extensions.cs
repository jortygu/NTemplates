using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace NTemplates
{
    public static class Extensions
    {
        public static string InnerString(this string sourceString, int start, int end)
        {
            if (end <= start)
                throw new Exception("Must be at least one character long");

            int len = end - start;
            return sourceString.Substring(start, len);

        }

        public static void AddOrUpdate<T, Q>(this Dictionary<T, Q> dictionary, T key, Q value)
        {
            if (dictionary.Keys.Contains(key))
                dictionary[key] = value;
            else
                dictionary.Add(key, value);
        }

        

    }
}
