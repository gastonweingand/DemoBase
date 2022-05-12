using Services.DAL.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Factory
{
    internal static class ServiceFactory
    {
        public static LanguageRepository LanguageRepository { get; private set; }

        public static LoggerRepository LoggerRepository { get; private set; }

    }
}
