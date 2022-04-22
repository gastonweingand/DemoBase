using Services.DomainModel.Exceptions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.DAL
{
    internal static class LanguageRepository
    {
        private static string basePath = ConfigurationManager.AppSettings["LanguagePath"];

        public static string Find(string word)
        {
            using(var sr = new StreamReader(basePath + "." + Thread.CurrentThread.CurrentCulture.Name))
            {
                while(!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split('=');

                    if (line[0] == word)
                    //Encontré la clave buscada...
                    {
                        if (String.IsNullOrEmpty(line[1]))
                            //Aplicar una bitácora...
                            return line[0];

                        return line[1];//Retorno la traducción...
                    }
                }
            }

            throw new WordNotFoundException();
        }

        public static void WriteNewWord(string word, string value)
        {


        }

        public static Dictionary<string, string> FindAll()
        {
            return null;
        }

        /// <summary>
        /// Generar una implementación que lea las extensiones de todos mis archivos dentro de I18n
        /// </summary>
        /// <returns></returns>
        public static List<string> GetCurrentCultures()
        {
            return new List<string>();
        }

    }
}
