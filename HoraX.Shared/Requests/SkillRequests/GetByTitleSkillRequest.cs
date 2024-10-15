using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoraX.Shared.Requests.SkillRequests
{
    public class GetByTitleSkillRequest : Request
    {
        public string Title { get; set; } = string.Empty;
    }
}   