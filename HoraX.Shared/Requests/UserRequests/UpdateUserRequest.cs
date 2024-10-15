using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoraX.Shared.Requests.UserRequests
{
    public class UpdateUserRequest : Request
    {
        [Required]
        public long Id { get; set; }
        public required string Email { get; set; }
        public required string Name { get; set; }
    }
}