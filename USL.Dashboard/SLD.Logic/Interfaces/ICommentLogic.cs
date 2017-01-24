using SLD.Object.TransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLD.Logic.Interfaces
{
    public interface ICommentLogic
    {
        IList<CommentDto> Comments();
    }
}
