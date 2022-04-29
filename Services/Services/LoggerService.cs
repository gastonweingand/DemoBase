using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public static class LoggerService
    {
        public static void WriteLog(string message, EventLevel level, string user)
        {
            BLL.LoggerBLL.WriteLog(message, level, user);
        }
    }
}
