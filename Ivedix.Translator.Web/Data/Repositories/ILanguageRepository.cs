using Ivedix.Translator.Web.Models;
using System.Collections.Generic;

namespace Ivedix.Translator.Web.Data.Repositories
{
    public interface ILanguageRepository
    {
        IEnumerable<Language> GetAllLanguages();
        Language GetLanguageById(int languageId);
        void AddLanguage(Language model);
    }
}