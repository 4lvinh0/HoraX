using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoraX.Shared.Requests.UserSkillRequests
{
    public class DeleteUserSkillRequest : Request
    {
        public int Id { get; set; }
    }
}