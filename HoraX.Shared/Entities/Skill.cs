using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoraX.Shared.Entities
{
    public class Skill
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        
        public ICollection<UserSkill>? UserSkills { get; set; }
        public ICollection<Transaction>? TransactionsFrom { get; set; }
        public ICollection<Transaction>? TransactionsFor { get; set; }
    }
}