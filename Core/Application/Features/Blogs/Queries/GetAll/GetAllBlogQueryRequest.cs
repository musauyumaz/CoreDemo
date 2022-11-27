using MediatR;

namespace Application.Features.Blogs.Queries.GetAll
{
    public class GetAllBlogQueryRequest : IRequest<GetAllBlogQueryResponse>
    {
        public int Size { get; set; }
        public int Page { get; set; }
    }
}
