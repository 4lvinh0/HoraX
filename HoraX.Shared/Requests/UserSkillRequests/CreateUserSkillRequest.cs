using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoraX.Shared.Requests.UserSkillRequests
{
    public class CreateUserSkillRequest : Request
    {
        public int IdUser { get; set; }
        public int SkillId { get; set; }
        public int Proficiency { get; set; }

    }
}