using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Blogs.Commands.Remove
{
    public class RemoveBlogCommandRequest : IRequest<RemoveBlogCommandResponse>
    {
        public int Id { get; set; }
    }
}
