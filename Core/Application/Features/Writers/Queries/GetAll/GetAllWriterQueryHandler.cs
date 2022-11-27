using Application.Repositories.WriterRepository;
using MediatR;

namespace Application.Features.Writers.Queries.GetAll
{
    public class GetAllWriterQueryHandler : IRequestHandler<GetAllWriterQueryRequest, GetAllWriterQueryResponse>
    {
        private readonly IWriterReadRepository _writerReadRepository;

        public GetAllWriterQueryHandler(IWriterReadRepository writerReadRepository)
        {
            _writerReadRepository = writerReadRepository;
        }

        public async Task<GetAllWriterQueryResponse> Handle(GetAllWriterQueryRequest request, CancellationToken cancellationToken)
        {
            var getAllWriterQueryResponse = _writerReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).ToList();
            return new() {Writers = getAllWriterQueryResponse };
        }
    }
}
