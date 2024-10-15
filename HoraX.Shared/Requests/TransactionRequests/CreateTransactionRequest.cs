using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HoraX.Shared.Entities;

namespace HoraX.Shared.Requests.TransactionRequests
{
    public class CreateTransactionRequest : Request
    {
        [Required]
        public int FromUserId { get; set; }
        public int HoursFrom { get; set; }
        public required Skill SkillFrom { get; set; }

        [Required]
        public int ForUserId { get; set; }
        public int HoursFor { get; set; }
        public required Skill SkillFor { get; set; }

        [Required(ErrorMessage = "Descrição inválida")]
        [MaxLength(512, ErrorMessage = "O texto deve conter até 512 char")]
        public int Text { get; set; }
    }
}