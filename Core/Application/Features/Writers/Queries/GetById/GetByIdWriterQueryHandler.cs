using Application.Repositories.WriterRepository;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Writers.Queries.GetById
{
    public class GetByIdWriterQueryHandler : IRequestHandler<GetByIdWriterQueryRequest, GetByIdWriterQueryResponse>
    {
        private readonly IWriterReadRepository _writerReadRepository;
        private readonly IMapper _mapper;

        public GetByIdWriterQueryHandler(IWriterReadRepository writerReadRepository, IMapper mapper)
        {
            _writerReadRepository = writerReadRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdWriterQueryResponse> Handle(GetByIdWriterQueryRequest request, CancellationToken cancellationToken)
        {
            Writer writer = _writerReadRepository.GetById(request.Id,false);
            GetByIdWriterQueryResponse mappedWriter = _mapper.Map<GetByIdWriterQueryResponse>(writer);
            return mappedWriter;
        }
    }
}
