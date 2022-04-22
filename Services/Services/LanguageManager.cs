using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    internal static class LanguageManager
    {
        public static string Translate(string word)
        {
            return BLL.LanguageBLL.Translate(word);
        }

    }
}
