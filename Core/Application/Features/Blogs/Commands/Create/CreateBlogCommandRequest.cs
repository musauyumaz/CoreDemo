using MediatR;

namespace Application.Features.Blogs.Commands.Create
{
    public class CreateBlogCommandRequest : IRequest<CreateBlogCommandResponse>
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
