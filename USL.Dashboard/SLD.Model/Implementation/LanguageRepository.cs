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

        public List<GestureDto> GetLanguageData(int languageId)
        {
            return context.GestureMappers.Where(i => i.LanguageID == languageId).Select(gm => new GestureDto {
                GestureId = gm.GestureID,
                GestureMapperId = gm.GestureMapperID,
                Fingers = gm.Gesture.Fingers,
                Hands = gm.Gesture.Hands,
                Matrix = gm.Gesture.Matrix,
                Voice = gm.Voice,
                AudioFile = gm.AudioFile,
                GestureName = gm.Gesture.GestureName
            }).ToList();
        }
    }
}
