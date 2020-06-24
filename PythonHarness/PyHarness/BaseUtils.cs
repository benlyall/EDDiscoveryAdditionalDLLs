﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyHarness
{
    static class BaseUtils  // copied from base utils, so we don't have to get into that dependency stuff
    {
        public static void DeleteFileNoError(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch
            {       // on purpose no error - thats the point of it
                //System.Diagnostics.Debug.WriteLine("Exception " + ex);
            }
        }

        public static bool Contains(this string data, string comparision, StringComparison c = StringComparison.CurrentCulture)        //extend for case
        {
            return data.IndexOf(comparision, c) >= 0;
        }

        public static int ContainsIn(this IEnumerable<string> list, string comparision, StringComparison c = StringComparison.CurrentCulture)        //extend for case
        {
            int i = 0;
            foreach (var s in list)
            {
                if (s.Contains(comparision, c))
                    return i;

                i++;
            }

            return -1;
        }

        static public int InvariantParseInt(this string s, int def)
        {
            int i;
            return int.TryParse(s, System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture, out i) ? i : def;
        }


    }
}