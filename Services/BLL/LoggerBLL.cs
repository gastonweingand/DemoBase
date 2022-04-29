using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL
{
    internal static class LoggerBLL
    {
     
        public static void WriteLog(string message, EventLevel level, string user)
        {
            DAL.LoggerRepository.WriteLog(message, level, user);

            //Definir acá las políticas de escritura..
            //switch(level)
            //{
            //    case EventLevel.Critical:
            //        //Política de manejo de errores...

            //        break;

            //    case EventLevel.Warning:
            //        break;
            //}

        }
    }
}
