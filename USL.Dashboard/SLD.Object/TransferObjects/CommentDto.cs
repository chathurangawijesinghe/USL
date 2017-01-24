using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLD.Object.TransferObjects
{
    public class CommentDto
    {
        public int CommentId { get; set; }
        public string UserComment { get; set; }
        public int UserId { get; set; }
        public string User { get; set; }
    }
}
