using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.DAL
{
    internal static class LoggerRepository
    {
        private static string pathLog = ConfigurationManager.AppSettings["PathLog"];

        private static string pathFile = ConfigurationManager.AppSettings["LogFileName"]; 
        public static void WriteLog(string message, EventLevel level, string user)            
        {
            string fileName = pathLog + DateTime.Now.ToString("yyyyMMdd") + pathFile;

            //Aplicar sus políticas...
            //1 opción: En función de la severity que configuren en su app.config
            //Registro desde ese nivel hacia arriba...
            //2 política de limpieza: Definir cada cuánto tiempo/tamaño? limpio mis logs...

            using (StreamWriter streamWriter = new StreamWriter(fileName, true))
            {
                string fromattedMessage = $"{DateTime.Now.ToString("yyyyMMdd hh:mm:ss tt")} [LEVEL {level.ToString()}] User: {user}, Mensaje: {message}";
                streamWriter.WriteLine(fromattedMessage);
            }

          
        }
    }
}
