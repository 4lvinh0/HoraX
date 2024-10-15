using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoraX.Shared.Entities;
using HoraX.Shared.Requests.SkillRequests;
using HoraX.Shared.Responses;

namespace HoraX.Shared.Handle
{
    public interface ISkillHandler
    {
        Task<Response<Skill?>> CreateAsync(CreateSkillRequest request);

        Task<Response<Skill?>> DeleteAsync(DeleteSkillRequest request);

        Task<Response<Skill?>> GetByIdAsync(GetByIdSkillRequest request);

        Task<Response<Skill?>> GetByTitleAsync(GetByTitleSkillRequest request);

        Task<Response<Skill?>> UpdateAsync(UpdateSkillRequest request);
    }
}