using Application.Repositories.CommentRepository;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Comments.Commands.Create
{
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommandRequest, CreateCommentCommandResponse>
    {
        private readonly ICommentWriteRepository _commentWriteRepository;
        private readonly IMapper _mapper;

        public CreateCommentCommandHandler(ICommentWriteRepository commentWriteRepository, IMapper mapper)
        {
            _commentWriteRepository = commentWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateCommentCommandResponse> Handle(CreateCommentCommandRequest request, CancellationToken cancellationToken)
        {
            Comment mappedComment = _mapper.Map<Comment>(request);
            _commentWriteRepository.Add(mappedComment);
            _commentWriteRepository.Save();
            return new();
        }
    }
}
