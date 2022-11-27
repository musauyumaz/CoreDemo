using Application.Repositories.CategoryRepository;
using Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Queries.GetById
{
    public class GetByIdCategoryQueryHandler : IRequestHandler<GetByIdCategoryQueryRequest, GetByIdCategoryQueryResponse>
    {
        private readonly ICategoryReadRepository _categoryReadRepository;

        public GetByIdCategoryQueryHandler(ICategoryReadRepository categoryReadRepository)
        {
            _categoryReadRepository = categoryReadRepository;
        }

        public async Task<GetByIdCategoryQueryResponse> Handle(GetByIdCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            Category category = _categoryReadRepository.GetById(request.Id);
            return new()
            {
                Description = category.Description,
                Name = category.Name,
            };
        }
    }
}
