using Application.Repositories.CategoryRepository;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Commands.Create
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, CreateCategoryCommandResponse>
    {
        private readonly ICategoryWriteRepository _categoryWriteRepository;
        private readonly IMapper _mapper;
        public CreateCategoryCommandHandler(ICategoryWriteRepository categoryWriteRepository, IMapper mapper)
        {
            _categoryWriteRepository = categoryWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            _categoryWriteRepository.Add(new() { Name = request.Name, Description = request.Description });
            _categoryWriteRepository.Save();
            return new();
        }
    }
}
