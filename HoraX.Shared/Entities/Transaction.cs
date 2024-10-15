using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoraX.Shared.Entities
{
    public class Transaction
    {
        public int Id { get; set; }


        public int FromUserId { get; set; }
        public int HoursFrom { get; set; }
        public required Skill SkillFrom { get; set; }


        public int ForUserId { get; set; }
        public int HoursFor { get; set; }
        public bool? Accepted { get; set; } = null;
        public required Skill SkillFor { get; set; }


        public int Text { get; set; }
    }
}