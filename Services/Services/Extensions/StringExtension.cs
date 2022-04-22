using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Extensions
{
    public static class StringExtension
    {
        public static string Translate(this string word)
        {
            return BLL.LanguageBLL.Translate(word);
        }
    }
}
