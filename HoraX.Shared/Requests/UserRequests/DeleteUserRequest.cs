using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoraX.Shared.Requests.UserRequests
{
    public class DeleteUserRequest : Request
    {
        public long Id { get; set; }
    }
}