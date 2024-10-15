using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoraX.Shared.Requests.SkillRequests
{
    public class UpdateSkillRequest : Request
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Titulo inválido")]
        [MaxLength(80, ErrorMessage = " O titulo deve conter até 80 char")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Descrição inválida")]
        [MaxLength(255, ErrorMessage = "A descrição deve conter até 255 char")]
        public string Description { get; set; } = string.Empty;

    }
}