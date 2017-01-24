using SLD.Object.TransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLD.Logic.Interfaces
{
    public interface ILanguageLogic
    {
        IEnumerable<LanguageDto> GetAllLanguages();

        List<GestureDto> GetLanguageData(int languageId);
    }
}
