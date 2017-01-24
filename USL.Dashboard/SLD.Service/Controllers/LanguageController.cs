using SLD.Logic.Implementation;
using SLD.Logic.Interfaces;
using SLD.Object.TransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SLD.Service.Controllers
{
    public class LanguageController : ApiController
    {
        ILanguageLogic _languageLogic = new LanguageLogic();

        public IEnumerable<LanguageDto> GetAllLanguages()
        {
            return _languageLogic.GetAllLanguages();
        }
        
        public List<GestureDto> GetLanguageData(int languageId)
        {
            return _languageLogic.GetLanguageData(languageId);
        }
    }
}
