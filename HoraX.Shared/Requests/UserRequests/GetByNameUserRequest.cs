using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoraX.Shared.Requests.UserRequests
{
    public class GetByNameUserRequest : PagedRequest
    {
        public string? Name { get; set; }
    }
}