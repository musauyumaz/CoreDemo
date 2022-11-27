using Application.Repositories.CommentRepository;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Comments.Queries.GetById
{
    public class GetByIdCommentQueryHandler : IRequestHandler<GetByIdCommentQueryRequest, GetByIdCommentQueryResponse>
    {
        private readonly ICommentReadRepository _commentReadRepository;
        private readonly IMapper _mapper;

        public GetByIdCommentQueryHandler(ICommentReadRepository commentReadRepository, IMapper mapper)
        {
            _commentReadRepository = commentReadRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdCommentQueryResponse> Handle(GetByIdCommentQueryRequest request, CancellationToken cancellationToken)
        {
            Comment comment = _commentReadRepository.GetById(request.Id,false);
            return _mapper.Map<GetByIdCommentQueryResponse>(comment);
        }
    }
}
