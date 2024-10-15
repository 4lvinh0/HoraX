using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoraX.Shared.Entities;
using HoraX.Shared.Requests.TransactionRequests;
using HoraX.Shared.Responses;

namespace HoraX.Shared.Handle
{
    public interface TransactionHandler
    {
        Task<Response<Skill?>> CreateAsync(CreateTransactionRequest request);
        
        Task<Response<Skill?>> DeleteAsync(DeleteTransactionRequest request);

        Task<Response<Skill?>> GetByForUserIdAndAccepted(GetByForUserIdAndAcceptedTransactionRequest request);

        Task<Response<Skill?>> GetByForUserId(GetByForUserIdTransactionRequest request);

        Task<Response<Skill?>> GetByFromUserIdAndAccepted(GetByFromUserIdAndAcceptedTransactionRequest request);

        Task<Response<Skill?>> GetByFromUserId(GetByFromUserIdTransactionRequest request);

        Task<Response<Skill?>> GetById(GetByIdTransactionRequest request);

        Task<Response<Skill?>> UpdateAccepted(UpdateAcceptedTransactionRequest request);
    }
}