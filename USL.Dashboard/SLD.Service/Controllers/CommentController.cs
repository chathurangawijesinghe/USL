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
    public class CommentController : ApiController
    {
        ICommentLogic _commentLogic = new CommentLogic();

        public IEnumerable<CommentDto> GetAllComments()
        {
            return _commentLogic.Comments();
        }
    }
}
