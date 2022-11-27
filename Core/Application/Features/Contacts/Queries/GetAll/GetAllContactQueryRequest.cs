using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Contacts.Queries.GetAll
{
    public class GetAllContactQueryRequest : IRequest<GetAllContactQueryResponse>
    {
        public int Size { get; set; }
        public int Page { get; set; }
    }
}
