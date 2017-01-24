using SLD.Model.Interfaces;
using SLD.Object.TransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLD.Model.Implementation
{
    public class LanguageRepository : ILanguageRepository
    {
        SLD_DatabaseEntities context = new SLD_DatabaseEntities();

        public IList<LanguageDto> Languages()
        {
            return context.Languages.Select(l => new LanguageDto
            {
                LanguageID = l.LanguageID,
                Language1 = l.Language1,
                Gestures = context.GestureMappers.Where(gm => gm.LanguageID == l.LanguageID).ToList().Count
            }).ToList();
        }
    }
}
