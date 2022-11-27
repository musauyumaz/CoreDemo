using Application.Repositories.CommentRepository;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Comments.Commands.Update
{
    public class UpdateCommentCommandHandler : IRequestHandler<UpdateCommentCommandRequest, UpdateCommentCommandResponse>
    {
        private readonly ICommentWriteRepository _commentWriteRepository;
        private readonly IMapper _mapper;

        public UpdateCommentCommandHandler(ICommentWriteRepository commentWriteRepository, IMapper mapper)
        {
            _commentWriteRepository = commentWriteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateCommentCommandResponse> Handle(UpdateCommentCommandRequest request, CancellationToken cancellationToken)
        {
            Comment mappedComment = _mapper.Map<Comment>(request);
            _commentWriteRepository.Update(mappedComment);
            _commentWriteRepository.Save();
            return new();
        }
    }
}
