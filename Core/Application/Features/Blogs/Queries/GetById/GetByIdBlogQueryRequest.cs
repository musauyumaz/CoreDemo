using MediatR;

namespace Application.Features.Blogs.Queries.GetById
{
    public class GetByIdBlogQueryRequest : IRequest<GetByIdBlogQueryResponse>
    {
        public int Id { get; set; }
    }
}
