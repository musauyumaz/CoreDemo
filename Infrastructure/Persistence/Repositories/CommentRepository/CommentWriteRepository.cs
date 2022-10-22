using Application.Repositories.CommentRepository;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.CommentRepository
{
    public class CommentWriteRepository : WriteRepository<Comment>, ICommentWriteRepository
    {
        public CommentWriteRepository(BlogDemoDbContext context) : base(context)
        {
        }
    }
}
