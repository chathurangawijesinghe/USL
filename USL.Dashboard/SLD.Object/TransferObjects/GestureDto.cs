using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLD.Object.TransferObjects
{
    public class GestureDto
    {
        public int GestureMapperId { get; set; }
        public int UserId { get; set; }
        public int GestureId { get; set; }
        public string Matrix { get; set; }
        public int Fingers { get; set; }
        public int Hands { get; set; }
        public string Voice { get; set; }
        public string AudioFile { get; set; }
        public string GestureName { get; set; }

    }
}
