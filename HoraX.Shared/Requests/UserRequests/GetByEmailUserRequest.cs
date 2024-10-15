using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoraX.Shared.Requests.UserRequests
{
    public class GetByEmailUserRequest : Request
    {
        public string? Email { get; set; }
    }
}