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


        /// <summary>
        /// Converts an integer value in twips to the corresponding integer value
        /// in pixels on the x-axis.
        /// </summary>
        /// <param name="source">The Graphics context to use</param>
        /// <param name="inTwips">The number of twips to be converted</param>
        /// <returns>The number of pixels in that many twips</returns>
        public static int ConvertTwipsToXPixels(this Graphics source, int twips)
        {
            //Thanks Christopher Pfohl
            //http://stackoverflow.com/questions/4044397/how-do-i-convert-twips-to-pixels-in-net
            int size =  (int)(((double)twips) * (1.0 / 1440.0) * source.DpiX);
            return size;
        }

        //public static int ConvertXPixelsToTwips(this Graphics source)
        //{
        //    //Thanks Christopher Pfohl
        //    //http://stackoverflow.com/questions/4044397/how-do-i-convert-twips-to-pixels-in-net
        //    int size = (int)(((double)twips) * (1.0 / 1440.0) * source.DpiX);
        //    return size;
        //}

        /// <summary>
        /// Converts an integer value in twips to the corresponding integer value
        /// in pixels on the y-axis.
        /// </summary>
        /// <param name="source">The Graphics context to use</param>
        /// <param name="inTwips">The number of twips to be converted</param>
        /// <returns>The number of pixels in that many twips</returns>
        public static int ConvertTwipsToYPixels(this Graphics source, int twips)
        {
            //Thanks Christopher Pfohl
            //http://stackoverflow.com/questions/4044397/how-do-i-convert-twips-to-pixels-in-net
            int size = (int)(((double)twips) * (1.0 / 1440.0) * source.DpiY);
            return size;
        }

        //public static int ConvertYPixelsToTwips(this Graphics source)
        //{
        //    //Thanks Christopher Pfohl
        //    //http://stackoverflow.com/questions/4044397/how-do-i-convert-twips-to-pixels-in-net
        //    int size = (int)(((double)twips) * (1.0 / 1440.0) * source.DpiY);
        //    return size;
        //}
    }
}
