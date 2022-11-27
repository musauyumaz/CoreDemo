using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Abouts.Commands.Update
{
    public class UpdateAboutCommandRequest : IRequest<UpdateAboutCommandResponse>
    {
        public int Id { get; set; }
        public string Detail1 { get; set; }
        public string Detail2 { get; set; }
        public string MapLocation { get; set; }
    }
}
