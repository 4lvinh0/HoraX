using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoraX.Shared.Requests.UserSkillRequests
{
    public class GetBySkillIdUserSkillRequest : PagedRequest
    {
        public int SkillId { get; set; }
    }
}