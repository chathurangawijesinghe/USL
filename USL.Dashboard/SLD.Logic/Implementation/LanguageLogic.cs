using SLD.Logic.Interfaces;
using SLD.Model.Implementation;
using SLD.Model.Interfaces;
using SLD.Object.TransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLD.Logic.Implementation
{
    public class LanguageLogic : ILanguageLogic
    {
        ILanguageRepository _languageRepository = new LanguageRepository();

        public IEnumerable<LanguageDto> GetAllLanguages()
        {
            return _languageRepository.Languages();
        }
        
        public List<GestureDto> GetLanguageData(int languageId)
        {
            return _languageRepository.GetLanguageData(languageId);
        }
    }
}
