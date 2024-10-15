using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoraX.Shared.Entities
{
    public class User
    {
        public int Id { get; set; }

        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }
        public required string Name { get; set; }

        public ICollection<UserSkill>? UserSkills { get; set; }
    }
}