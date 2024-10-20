using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using HoraX.Shared.Entities;
using HoraX.Shared.Requests.UserRequests;
using HoraX.Shared.Responses;

namespace HoraX.Shared.Handle
{
    public interface IUserHandler
    {
        //Task<Response<Transaction?>>
        //Task<PagedResponse<Transaction?>>

        Task<Response<User?>> CreateAsync(CreateUserRequest request);
        Task<Response<User?>> DeleteAsync(DeleteUserRequest request);
        Task<Response<User?>> GetByEmailAsync(GetByEmailUserRequest request);
        Task<Response<User?>> GetByIdAsync(GetByIdUserRequest request);
        Task<PagedResponse<User?>> GetByNameAsync(GetByNameUserRequest request);
        Task<Response<User?>> UpdateAsync(UpdateUserRequest request);
    }
}