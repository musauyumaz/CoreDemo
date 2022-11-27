using Domain.Entities;

namespace Application.Features.Blogs.Queries.GetAll
{
    public class GetAllBlogQueryResponse
    {
        public IList<Blog> Blogs { get; set; }
    }
}
