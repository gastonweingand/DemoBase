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
                return DAL.LanguageRepository.Find(word);
            }
            catch (WordNotFoundException ex)
            {
                DAL.LanguageRepository.WriteNewWord(word, String.Empty);
                return word;
            }
        }
    }
}
