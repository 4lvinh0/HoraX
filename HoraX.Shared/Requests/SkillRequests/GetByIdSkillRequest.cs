using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoraX.Shared.Requests.SkillRequests
{
    public class GetByIdSkillRequest : Request
    {
        public long Id { get; set; }
    }
}