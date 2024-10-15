using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoraX.Shared.Entities;
using HoraX.Shared.Requests.UserSkillRequests;
using HoraX.Shared.Responses;

namespace HoraX.Shared.Handle
{
    public interface IUserSkillHandler
    {
        Task<Response<UserSkill?>> CreateAsync(CreateUserSkillRequest request);
        Task<Response<UserSkill?>> DeleteAsync(DeleteUserSkillRequest request);
        Task<PagedResponse<UserSkill?>> GetBySkillIdAsync(GetBySkillIdUserSkillRequest request);
        Task<PagedResponse<UserSkill?>> GetByUSerIdAsync(GetByUserIdUserSkillRequest request);
        Task<Response<UserSkill?>> UpdateAsync(UpdateUserSkillRequest request);
    }
}