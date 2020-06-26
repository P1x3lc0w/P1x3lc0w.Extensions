using System;
using System.Collections.Generic;
using System.Text;

namespace P1x3lc0w.Extensions
{
    public static class StringExtensions
    {
        public static string StripDiscordCodeBlockChars(this string str)
            => str?.Replace("`", "´");
    }
}
