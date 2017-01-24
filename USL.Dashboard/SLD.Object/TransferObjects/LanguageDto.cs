using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLD.Object.TransferObjects
{
    public class LanguageDto
    {
        public int LanguageID { get; set; }
        public string Language1 { get; set; }
        public string StringToVoiceUrl { get; set; }
        public int Gestures { get; set; }
        public List<GestureDto> GestureDtos { get; set; }
    }
}
