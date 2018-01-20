using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AddressBook.Utils
{
    public class Slug
    {
        public static string Slugify(string text)
        {
            var result = text.ToLower();
            result = Regex.Replace(result, @"\s+", "-");        // Replace spaces with -
            result = Regex.Replace(result, @"[^\w\-] +", "");   // Remove all non-word chars
            result = Regex.Replace(result, @"\-\-+", "-");      // Replace multiple - with single -
            result = Regex.Replace(result, @"\^ -+", "");       // Trim - from start of text
            result = Regex.Replace(result, @"\ -+$", "");       // Trim - from end of text*/


            return result;
        }
    }
}
