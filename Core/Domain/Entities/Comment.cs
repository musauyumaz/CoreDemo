using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
