using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoraX.Shared.Requests.UserSkillRequests
{
    public class UpdateUserSkillRequest : Request
    {
        public int Id { get; set; }
        public int Proficiency { get; set; }

    }
}