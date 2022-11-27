using Application.Repositories.CategoryRepository;
using MediatR;

namespace Application.Features.Categories.Commands.Remove
{
    public class RemoveCategoryCommandHandler : IRequestHandler<RemoveCategoryCommandRequest, RemoveCategoryCommandResponse>
    {
        private readonly ICategoryWriteRepository _categoryWriteRepository;

        public RemoveCategoryCommandHandler(ICategoryWriteRepository categoryWriteRepository)
        {
            _categoryWriteRepository = categoryWriteRepository;
        }

        public async Task<RemoveCategoryCommandResponse> Handle(RemoveCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            _categoryWriteRepository.Remove(request.Id);
            _categoryWriteRepository.Save();
            return new();
        }
    }
}
