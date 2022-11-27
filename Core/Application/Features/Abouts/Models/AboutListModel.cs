using Application.Features.Abouts.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Abouts.Models
{
    public class AboutListModel
    {
        public IList<AboutListDto> Abouts { get; set; }
    }
}
