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
    public class CommentLogic : ICommentLogic
    {
        ICommentRepository _commentRepository = new CommentRepository();

        public IList<CommentDto> Comments()
        {
            return _commentRepository.Comments();
        }
    }
}
