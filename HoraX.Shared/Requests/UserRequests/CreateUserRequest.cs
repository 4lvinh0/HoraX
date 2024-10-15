using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoraX.Shared.Requests.UserRequests
{
    public class CreateUserRequest : Request
    {
        public required string Email { get; set; }
        public required string Name { get; set; }
    }
}