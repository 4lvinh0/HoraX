using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoraX.Shared.Entities;
using HoraX.Shared.Requests.TransactionRequests;
using HoraX.Shared.Responses;

namespace HoraX.Shared.Handle
{
    public interface ITransactionHandler
    {
        Task<Response<Transaction?>> CreateAsync(CreateTransactionRequest request);
        
        Task<Response<Transaction?>> DeleteAsync(DeleteTransactionRequest request);

        Task<PagedResponse<Transaction?>> GetByForUserIdAndAccepted(GetByForUserIdAndAcceptedTransactionRequest request);

        Task<PagedResponse<Transaction?>> GetByForUserId(GetByForUserIdTransactionRequest request);

        Task<PagedResponse<Transaction?>> GetByFromUserIdAndAccepted(GetByFromUserIdAndAcceptedTransactionRequest request);

        Task<PagedResponse<Transaction?>> GetByFromUserId(GetByFromUserIdTransactionRequest request);

        Task<Response<Transaction?>> GetById(GetByIdTransactionRequest request);

        Task<Response<Transaction?>> UpdateAccepted(UpdateAcceptedTransactionRequest request);
    }
}