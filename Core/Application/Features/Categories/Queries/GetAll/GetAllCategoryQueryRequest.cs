using MediatR;

namespace Application.Features.Categories.Queries.GetAll
{
    public class GetAllCategoryQueryRequest : IRequest<GetAllCategoryQueryResponse>
    {
        public int Size { get; set; } = 5;
        public int Page { get; set; } = 0;
    }

}

