using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApp.Extensions
{
    public static class StringExtensions
    {
        public static bool IsEmpty(this string text)
        {
            return string.IsNullOrEmpty(text);
        }
    }
}
