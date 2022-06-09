using Services.DAL.Factory;
using Services.DAL.Implementations;
using Services.DomainModel.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL
{
    internal static class LanguageBLL
    {
        //Aplicar reglas de negocio:
        //Exception, null, bool
        public static string Translate(string word)
        {
            try
            {
                return ServiceFactory.LanguageRepository.Find(word);
            }
            catch (WordNotFoundException)
            {
                ServiceFactory.LanguageRepository.WriteNewWord(word, String.Empty);
                return word;
            }
        }
    }
}
