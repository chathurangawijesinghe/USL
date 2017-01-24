using SLD.Model.Interfaces;
using SLD.Object.TransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLD.Model.Implementation
{
    public class CommentRepository : ICommentRepository
    {
        SLD_DatabaseEntities context = new SLD_DatabaseEntities();

        public IList<CommentDto> Comments()
        {
            return context.Comments.Select(c => new CommentDto
            {
                CommentId = c.CommentId,
                UserComment = c.UserComment,
                UserId = c.UserId,
                User = context.Users.Where(u => u.UserId == c.UserId).Select(u => u.Firstname + " " + u.Lastname).FirstOrDefault()
            }).ToList();
        }
    }
}
